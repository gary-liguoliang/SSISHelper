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
using Microsoft.SqlServer.Dts.Runtime;

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
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textOutput.Text += "\n" + folderBrowserDialog1.SelectedPath;
            }

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

        private void ListAllDtsConns_Click(object sender, EventArgs e)
        {
            ArrayList arrayListConns = DtsUtils.getAllDtsConns(textBoxPath.Text.Trim());
            StringBuilder sb = new StringBuilder();
            ISet<String> setConnNames = new HashSet<String>();

            foreach (ConnectionManager cm in arrayListConns)
            {
                if(!setConnNames.Contains(cm.Name)) {
                    setConnNames.Add(cm.Name);
                    sb.Append("\n").Append(cm.Name);
                }
                
            }

            textOutput.Text += sb.ToString();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void OldPw_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNewPw_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxOverride_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnUpdateConnName_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Update all dtsx name?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            // prepare the conn name pair.
            Dictionary<String, String> dictConnNames = new Dictionary<string, string>();

            String rawInput = textNewConnName.Text.Trim();
            String[] pairs = rawInput.Split('\n');

            foreach (String pair in pairs)
            {
                String keyValuePair = pair.Trim();
                if (keyValuePair == null || keyValuePair == "" || "".Equals(keyValuePair))
                {
                    continue;
                }
                String[] keyValue = keyValuePair.Split('=');
                dictConnNames.Add(keyValue[0].Trim(), keyValue[1].Trim());
            }

            DtsUtils.updateConnNameForAllDtsx(textBoxPath.Text, dictConnNames);

            //Console.WriteLine(dictConnNames.Count);
        }

    }
}
