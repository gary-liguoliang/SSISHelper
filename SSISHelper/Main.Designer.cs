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
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(11, 4);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(324, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.onButtonGenerateFilesClicked);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(12, 62);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(573, 285);
            this.textOutput.TabIndex = 2;
            this.textOutput.Text = "";
            this.textOutput.TextChanged += new System.EventHandler(this.textOutput_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "CreateFolders";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.onButtonPrepareFoldersClicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "UpdatePassword";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.onButtonChangePwClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(500, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "butTest";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.onButtonTestClicked);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "ListAllDtsPkg";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OnButtonListAllDtsxClicked);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.Location = new System.Drawing.Point(160, 34);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(85, 20);
            this.textBoxOldPassword.TabIndex = 7;
            // 
            // OldPw
            // 
            this.OldPw.AutoSize = true;
            this.OldPw.Location = new System.Drawing.Point(116, 37);
            this.OldPw.Name = "OldPw";
            this.OldPw.Size = new System.Drawing.Size(38, 13);
            this.OldPw.TabIndex = 8;
            this.OldPw.Text = "OldPw";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "NewPw";
            // 
            // textBoxNewPw
            // 
            this.textBoxNewPw.Location = new System.Drawing.Point(301, 33);
            this.textBoxNewPw.Name = "textBoxNewPw";
            this.textBoxNewPw.Size = new System.Drawing.Size(77, 20);
            this.textBoxNewPw.TabIndex = 10;
            // 
            // checkBoxOverride
            // 
            this.checkBoxOverride.AutoSize = true;
            this.checkBoxOverride.Location = new System.Drawing.Point(342, 6);
            this.checkBoxOverride.Name = "checkBoxOverride";
            this.checkBoxOverride.Size = new System.Drawing.Size(64, 17);
            this.checkBoxOverride.TabIndex = 11;
            this.checkBoxOverride.Text = "override";
            this.checkBoxOverride.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 398);
            this.Controls.Add(this.checkBoxOverride);
            this.Controls.Add(this.textBoxNewPw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OldPw);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPath);
            this.Name = "Main";
            this.Text = "SSISHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

