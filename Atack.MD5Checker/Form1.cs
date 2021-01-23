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

        private static string GetMD5(string filepath)
        {
            return ComputeHash(new MD5CryptoServiceProvider(), filepath);
        }

        private static string GetSHA1(string filepath)
        {
            return ComputeHash(new SHA1CryptoServiceProvider(), filepath);
        }

        private static string ComputeHash(HashAlgorithm hashAlgorithm, string filepath)
        {
            using (var file = new FileStream(filepath, FileMode.Open))
            {
                byte[] retval = hashAlgorithm.ComputeHash(file);
                file.Close();

                var sc = new StringBuilder();
                for (int i = 0; i < retval.Length; i++)
                {
                    sc.Append(retval[i].ToString("x2"));
                }
                return sc.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = GetMD5(this.textBox1.Text.Trim());
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = GetSHA1(this.textBox1.Text.Trim());
        }
    }
}
