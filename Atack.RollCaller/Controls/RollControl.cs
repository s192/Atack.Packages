using Atack.RollCaller.Model;
using Atack.RollCaller.Utils;

namespace Atack.RollCaller.Controls
{
    public partial class RollControl : UserControl
    {
        public RollControl()
        {
            InitializeComponent();
        }

        public RollNode ParentNode { get; internal set; }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RollTimer_Tick(object sender, EventArgs e)
        {
            var random = new Random();
            var index = random.Next(ParentNode.Nodes.Count);
            var rollNode = (RollNode)ParentNode.Nodes[index];

            NodeButton.Text = rollNode.Text;
            NodeButton.Tag = rollNode;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            switch (StopButton.Text)
            {
                case "开始":
                    //是否全部已在已抽名单里，若是，则提示本组已全部抽完，不进行抽取
                    var isAllDone = true;
                    foreach (RollNode node in ParentNode.Nodes)
                    {
                        if (RollConstant.CalledNodeList.Contains(node) == false)
                        {
                            isAllDone = false;
                            break;
                        }
                    }
                    if (isAllDone)
                    {
                        MsgBox.ShowInformation("本组已全部抽完！", this);
                        return;
                    }
                    //开始滚动
                    NodeButton.Click -= NodeButton_Click;
                    RollTimer.Start();
                    StopButton.Text = "停止";
                    break;
                case "停止":
                    //停止滚动
                    RollTimer.Stop();

#warning 排除坊子的逻辑，共享时须删除
                    RollNode rollNode;
                    do
                    {
                        var random = new Random();
                        var index = random.Next(ParentNode.Nodes.Count);
                        rollNode = (RollNode)ParentNode.Nodes[index];

                        NodeButton.Text = rollNode.Text;
                        NodeButton.Tag = rollNode;
                    } while (rollNode.Text == "坊子" || RollConstant.CalledNodeList.Contains(rollNode));
                    //已抽过的叶子节点不再抽
                    if (rollNode.Nodes.Count == 0)
                        RollConstant.CalledNodeList.Add(rollNode);

                    NodeButton.Click += NodeButton_Click;
                    StopButton.Text = "开始";
                    break;
                default:
                    break;
            }
        }

        private void NodeButton_Click(object? sender, EventArgs e)
        {
            if (sender != NodeButton)
                return;

            var node = (RollNode)NodeButton.Tag;
            var newRollControl = RollControl.Create(node, panel1);
            if (newRollControl == null)
                node.ShowTag();

        }

        public static RollControl? Create(RollNode rollNode, Panel panel)
        {
            if (rollNode.Nodes.Count == 0)
                return null;

            var rollControl = new RollControl();
            rollControl.ParentNode = rollNode;

            panel.Controls.Add(rollControl);

            rollControl.Dock = DockStyle.Fill;
            rollControl.BringToFront();
            rollControl.Focus();

            return rollControl;
        }

        private void RollControl_Load(object sender, EventArgs e)
        {
            var x = panel1.Width / 2 - 750;
            var y = panel1.Height / 2 - 250;
            NodeButton.Location = new Point(x, y);
            NodeButton.Size = new Size(1500, 500);
            NodeButton.Text = ParentNode.Nodes[0].Text;
            NodeButton.Font = new Font("楷体", 226.25F, FontStyle.Bold, GraphicsUnit.Point);

            RollTimer.Enabled = true;
            RollTimer.Interval = 10;
            RollTimer.Start();
        }
    }
}
