using GUIDSwitcher.Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace GUIDSwitcher
{
    public partial class GUIDSwitcher : Form
    {
        public GUIDSwitcher()
        {
            InitializeComponent();
        }

        public ConsoleAdapter ConsoleAdapter { get; set; }
        public string FolderPath { get; set; }

        public void SelectFolderButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Выберите папку для обработки .dat файлов";
                folderDialog.ShowNewFolderButton = false;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    FolderPath = folderDialog.SelectedPath;
                    ConsoleAdapter.WriteLine($"Selected folder: {folderDialog.SelectedPath}");
                }
            }
        }

        private void GUIDSwitcher_Load(object sender, EventArgs e)
        {
            ConsoleAdapter = new ConsoleAdapter(this);

            this.SelectFolderButton.ImagePathLocation = "folder.png";
            this.SelectFolderButton.InitParents();

            this.ReplaceGUIDButton.ImagePathLocation = "wrench.png";
            this.ReplaceGUIDButton.InitParents();

            this.SettingsButton.ImagePathLocation = "settings.png";
            this.SettingsButton.InitParents();
        }

        private void ReplaceGUIDButton_Click(object sender, EventArgs e)
        {
            // Найти все .dat файлы, включая подкаталоги
            string[] datFiles = Directory.GetFiles(FolderPath, "*.dat", SearchOption.AllDirectories);

            int count = 0;

            foreach (string file in datFiles)
            {
                // Пропускаем файл MasterBundle.dat
                if (Path.GetFileName(file).Equals("MasterBundle.dat", StringComparison.OrdinalIgnoreCase))
                {
                    ConsoleAdapter.WriteLine($"Skipping file: {file}");
                    continue;
                }

                try
                {
                    // Считываем содержимое файла
                    string[] lines = File.ReadAllLines(file);

                    if (lines.Length > 0 && lines[0].StartsWith("GUID"))
                    {
                        // Генерируем новый GUID
                        string newGUID = $"GUID {Guid.NewGuid():N}";

                        // Заменяем первую строку
                        lines[0] = newGUID;

                        // Записываем изменения обратно в файл
                        File.WriteAllLines(file, lines);

                        ConsoleAdapter.WriteLine($"Updated GUID in file: {Path.GetFileName(file)}");
                        count++;
                    }
                    else
                    {
                        ConsoleAdapter.WriteLine($"File does not contain a GUID line: {file}");
                    }
                }
                catch (Exception ex)
                {
                    ConsoleAdapter.WriteLine($"Error processing file {file}: {ex.Message}");
                }
            }

            ConsoleAdapter.WriteLine($"Processing complete. Total {count} GUIDs generated.");
        }
    }
}
