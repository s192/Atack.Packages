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

#warning 测试数据
            startControl1.RollNodes.Add(new RollNode("安丘"));
            startControl1.RollNodes.Add(new RollNode("滨海"));
            startControl1.RollNodes.Add(new RollNode("奎文"));
            startControl1.RollNodes.Add(new RollNode("寒亭"));
            startControl1.RollNodes.Add(new RollNode("潍城"));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}