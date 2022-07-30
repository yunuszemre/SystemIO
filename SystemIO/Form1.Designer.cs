namespace SystemIO
{
    partial class Form1
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
            this.btnDriverInfo = new System.Windows.Forms.Button();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnGetDirectories = new System.Windows.Forms.Button();
            this.btnGetFiles = new System.Windows.Forms.Button();
            this.btnMoveDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDriverInfo
            // 
            this.btnDriverInfo.Location = new System.Drawing.Point(12, 12);
            this.btnDriverInfo.Name = "btnDriverInfo";
            this.btnDriverInfo.Size = new System.Drawing.Size(112, 53);
            this.btnDriverInfo.TabIndex = 0;
            this.btnDriverInfo.Text = "DriverInfo";
            this.btnDriverInfo.UseVisualStyleBackColor = true;
            this.btnDriverInfo.Click += new System.EventHandler(this.btnDriverInfo_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(130, 12);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(112, 53);
            this.btnDirectory.TabIndex = 1;
            this.btnDirectory.Text = "Directory";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(12, 71);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(112, 53);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnGetDirectories
            // 
            this.btnGetDirectories.Location = new System.Drawing.Point(130, 71);
            this.btnGetDirectories.Name = "btnGetDirectories";
            this.btnGetDirectories.Size = new System.Drawing.Size(112, 53);
            this.btnGetDirectories.TabIndex = 3;
            this.btnGetDirectories.Text = "GetDirectories";
            this.btnGetDirectories.UseVisualStyleBackColor = true;
            this.btnGetDirectories.Click += new System.EventHandler(this.btnGetDirectories_Click);
            // 
            // btnGetFiles
            // 
            this.btnGetFiles.Location = new System.Drawing.Point(12, 130);
            this.btnGetFiles.Name = "btnGetFiles";
            this.btnGetFiles.Size = new System.Drawing.Size(112, 53);
            this.btnGetFiles.TabIndex = 4;
            this.btnGetFiles.Text = "Get File";
            this.btnGetFiles.UseVisualStyleBackColor = true;
            this.btnGetFiles.Click += new System.EventHandler(this.btnGetFiles_Click);
            // 
            // btnMoveDir
            // 
            this.btnMoveDir.Location = new System.Drawing.Point(130, 130);
            this.btnMoveDir.Name = "btnMoveDir";
            this.btnMoveDir.Size = new System.Drawing.Size(112, 53);
            this.btnMoveDir.TabIndex = 5;
            this.btnMoveDir.Text = "Move Directory";
            this.btnMoveDir.UseVisualStyleBackColor = true;
            this.btnMoveDir.Click += new System.EventHandler(this.btnMoveDir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(262, 205);
            this.Controls.Add(this.btnMoveDir);
            this.Controls.Add(this.btnGetFiles);
            this.Controls.Add(this.btnGetDirectories);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.btnDriverInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDriverInfo;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnGetDirectories;
        private System.Windows.Forms.Button btnGetFiles;
        private System.Windows.Forms.Button btnMoveDir;
    }
}

