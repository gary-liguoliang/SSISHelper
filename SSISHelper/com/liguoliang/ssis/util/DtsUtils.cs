using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Dts.Runtime;

namespace SSISHelper.com.liguoliang.ssis.util
{
    class DtsUtils
    {
        /**
         * Change DTSX package password
         */
        public static void ChangePassword(String pkgLocation, String oldPassword, DTSProtectionLevel dtsPrdLevel, String newPassword)
        {
            Application app = new Application();

            if (oldPassword != null && oldPassword.Trim() != "")
            {
                app.PackagePassword = oldPassword;
            }

            Package pkg = app.LoadPackage(pkgLocation, null);

            // Modify the password
            pkg.ProtectionLevel = dtsPrdLevel;
            pkg.PackagePassword = newPassword;

            // Save dts pacakge
            app.SaveToXml(pkgLocation, pkg, null);
        }

        public static void UpdateAllPkgPassword(String pathRoot, String oldPassword, DTSProtectionLevel dtsPrdLevel, String newPassword)
        {
            String[] DtsFiles = FileUtils.GetAllDtsPkgs(pathRoot);
            foreach (String DtsPkg in DtsFiles)
            {
                ChangePassword(DtsPkg, oldPassword, dtsPrdLevel, newPassword);
            }
        }

        /**
         * List connections for one DTS. 
         */

        public static Connections getDTSConns(String pkgLocation)
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

        public static ArrayList getAllDtsConns(String rootPath)
        {
            ArrayList arrayListAllConns = new ArrayList();

            String[] dtsFiles = FileUtils.GetAllDtsPkgs(rootPath);
            foreach(String dtsFilePath in dtsFiles) {
                Connections conns = getDTSConns(dtsFilePath);
                foreach(ConnectionManager cm in conns) {
                    arrayListAllConns.Add(cm);
                }
            }

            return arrayListAllConns;
        }

        /**
         * Based on the given connname dict, to update the conn in the given dts package. 
         */
        public static void updateConnName(String pathPkg, Dictionary<String, String> dictNewConnNames)
        {

            Microsoft.SqlServer.Dts.Runtime.Application app = new Microsoft.SqlServer.Dts.Runtime.Application();
            Package pkg = app.LoadPackage(pathPkg, null);

            Connections conns = pkg.Connections;
            foreach (ConnectionManager cm in conns)
            {
                if (dictNewConnNames.ContainsKey(cm.Name))
                {
                    cm.Name = dictNewConnNames[cm.Name];
                }
            }

            app.SaveToXml(pathPkg, pkg, null);
        }

        public static void updateConnNameForAllDtsx(String rootPath, Dictionary<String, String> dictConnNames)
        {
            String[] dtsxs = FileUtils.GetAllDtsPkgs(rootPath);
            foreach (String pathPkg in dtsxs)
            {
                updateConnName(pathPkg, dictConnNames);
            }
        }
         
    }
}
