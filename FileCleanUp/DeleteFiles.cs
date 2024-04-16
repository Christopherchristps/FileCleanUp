using System.Data;

namespace FileCleanUp
{
    public partial class DeleteFiles : Form
    {
        public DeleteFiles()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            RootPathText.Text = "";
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                RootPathText.Text = directchoosedlg.SelectedPath;
            }
        }

        private void DeleteFileBrowse_Click(object sender, EventArgs e)
        {
            DeleteFilePathText.Text = "";
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                DeleteFilePathText.Text = directchoosedlg.SelectedPath;
            }
        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DeleteFilePathText.Text) && !string.IsNullOrWhiteSpace(RootPathText.Text))
            {
                var rootPath = Path.Combine(RootPathText.Text);
                var deleteFolderPath = Path.Combine(DeleteFilePathText.Text);
                if (deleteFolderPath != null && rootPath != null)
                {
                    string[] files = Directory.GetFiles(deleteFolderPath, "*.txt");
                    foreach (string file in files)
                    {
                        string[] fileNames = GetStringArrayFromFilePath(file);
                        foreach (string fileName in fileNames)
                        {
                            string filePath = Path.Combine(rootPath, $"{fileName[0]}\\{fileName[1]}\\{fileName}");
                            if (File.Exists(filePath))
                            {
                                File.Delete(filePath);
                            }
                        }

                        string deleteFile = Path.Combine(deleteFolderPath, file);
                        if (File.Exists(deleteFile))
                        {
                            File.Delete(deleteFile);
                        }
                    }
                }
            }
        }

        private string[] GetStringArrayFromFilePath(string filepath)
        {
            try
            {
                string[] fileNames = File.ReadAllLines(Path.Combine(filepath));
                return fileNames.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error reading the file: {ex.Message}");
                return new string[0];
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadFiles activeForm = new ReadFiles();
            activeForm.ShowDialog();
        }
    }
}
