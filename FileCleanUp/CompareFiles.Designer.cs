namespace FileCleanUp
{
    partial class CompareFiles
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
            DBFilesNameBrowse = new Button();
            DBFileNameText = new TextBox();
            DBFilesNameLabel = new Label();
            StorageFileNameBrowse = new Button();
            StorageFileNamePathLabel = new Label();
            StorageFileNameText = new TextBox();
            CompareAndGenerate = new Button();
            Home = new Button();
            SuspendLayout();
            // 
            // DBFilesNameBrowse
            // 
            DBFilesNameBrowse.Location = new Point(661, 85);
            DBFilesNameBrowse.Name = "DBFilesNameBrowse";
            DBFilesNameBrowse.Size = new Size(94, 29);
            DBFilesNameBrowse.TabIndex = 13;
            DBFilesNameBrowse.Text = "Browse";
            DBFilesNameBrowse.UseVisualStyleBackColor = true;
            DBFilesNameBrowse.Click += DBFilesNameBrowse_Click;
            // 
            // DBFileNameText
            // 
            DBFileNameText.Location = new Point(201, 86);
            DBFileNameText.Name = "DBFileNameText";
            DBFileNameText.Size = new Size(443, 27);
            DBFileNameText.TabIndex = 12;
            DBFileNameText.TextChanged += DBFileNameText_TextChanged;
            // 
            // DBFilesNameLabel
            // 
            DBFilesNameLabel.AutoSize = true;
            DBFilesNameLabel.Location = new Point(25, 89);
            DBFilesNameLabel.Name = "DBFilesNameLabel";
            DBFilesNameLabel.Size = new Size(132, 20);
            DBFilesNameLabel.TabIndex = 11;
            DBFilesNameLabel.Text = "DB File Name Path";
            DBFilesNameLabel.Click += DBFilesNameLabel_Click;
            // 
            // StorageFileNameBrowse
            // 
            StorageFileNameBrowse.Location = new Point(661, 29);
            StorageFileNameBrowse.Name = "StorageFileNameBrowse";
            StorageFileNameBrowse.Size = new Size(94, 29);
            StorageFileNameBrowse.TabIndex = 10;
            StorageFileNameBrowse.Text = "Browse";
            StorageFileNameBrowse.UseVisualStyleBackColor = true;
            StorageFileNameBrowse.Click += StorageFileNameBrowse_Click;
            // 
            // StorageFileNamePathLabel
            // 
            StorageFileNamePathLabel.AutoSize = true;
            StorageFileNamePathLabel.Location = new Point(25, 33);
            StorageFileNamePathLabel.Name = "StorageFileNamePathLabel";
            StorageFileNamePathLabel.Size = new Size(164, 20);
            StorageFileNamePathLabel.TabIndex = 9;
            StorageFileNamePathLabel.Text = "Storage File Name Path";
            // 
            // StorageFileNameText
            // 
            StorageFileNameText.Location = new Point(201, 30);
            StorageFileNameText.Name = "StorageFileNameText";
            StorageFileNameText.Size = new Size(443, 27);
            StorageFileNameText.TabIndex = 8;
            // 
            // CompareAndGenerate
            // 
            CompareAndGenerate.Location = new Point(413, 152);
            CompareAndGenerate.Name = "CompareAndGenerate";
            CompareAndGenerate.Size = new Size(231, 43);
            CompareAndGenerate.TabIndex = 7;
            CompareAndGenerate.Text = "Compare and Generate file";
            CompareAndGenerate.UseVisualStyleBackColor = true;
            CompareAndGenerate.Click += CompareAndGenerate_Click;
            // 
            // Home
            // 
            Home.Location = new Point(201, 152);
            Home.Name = "Home";
            Home.Size = new Size(173, 43);
            Home.TabIndex = 22;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // CompareFiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(Home);
            Controls.Add(DBFilesNameBrowse);
            Controls.Add(DBFileNameText);
            Controls.Add(DBFilesNameLabel);
            Controls.Add(StorageFileNameBrowse);
            Controls.Add(StorageFileNamePathLabel);
            Controls.Add(StorageFileNameText);
            Controls.Add(CompareAndGenerate);
            MaximizeBox = false;
            Name = "CompareFiles";
            Text = "Compare Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DBFilesNameBrowse;
        private TextBox DBFileNameText;
        private Label DBFilesNameLabel;
        private Button StorageFileNameBrowse;
        private Label StorageFileNamePathLabel;
        private TextBox StorageFileNameText;
        private Button CompareAndGenerate;
        private Button Home;
    }
}