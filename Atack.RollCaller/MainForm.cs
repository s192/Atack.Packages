using Atack.RollCaller.Model;

namespace Atack.RollCaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ExitButton.BringToFront();
            startControl1.Dock = DockStyle.Fill;

            startControl1.RollNodes = new RollNodeCollection();

#warning ��������
            startControl1.RollNodes.Add(new RollNode("����"));
            startControl1.RollNodes.Add(new RollNode("����"));
            startControl1.RollNodes.Add(new RollNode("����"));
            startControl1.RollNodes.Add(new RollNode("��ͤ"));
            startControl1.RollNodes.Add(new RollNode("Ϋ��"));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}