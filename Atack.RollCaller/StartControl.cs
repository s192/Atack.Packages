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

        public RollNode RootNode { get; internal set; }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var rollControl = RollControl.Create(RootNode);
            panel1.Controls.Add(rollControl);
            rollControl.BringToFront();
        }
    }
}
