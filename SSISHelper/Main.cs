using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using SSISHelper.com.liguoliang.ssis.util;

namespace SSISHelper
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            textBoxPath.Text = "C:\\Users\\Guoliang\\Desktop\\CIMB\\DownloadJobs\\CISpen";
        }

        private void onButtonGenerateFilesClicked(object sender, EventArgs e)
        {
            textOutput.Text += Environment.NewLine + "Preparing the folders and generating files...";
            String pathDirRootInput = textBoxPath.Text.Trim();
            // pathDirRoot = pathDirRootInput;
            // generateFiles();
            GenerateFilesUtil sh = new GenerateFilesUtil();
            sh.pathDirRoot = pathDirRootInput;
            sh.generateFiles(checkBoxOverride.Checked);
            textOutput.Text += Environment.NewLine + "Completed.";
            textOutput.Text += sh.strResult;
        }

        private void onButtonPrepareFoldersClicked(object sender, EventArgs e)
        {
            textOutput.Text += Environment.NewLine + "Preparing the folders...";
            String pathDirRootInput = textBoxPath.Text.Trim();
            // pathDirRoot = pathDirRootInput;
            // generateFiles();
            GenerateFilesUtil sh = new GenerateFilesUtil();
            sh.pathDirRoot = pathDirRootInput;
            sh.prepareFolders();

            textOutput.Text += Environment.NewLine + "Completed.";
        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void onButtonChangePwClicked(object sender, EventArgs e)
        {
            DtsUtils.UpdateAllPkgPassword(textBoxPath.Text, textBoxOldPassword.Text, Microsoft.SqlServer.Dts.Runtime.DTSProtectionLevel.EncryptAllWithPassword, textBoxNewPw.Text);

        }

        private void onButtonTestClicked(object sender, EventArgs e)
        {
            FileUtils.GetAllDtsPkgs(textBoxPath.Text.Trim());

        }

        private void OnButtonListAllDtsxClicked(object sender, EventArgs e)
        {
            textOutput.Text += Environment.NewLine + "All Dtsx packages:";
            String[] dtsFiles = FileUtils.GetAllDtsPkgs(textBoxPath.Text.Trim());
            foreach (String DtsFile in dtsFiles)
            {
                textOutput.Text += Environment.NewLine + DtsFile;
            }
        }

    }
}
