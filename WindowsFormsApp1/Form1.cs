using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var names = new string[]{"安泊莱",
"白梓廷",
"包祥桐",
"毕欢悦",
"毕研松",
"曹衍铭",
"董进宝",
"董元睿",
"杜承健",
"樊家豪",
"洪康   ",
"蒋伟祺",
"李金振",
"李靖文",
"李文博",
"梁楚慧",
"刘冠辰",
"刘婧涵",
"刘依萍",
"王子豪",
"韩承霖" };
            var text = textBox1.Text.Trim();
            var res = new StringBuilder();
            foreach (var name in names)
            {
                if (text.Contains(name) == false)
                {
                    res.Append(name);
                    res.Append('\n');
                }
            }

            MessageBox.Show(res.ToString());
        }
    }
}
