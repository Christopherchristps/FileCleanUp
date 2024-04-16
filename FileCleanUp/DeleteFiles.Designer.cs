namespace FileCleanUp
{
    partial class DeleteFiles
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
            DeleteFileBrowse = new Button();
            DeleteFilePathText = new TextBox();
            DeleteFilePathLabel = new Label();
            DeleteFile = new Button();
            Browse = new Button();
            RootPathLabel = new Label();
            RootPathText = new TextBox();
            Home = new Button();
            SuspendLayout();
            // 
            // DeleteFileBrowse
            // 
            DeleteFileBrowse.Location = new Point(664, 85);
            DeleteFileBrowse.Name = "DeleteFileBrowse";
            DeleteFileBrowse.Size = new Size(94, 29);
            DeleteFileBrowse.TabIndex = 17;
            DeleteFileBrowse.Text = "Browse";
            DeleteFileBrowse.UseVisualStyleBackColor = true;
            DeleteFileBrowse.Click += DeleteFileBrowse_Click;
            // 
            // DeleteFilePathText
            // 
            DeleteFilePathText.Location = new Point(162, 86);
            DeleteFilePathText.Name = "DeleteFilePathText";
            DeleteFilePathText.Size = new Size(485, 27);
            DeleteFilePathText.TabIndex = 16;
            // 
            // DeleteFilePathLabel
            // 
            DeleteFilePathLabel.AutoSize = true;
            DeleteFilePathLabel.Location = new Point(28, 89);
            DeleteFilePathLabel.Name = "DeleteFilePathLabel";
            DeleteFilePathLabel.Size = new Size(112, 20);
            DeleteFilePathLabel.TabIndex = 15;
            DeleteFilePathLabel.Text = "Delete File Path";
            // 
            // DeleteFile
            // 
            DeleteFile.Location = new Point(398, 155);
            DeleteFile.Name = "DeleteFile";
            DeleteFile.Size = new Size(189, 43);
            DeleteFile.TabIndex = 14;
            DeleteFile.Text = "Delete Files";
            DeleteFile.UseVisualStyleBackColor = true;
            DeleteFile.Click += DeleteFile_Click;
            // 
            // Browse
            // 
            Browse.Location = new Point(664, 26);
            Browse.Name = "Browse";
            Browse.Size = new Size(94, 29);
            Browse.TabIndex = 20;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // RootPathLabel
            // 
            RootPathLabel.AutoSize = true;
            RootPathLabel.Location = new Point(28, 30);
            RootPathLabel.Name = "RootPathLabel";
            RootPathLabel.Size = new Size(119, 20);
            RootPathLabel.TabIndex = 19;
            RootPathLabel.Text = "Root Folder Path";
            // 
            // RootPathText
            // 
            RootPathText.Location = new Point(162, 27);
            RootPathText.Name = "RootPathText";
            RootPathText.Size = new Size(485, 27);
            RootPathText.TabIndex = 18;
            // 
            // Home
            // 
            Home.Location = new Point(182, 155);
            Home.Name = "Home";
            Home.Size = new Size(173, 43);
            Home.TabIndex = 21;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // DeleteFiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(Home);
            Controls.Add(Browse);
            Controls.Add(RootPathLabel);
            Controls.Add(RootPathText);
            Controls.Add(DeleteFileBrowse);
            Controls.Add(DeleteFilePathText);
            Controls.Add(DeleteFilePathLabel);
            Controls.Add(DeleteFile);
            MaximizeBox = false;
            Name = "DeleteFiles";
            Text = "Delete Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DeleteFileBrowse;
        private TextBox DeleteFilePathText;
        private Label DeleteFilePathLabel;
        private Button DeleteFile;
        private Button Browse;
        private Label RootPathLabel;
        private TextBox RootPathText;
        private Button Home;
    }
}