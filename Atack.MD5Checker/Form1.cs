using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atack.MD5Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string GetFileMD5(string filepath)
        {
            using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                int bufferSize = 1048576;
                byte[] buff = new byte[bufferSize];
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                md5.Initialize();
                long offset = 0;
                while (offset < fs.Length)
                {
                    long readSize = bufferSize;
                    if (offset + readSize > fs.Length)
                        readSize = fs.Length - offset;
                    fs.Read(buff, 0, Convert.ToInt32(readSize));
                    if (offset + readSize < fs.Length)
                        md5.TransformBlock(buff, 0, Convert.ToInt32(readSize), buff, 0);
                    else
                        md5.TransformFinalBlock(buff, 0, Convert.ToInt32(readSize));
                    offset += bufferSize;
                }
                if (offset >= fs.Length)
                {
                    fs.Close();
                    byte[] result = md5.Hash;
                    md5.Clear();
                    StringBuilder sb = new StringBuilder(32);
                    for (int i = 0; i < result.Length; i++)
                        sb.Append(result[i].ToString("X2"));
                    return sb.ToString();
                }
                else
                {
                    fs.Close();
                    return null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = GetFileMD5(this.textBox1.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = this.textBox2.Text.Trim().ToLower() == this.textBox3.Text.Trim().ToLower();
            MessageBox.Show(res.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            var fileName = openFileDialog.FileName;
            if (fileName != null && File.Exists(fileName))
            {
                this.textBox1.Text = fileName;
            }
        }
    }
}
