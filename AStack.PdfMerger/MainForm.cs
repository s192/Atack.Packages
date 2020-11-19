using Atack.WinForm;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AStack.PdfMerger
{
    public partial class MainForm : Form
    {
        private string[] _names;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BrowserFileButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PDF(*.pdf)|*.pdf|所有文件(*.*)|*.*";
            openFileDialog.ShowDialog();
            var fileNames = openFileDialog.FileNames;
            if (fileNames == null || fileNames.Length == 0)
            {
                return;
            }

            this.SourceFileListBox.DataSource = fileNames;
            this.textBox1.Text = fileNames[0];
            this.TargetPathTextBox.Text = fileNames[0];

            _names = fileNames;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == this.TargetPathTextBox.Text)
                return;

            var outMergeFile = this.TargetPathTextBox.Text;
            PdfHelper.MergePdfFiles(_names.OrderBy(s => s).ToList(), outMergeFile);

            MsgBox.ShowInformation("合并完成！");
        }
    }
}
