namespace FileCleanUp
{
    partial class ReadFiles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GetFilesFromDirectory = new Button();
            RootPathText = new TextBox();
            RootPathLabel = new Label();
            Browse = new Button();
            FileSavePathLabel = new Label();
            FileSaveAsPathBrowse = new Button();
            FileSaveAsPathText = new TextBox();
            CompareFile = new Button();
            DeleteFile = new Button();
            SuspendLayout();
            // 
            // GetFilesFromDirectory
            // 
            GetFilesFromDirectory.Location = new Point(336, 154);
            GetFilesFromDirectory.Name = "GetFilesFromDirectory";
            GetFilesFromDirectory.Size = new Size(173, 43);
            GetFilesFromDirectory.TabIndex = 0;
            GetFilesFromDirectory.Text = "GetFilesFromDirectory";
            GetFilesFromDirectory.UseVisualStyleBackColor = true;
            GetFilesFromDirectory.Click += GetFilesFromDirectory_Click;
            // 
            // RootPathText
            // 
            RootPathText.Location = new Point(166, 34);
            RootPathText.Name = "RootPathText";
            RootPathText.Size = new Size(485, 27);
            RootPathText.TabIndex = 1;
            // 
            // RootPathLabel
            // 
            RootPathLabel.AutoSize = true;
            RootPathLabel.Location = new Point(32, 37);
            RootPathLabel.Name = "RootPathLabel";
            RootPathLabel.Size = new Size(119, 20);
            RootPathLabel.TabIndex = 2;
            RootPathLabel.Text = "Root Folder Path";
            // 
            // Browse
            // 
            Browse.Location = new Point(668, 33);
            Browse.Name = "Browse";
            Browse.Size = new Size(94, 29);
            Browse.TabIndex = 3;
            Browse.Text = "Browse";
            Browse.UseVisualStyleBackColor = true;
            Browse.Click += Browse_Click;
            // 
            // FileSavePathLabel
            // 
            FileSavePathLabel.AutoSize = true;
            FileSavePathLabel.Location = new Point(32, 93);
            FileSavePathLabel.Name = "FileSavePathLabel";
            FileSavePathLabel.Size = new Size(119, 20);
            FileSavePathLabel.TabIndex = 4;
            FileSavePathLabel.Text = "File Save As Path";
            // 
            // FileSaveAsPathBrowse
            // 
            FileSaveAsPathBrowse.Location = new Point(668, 89);
            FileSaveAsPathBrowse.Name = "FileSaveAsPathBrowse";
            FileSaveAsPathBrowse.Size = new Size(94, 29);
            FileSaveAsPathBrowse.TabIndex = 6;
            FileSaveAsPathBrowse.Text = "Browse";
            FileSaveAsPathBrowse.UseVisualStyleBackColor = true;
            FileSaveAsPathBrowse.Click += FileSaveAsPathBrowse_Click;
            // 
            // FileSaveAsPathText
            // 
            FileSaveAsPathText.Location = new Point(166, 90);
            FileSaveAsPathText.Name = "FileSaveAsPathText";
            FileSaveAsPathText.Size = new Size(485, 27);
            FileSaveAsPathText.TabIndex = 5;
            // 
            // CompareFile
            // 
            CompareFile.Location = new Point(271, 268);
            CompareFile.Name = "CompareFile";
            CompareFile.Size = new Size(131, 43);
            CompareFile.TabIndex = 7;
            CompareFile.Text = "Compare File";
            CompareFile.UseVisualStyleBackColor = true;
            CompareFile.Click += CompareFile_Click;
            // 
            // DeleteFile
            // 
            DeleteFile.Location = new Point(424, 268);
            DeleteFile.Name = "DeleteFile";
            DeleteFile.Size = new Size(126, 43);
            DeleteFile.TabIndex = 8;
            DeleteFile.Text = "Delete File";
            DeleteFile.UseVisualStyleBackColor = true;
            DeleteFile.Click += DeleteFile_Click;
            // 
            // ReadFiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteFile);
            Controls.Add(CompareFile);
            Controls.Add(FileSaveAsPathBrowse);
            Controls.Add(FileSaveAsPathText);
            Controls.Add(FileSavePathLabel);
            Controls.Add(Browse);
            Controls.Add(RootPathLabel);
            Controls.Add(RootPathText);
            Controls.Add(GetFilesFromDirectory);
            MaximizeBox = false;
            Name = "ReadFiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Read files and save";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetFilesFromDirectory;
        private TextBox RootPathText;
        private Label RootPathLabel;
        private Button Browse;
        private Label FileSavePathLabel;
        private Button FileSaveAsPathBrowse;
        private TextBox FileSaveAsPathText;
        private Button CompareFile;
        private Button DeleteFile;
    }
}