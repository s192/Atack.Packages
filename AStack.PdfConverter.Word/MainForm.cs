using Atack.WinForm;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AStack.PdfConverter.Word
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
            openFileDialog.Filter = "Word(*.doc;*.docx)|*.doc;*.docx|所有文件(*.*)|*.*";
            openFileDialog.ShowDialog();
            var fileNames = openFileDialog.FileNames;
            if (fileNames == null || fileNames.Length == 0)
            {
                return;
            }

            this.SourceFileListBox.DataSource = fileNames;
            this.textBox1.Text = fileNames[0];

            _names = fileNames;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            WordHelper.Convert2PdfFiles(_names.OrderBy(s => s).ToList());

            MsgBox.ShowInformation("转换完成！");
        }
    }
}
