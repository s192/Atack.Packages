using Atack.RollCaller.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Atack.RollCaller
{
    public partial class RollControl : UserControl
    {
        private bool _isFrist;
        private List<Button> _buttons;

        public RollControl()
        {
            InitializeComponent();

            _isFrist = true;
            _buttons = new List<Button>();
        }

        public RollNodeCollection RollNodes { get; internal set; }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if (_isFrist == false)
                return;
            var x = panel1.Width / 2 - 400;
            var y = panel1.Height / 2 - 200;
            var button = new Button();
            panel1.Controls.Add(button);
            _buttons.Add(button);

            button.Location = new Point(x, y);
            button.Name = "button1";
            button.Size = new Size(800, 400);
            button.TabIndex = 0;
            button.Text = RollNodes[0].Name;
            button.Font = new Font("Microsoft YaHei UI", 126.25F, FontStyle.Bold, GraphicsUnit.Point);
            button.UseVisualStyleBackColor = true;

            button.FlatStyle = FlatStyle.Flat;
            //button.ForeColor = Color.Transparent;
            button.BackColor = Color.Transparent;
            button.FlatAppearance.BorderSize = 0;

            RollTimer.Enabled = true;
            RollTimer.Interval = 10; //执行间隔时间,单位为毫秒; 这里实际间隔为10分钟  
            RollTimer.Start();

            _isFrist = false;
        }

        private void RollTimer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = 0;
            RollNode rollNode;

            index = random.Next(RollNodes.Count);
            rollNode = RollNodes[index];

            _buttons[0].Text = rollNode.Name;

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            RollTimer.Stop();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
