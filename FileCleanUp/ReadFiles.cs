using System.Data.Common;
using System.Net;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace FileCleanUp
{
    public partial class ReadFiles : Form
    {
        public ReadFiles()
        {
            InitializeComponent();
        }

        private void GetFilesFromDirectory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(RootPathText.Text) && !string.IsNullOrWhiteSpace(FileSaveAsPathText.Text))
            {
                var folderPath = Path.Combine(RootPathText.Text);
                if (folderPath != null)
                {
                    string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
                    string fileName = "tdofsfile.txt";
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(FileSaveAsPathText.Text, fileName)))
                    {
                        foreach (string file in files)
                        {
                            outputFile.WriteLine(Path.GetFileName(file));
                        }
                    }

                    MessageBox.Show($"File {fileName} saved successfully.");
                }
            }
            else
            {
                MessageBox.Show("Please select root folder path or file save as path");
            }
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
        private void FileSaveBrowse_Click(object sender, EventArgs e)
        {
            RootPathText.Text = "";
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                RootPathText.Text = directchoosedlg.SelectedPath;
            }
        }

        private void FileSaveAsPathBrowse_Click(object sender, EventArgs e)
        {
            FileSaveAsPathText.Text = "";
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                FileSaveAsPathText.Text = directchoosedlg.SelectedPath;
            }
        }

        private void CompareFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompareFiles activeForm = new CompareFiles();
            activeForm.ShowDialog();
        }

        private void DeleteFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteFiles activeForm = new DeleteFiles();
            activeForm.ShowDialog(); 
        }
    }
}