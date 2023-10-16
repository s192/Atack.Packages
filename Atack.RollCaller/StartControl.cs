using Atack.RollCaller.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atack.RollCaller
{
    public partial class StartControl : UserControl
    {
        public StartControl()
        {
            InitializeComponent();
        }

        public RollNodeCollection RollNodes { get; internal set; }

        private void StartButton_Click(object sender, EventArgs e)
        {
            RollControl rollControl = new RollControl();

            rollControl.RollNodes = RollNodes;

            panel1.Controls.Add(rollControl);

            //rollControl.Location = new Point(0, 0);
            rollControl.MinimumSize = new Size(800, 450);
            //rollControl.Name = "rollControl1";
            //rollControl.Size = new Size(800, 450);
            //rollControl.TabIndex = 7;

            rollControl.Dock = DockStyle.Fill;
            rollControl.BringToFront();
            rollControl.Show();
        }
    }
}
