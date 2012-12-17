namespace SSISHelper
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.OldPw = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewPw = new System.Windows.Forms.TextBox();
            this.checkBoxOverride = new System.Windows.Forms.CheckBox();
            this.ListAllDtsConns = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textNewConnName = new System.Windows.Forms.RichTextBox();
            this.btnUpdateConnName = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(6, 15);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(324, 20);
            this.textBoxPath.TabIndex = 0;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onButtonGenerateFilesClicked);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(2, 108);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(541, 249);
            this.textOutput.TabIndex = 2;
            this.textOutput.Text = "";
            this.textOutput.TextChanged += new System.EventHandler(this.textOutput_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "CreateFolders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onButtonPrepareFoldersClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "UpdatePassword";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onButtonChangePwClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(408, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "butTest";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onButtonTestClicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "ListAllDtsPkg";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OnButtonListAllDtsxClicked);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(51, 83);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(85, 20);
            this.textBoxOldPassword.TabIndex = 7;
            this.textBoxOldPassword.TextChanged += new System.EventHandler(this.textBoxOldPassword_TextChanged);
            // 
            // OldPw
            // 
            this.OldPw.AutoSize = true;
            this.OldPw.Location = new System.Drawing.Point(7, 86);
            this.OldPw.Name = "OldPw";
            this.OldPw.Size = new System.Drawing.Size(38, 13);
            this.OldPw.TabIndex = 8;
            this.OldPw.Text = "OldPw";
            this.OldPw.Click += new System.EventHandler(this.OldPw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NewPw";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNewPw
            // 
            this.textBoxNewPw.Location = new System.Drawing.Point(192, 82);
            this.textBoxNewPw.Name = "textBoxNewPw";
            this.textBoxNewPw.Size = new System.Drawing.Size(77, 20);
            this.textBoxNewPw.TabIndex = 10;
            this.textBoxNewPw.TextChanged += new System.EventHandler(this.textBoxNewPw_TextChanged);
            // 
            // checkBoxOverride
            // 
            this.checkBoxOverride.AutoSize = true;
            this.checkBoxOverride.Location = new System.Drawing.Point(337, 17);
            this.checkBoxOverride.Name = "checkBoxOverride";
            this.checkBoxOverride.Size = new System.Drawing.Size(64, 17);
            this.checkBoxOverride.TabIndex = 11;
            this.checkBoxOverride.Text = "override";
            this.checkBoxOverride.UseVisualStyleBackColor = true;
            this.checkBoxOverride.CheckedChanged += new System.EventHandler(this.checkBoxOverride_CheckedChanged);
            // 
            // ListAllDtsConns
            // 
            this.ListAllDtsConns.Location = new System.Drawing.Point(109, 43);
            this.ListAllDtsConns.Name = "ListAllDtsConns";
            this.ListAllDtsConns.Size = new System.Drawing.Size(98, 23);
            this.ListAllDtsConns.TabIndex = 12;
            this.ListAllDtsConns.Text = "ListAllDtsConns";
            this.ListAllDtsConns.UseVisualStyleBackColor = true;
            this.ListAllDtsConns.Click += new System.EventHandler(this.ListAllDtsConns_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 454);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdateConnName);
            this.tabPage1.Controls.Add(this.textNewConnName);
            this.tabPage1.Controls.Add(this.ListAllDtsConns);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.textBoxPath);
            this.tabPage1.Controls.Add(this.textOutput);
            this.tabPage1.Controls.Add(this.checkBoxOverride);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBoxNewPw);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.OldPw);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.textBoxOldPassword);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textNewConnName
            // 
            this.textNewConnName.Location = new System.Drawing.Point(560, 108);
            this.textNewConnName.Name = "textNewConnName";
            this.textNewConnName.Size = new System.Drawing.Size(169, 249);
            this.textNewConnName.TabIndex = 13;
            this.textNewConnName.Text = "";
            // 
            // btnUpdateConnName
            // 
            this.btnUpdateConnName.Location = new System.Drawing.Point(632, 362);
            this.btnUpdateConnName.Name = "btnUpdateConnName";
            this.btnUpdateConnName.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateConnName.TabIndex = 14;
            this.btnUpdateConnName.Text = "UpdateConnName";
            this.btnUpdateConnName.UseVisualStyleBackColor = true;
            this.btnUpdateConnName.Click += new System.EventHandler(this.btnUpdateConnName_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "SSISHelper";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.Label OldPw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewPw;
        private System.Windows.Forms.CheckBox checkBoxOverride;
        private System.Windows.Forms.Button ListAllDtsConns;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdateConnName;
        private System.Windows.Forms.RichTextBox textNewConnName;
    }
}

