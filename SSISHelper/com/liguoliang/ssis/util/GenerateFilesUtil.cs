/*
 * 
 * All Rights Reserved
 * Changelog:
 *  Guoliang - Dec 2, 2012: Initial version
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Microsoft.SqlServer.Dts.Runtime;

namespace SSISHelper
{
    class GenerateFilesUtil
    {
        static String FOLDER_NAME_DTSX = "DTSX";
        static String FOLDER_NAME_LOGS = "Logs";
        static String FOLDER_NAME_AUTO_SYS = "AutoSysConf";
        static String FOLDER_NAME_TEMPLATE = "template";

        public String pathDirRoot;
        String pathDirAutoSysConf;
        String pathDirLogs;
        String pathDirDts;
        String pathDirTemplate;

        String[] filesDTSx;

        public string strResult = "";

        // 1. Generate DTS conf
        // 2. Generate DTS CMD

        // 3. Generate Notify ini file
        // 4. Generate Notify CMD.

        public void generateFiles()
        {
            strResult = "";
            prepareFolders();

            // Get DTSx file list
            filesDTSx = Directory.GetFiles(pathDirRoot + "\\DTSX", "*.dtsx");

            // textOutput.Text = "DTSx Files: \n";
            // foreach (String fileName in filesDTSx)
            // {
             //   textOutput.Text += "\n" + fileName;
            // }

            // pathDirAutoSysConf = System.IO.Path.Combine(pathDirRoot, "AutoSysConf");
            // createFolderIfNotExists(pathDirAutoSysConf);

            ArrayList listOfDtsxConfs = generateDtsConfs();
            generateDtsxBAT(listOfDtsxConfs);

            ArrayList listNotifyIniFiles = generateNotifyIniFiles();
            generateNotifyCMDFiles(listNotifyIniFiles);
        }

        /**
         * Create the folders if not exists. 
         */
        public void prepareFolders()
        {
            // Prepare the paths
            pathDirDts = Path.Combine(pathDirRoot, FOLDER_NAME_DTSX);
            pathDirLogs = Path.Combine(pathDirRoot, FOLDER_NAME_LOGS);
            pathDirAutoSysConf = Path.Combine(pathDirRoot, FOLDER_NAME_AUTO_SYS);
            pathDirTemplate = Path.Combine(pathDirRoot, FOLDER_NAME_TEMPLATE);

            // Create path if not exists. 
            createFolderIfNotExists(pathDirDts);
            createFolderIfNotExists(pathDirLogs);
            createFolderIfNotExists(pathDirAutoSysConf);
            createFolderIfNotExists(pathDirTemplate);
        }

        /**
         * Generate DTSX conf files based on the dtsx files.
         */
        private ArrayList generateDtsConfs()
        {
            ArrayList listOfDtsxConfs = new ArrayList();

            foreach (String pathDtsx in filesDTSx)
            {
                String pathDtsxConf = pathDtsx + ".conf";
                backupFileIfExists(pathDtsxConf);

                String pathDtsConfTemplate = Path.Combine(pathDirTemplate, "dts.conf");
                String strConfTemp = getFileContents(pathDtsConfTemplate);

                strConfTemp = strConfTemp.Replace("{%DTSFile%}", pathDtsx);

                Connections conns = getDTSConns(pathDtsx);
                foreach (ConnectionManager cm in conns)
                {
                    strConfTemp += Environment.NewLine + "/CIMBCONN#" + cm.Name + @"#D:\CIMB\DownloadJobs\master.conf";
                    //Console.WriteLine("Name = " + cm.Name + ", HostType = " + cm.HostType + "; ConnectionString=" + cm.ConnectionString);
                }

                strConfTemp += Environment.NewLine + "/cons NCOSGXMT";

                File.WriteAllText(pathDtsxConf, strConfTemp);
                listOfDtsxConfs.Add(pathDtsxConf);
            }

            return listOfDtsxConfs;
        }

        /**
         * Generate DTSx BAT files based on the given DTSx conf files
         */
        private void generateDtsxBAT(ArrayList listOfConfigs)
        {
            foreach (String pathDtsxConf in listOfConfigs)
            {
                string pathDtsxBat = getFileNameByPath(pathDtsxConf, true);
                pathDtsxBat = Path.Combine(pathDirRoot, pathDtsxBat + ".bat");
                backupFileIfExists(pathDtsxBat);

                String pathDtsBatTemplate = Path.Combine(pathDirTemplate, "dts.bat");
                String strDtsxBat = getFileContents(pathDtsBatTemplate);

                strDtsxBat = strDtsxBat.Replace("{%DTSConfFile%}", pathDtsxConf);

                String strDtsxName = getFileNameByPath(pathDtsxConf, false);
                String strDtsxLog = getLogPathForDTSX(strDtsxName);

                strDtsxBat = strDtsxBat.Replace("{%DTSLogFile%}", strDtsxLog);

                File.WriteAllText(pathDtsxBat, strDtsxBat);
                strResult += Environment.NewLine + pathDtsxBat;
            }
        }

        /**
         * Generate Notify INI for AutoSys, based on the DTS files. 
         * Conversion:  DTSx logs root/Logs/dtsxName.txt
         */
        private ArrayList generateNotifyIniFiles()
        {
            ArrayList listNotifyIniFiles = new ArrayList();
            foreach (String dtsFileName in filesDTSx)
            {
                String dtsFileNameOnly = getFileNameByPath(dtsFileName);
                //dtsFileName.Substring(dtsFileName.LastIndexOf("\\") + 1, dtsFileName.Length - dtsFileName.LastIndexOf("\\") - 1);
                String notifyFileName = dtsFileNameOnly;
                notifyFileName = notifyFileName + ".sendEmail.ini";
                String pathNotifyIni = System.IO.Path.Combine(pathDirAutoSysConf, notifyFileName);

                // back up if already generate/modified
                backupFileIfExists(pathNotifyIni);

                String pathSendEmailIniTemplate = Path.Combine(pathDirTemplate, "SendMail.ini");
                // Read template, and replace some config data.
                string strNotifyINIContent = getFileContents(pathSendEmailIniTemplate);

                strNotifyINIContent = strNotifyINIContent.Replace("{%Email%}", "guoliang.li@cimb.com");

                String pathLogFile = getLogPathForDTSX(dtsFileNameOnly);
                strNotifyINIContent = strNotifyINIContent.Replace("{%LogFile%}", pathLogFile);

                strNotifyINIContent = strNotifyINIContent.Replace("{%Subjest%}", "Download Job Failed: " + dtsFileNameOnly);
                strNotifyINIContent = strNotifyINIContent.Replace("{%Date%}", DateTime.Now.ToString("MM/dd/yyyy H:mm:ss zzz"));

                File.WriteAllText(pathNotifyIni, strNotifyINIContent);

                // add to list for next step.
                listNotifyIniFiles.Add(pathNotifyIni);
            }

            return listNotifyIniFiles;
        }

        /**
         * Generate Notify CMD for AutoSys.
         */
        private void generateNotifyCMDFiles(ArrayList listNotifyINIPaths)
        {
            foreach (String notifyININame in listNotifyINIPaths)
            {
                String pathNotifyCMD = notifyININame + ".bat";
                backupFileIfExists(pathNotifyCMD);

                String pathSendMailBatTemplate = Path.Combine(pathDirTemplate, "SendMail.bat");
                String strSendMailBat = getFileContents(pathSendMailBatTemplate);

                strSendMailBat = strSendMailBat.Replace("{%NotifyINIFile%}", notifyININame);

                strResult += Environment.NewLine + pathNotifyCMD;

                File.WriteAllText(pathNotifyCMD, strSendMailBat);
            }
        }

        private void createFolderIfNotExists(String path)
        {
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void backupFileIfExists(String pathFile)
        {
            if (File.Exists(pathFile))
            {
                File.Copy(pathFile, pathFile + ".Backup@" + DateTime.Now.ToFileTimeUtc());
            }

        }

        private String getFileNameByPath(String path)
        {
            String name = path.Substring(path.LastIndexOf("\\") + 1, path.Length - path.LastIndexOf("\\") - 1);
            return name;
        }

        private String getFileNameByPath(String path, Boolean includeExt)
        {
            String name = getFileNameByPath(path);
            if (!includeExt)
            {
                name = name.Substring(0, name.LastIndexOf("."));
            }
            return name;
        }

        private String getFileContents(String pathFile)
        {
            if (File.Exists(pathFile))
            {
                return File.ReadAllText(pathFile);
            }else {
                return "";
            }

        }

        private String getLogPathForDTSX(String dtsName)
        {
            return Path.Combine(pathDirLogs, dtsName + ".log");
        }

        private Connections getDTSConns(String pkgLocation)
        {

            Microsoft.SqlServer.Dts.Runtime.Application app = new Microsoft.SqlServer.Dts.Runtime.Application();
            Package pkg = app.LoadPackage(pkgLocation, null);

            Connections conns = pkg.Connections;
            foreach (ConnectionManager cm in conns)
            {
                Console.WriteLine("Name = " + cm.Name + ", HostType = " + cm.HostType + "; ConnectionString=" + cm.ConnectionString);
            }

            return conns;
        }

    }
}
