using Atack.WinForm;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AStack.PdfMerger
{
    public partial class Form1 : Form
    {
        private string[] _names;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "PDF(*.pdf)|*.pdf|所有文件(*.*)|*.*";
            openFileDialog.ShowDialog();
            var fileNames = openFileDialog.FileNames;
            if (fileNames == null || fileNames.Length == 0)
            {
                return;
            }

            this.listBox1.DataSource = fileNames;
            this.textBox1.Text = fileNames[0];
            this.textBox2.Text = fileNames[0];

            _names = fileNames;
        }

        /// <summary>
        /// 合成pdf文件
        /// </summary>
        /// <param name="fileList">文件名list</param>
        /// <param name="outMergeFile">输出路径</param>
        public static void mergePDFFiles(List<string> fileList, string outMergeFile)
        {
            PdfWriter writer = new PdfWriter(new FileStream(outMergeFile, FileMode.Create));
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(writer));
            var merger = new iText.Kernel.Utils.PdfMerger(pdfDoc);
            for (int i = 0; i < fileList.Count; i++)
            {
                var reader = new PdfReader(fileList[i]);
                PdfDocument document = new PdfDocument(reader);
                int iPageNum = document.GetNumberOfPages();
                merger.Merge(document, 1, iPageNum);
                document.Close();
            }
            pdfDoc.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == this.textBox2.Text)
            {
                return;
            }

            var outMergeFile = this.textBox2.Text;
            mergePDFFiles(_names.OrderBy(s => s).ToList(), outMergeFile);

            MsgBox.ShowInformation("合并完成！");
        }
    }
}
