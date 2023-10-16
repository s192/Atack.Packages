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

#warning ��������
            var rollNode = new RollNode("root");
            var node1 = new RollNode("����");
            node1.Children.Add(new RollNode("����1"));
            node1.Children.Add(new RollNode("����2"));
            node1.Children.Add(new RollNode("����3"));
            rollNode.Children.Add(node1);

            var node2 = new RollNode("��ͤ");
            node2.Children.Add(new RollNode("��ͤ1"));
            node2.Children.Add(new RollNode("��ͤ2"));
            node2.Children.Add(new RollNode("��ͤ3"));
            rollNode.Children.Add(node2);

            var node3 = new RollNode("Ϋ��");
            node3.Children.Add(new RollNode("Ϋ��1"));
            node3.Children.Add(new RollNode("Ϋ��2"));
            node3.Children.Add(new RollNode("Ϋ��3"));
            rollNode.Children.Add(node3);

            startControl1.RootNode = rollNode;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}