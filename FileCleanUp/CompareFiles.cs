using System.Data;

namespace FileCleanUp
{
    public partial class CompareFiles : Form
    {
        public CompareFiles()
        {
            InitializeComponent();
        }

        private void StorageFileNameBrowse_Click(object sender, EventArgs e)
        {
            StorageFileNameText.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StorageFileNameText.Text = openFileDialog.FileName;
            }
        }

        private void DBFilesNameBrowse_Click(object sender, EventArgs e)
        {
            DBFileNameText.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DBFileNameText.Text = openFileDialog.FileName;
            }
        }

        private void CompareAndGenerate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(StorageFileNameText.Text) && !string.IsNullOrWhiteSpace(DBFileNameText.Text))
            {
                var folderPath = Path.GetDirectoryName(StorageFileNameText.Text);
                string[] storageFileNames = GetStringArrayFromFilePath(StorageFileNameText.Text);
                string[] dbFileNames = GetStringArrayFromFilePath(DBFileNameText.Text);

                var hasDBFileSet = new HashSet<string>(dbFileNames);
                var filteredFiles = storageFileNames.Where(item => !hasDBFileSet.Contains(item)).ToArray();

                var groupedFiles = filteredFiles
                        .Select((value, index) => new { value, index })
                        .GroupBy(pair => pair.index / 1)
                        .Select(group => group.Select(pair => pair.value).ToList())
                        .ToList();

                if (folderPath != null && groupedFiles.Count > 0)
                {
                    GenerateFiles(groupedFiles, folderPath);
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

        private void GenerateFiles(List<List<string>> groupedFiles, string folderPath)
        {
            folderPath = Path.Combine(folderPath, "DeleteFiles");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var count = 1;
            foreach (var pair in groupedFiles)
            {
                string fileName = $"tdo_filestodelete_{count}.txt";
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(folderPath, fileName)))
                {
                    foreach (string file in pair)
                    {
                        outputFile.WriteLine(Path.GetFileName(file));
                    }
                    count++;
                }
            }

            MessageBox.Show("Files are saved successfully.");
        }

        private void DBFileNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DBFilesNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReadFiles activeForm = new ReadFiles();
            activeForm.ShowDialog(); 
        }
    }
}
