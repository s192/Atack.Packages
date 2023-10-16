using Atack.RollCaller.Model;
using Atack.RollCaller.Utils;

namespace Atack.RollCaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ExitButton.BringToFront();
            startControl1.Dock = DockStyle.Fill;

            startControl1.RootNode = RollConstant.Root;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportControl.GetInstance(this).Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ImportControl.GetInstance(this).Show();
        }
    }
}