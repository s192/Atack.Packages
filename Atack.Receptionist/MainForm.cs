using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atack.Receptionist
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowserFileButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            var selectedPath = folderBrowserDialog.SelectedPath;
            if (string.IsNullOrEmpty(selectedPath))
            {
                return;
            }

            this.textBox1.Text = selectedPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dir = this.textBox1.Text;
            var files = Directory.GetFiles(dir, "*", SearchOption.AllDirectories);
            var topFiles = Directory.GetFiles(dir, "*", SearchOption.TopDirectoryOnly);
            files = files.Except(topFiles).ToArray();
            foreach (var file in files)
            {
                var newPath = Path.Combine(dir, Path.GetFileName(file));

                int count = 1;
                while (File.Exists(newPath))
                {
                    newPath += "." + count;
                    count++;
                }

                File.Move(file, newPath);
            }

            var subDirs = Directory.GetDirectories(dir);
            foreach (var subDir in subDirs)
            {
                if (Directory.GetFileSystemEntries(subDir).Length == 0)
                {
                    Directory.Delete(subDir);
                }
            }
        }
    }
}
