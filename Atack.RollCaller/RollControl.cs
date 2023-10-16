using Atack.RollCaller.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atack.RollCaller
{
    public partial class RollControl : UserControl
    {
        public RollControl()
        {
            InitializeComponent();
        }

        public RollNodeCollection RollNodes { get; internal set; }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            var x = panel1.Width / 2 - 400;
            var y = panel1.Height / 2 - 200;
            var button = new Button();
            panel1.Controls.Add(button);
            button.Location = new Point(x, y);
            button.Name = "button1";
            button.Size = new Size(800, 400);
            button.TabIndex = 0;
            button.Text = RollNodes[0].Name;
            button.Font= new Font("Microsoft YaHei UI", 126.25F, FontStyle.Bold, GraphicsUnit.Point);
            button.UseVisualStyleBackColor = true;

            button.FlatStyle = FlatStyle.Flat;
            //button.ForeColor = Color.Transparent;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0;

        }
    }
}
