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

#warning 测试数据
            var rollNode = new RollNode("root");
            var node1 = new RollNode("奎文");
            node1.Children.Add(new RollNode("奎文1"));
            node1.Children.Add(new RollNode("奎文2"));
            node1.Children.Add(new RollNode("奎文3"));
            rollNode.Children.Add(node1);

            var node2 = new RollNode("寒亭");
            node2.Children.Add(new RollNode("寒亭1"));
            node2.Children.Add(new RollNode("寒亭2"));
            node2.Children.Add(new RollNode("寒亭3"));
            rollNode.Children.Add(node2);

            var node3 = new RollNode("潍城");
            node3.Children.Add(new RollNode("潍城1"));
            node3.Children.Add(new RollNode("潍城2"));
            node3.Children.Add(new RollNode("潍城3"));
            rollNode.Children.Add(node3);

            startControl1.RootNode = rollNode;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}