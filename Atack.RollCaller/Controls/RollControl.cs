using Atack.RollCaller.Model;
using Atack.RollCaller.Properties;
using Atack.RollCaller.Utils;
using System.Drawing.Drawing2D;
using System.Media;

namespace Atack.RollCaller.Controls
{
    public partial class RollControl : UserControl
    {
        private SoundPlayer _soundPlayer;

        public RollControl()
        {
            InitializeComponent();

            RollTimer.Interval = 10;
            _soundPlayer = new SoundPlayer();
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
            SoundPlayer soundPlayer;
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
                    StartRolling();
                    break;
                case "停止":
                    StopRolling();
                    RollNode rollNode;
                    do
                    {
                        var random = new Random();
                        var index = random.Next(ParentNode.Nodes.Count);
                        rollNode = (RollNode)ParentNode.Nodes[index];

                        NodeButton.Text = rollNode.Text;
                        NodeButton.Tag = rollNode;
                    } while (RollConstant.CalledNodeList.Contains(rollNode));
                    //已抽过的叶子节点不再抽
                    if (rollNode.Nodes.Count == 0)
                        RollConstant.CalledNodeList.Add(rollNode);

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

            StartRolling();
        }

        #region 绘制阴影

        private void NodeButton_Paint(object sender, PaintEventArgs e)
        {
            var text = NodeButton.Text;
            if (text == null || text.Length < 1)
                return;

            var graphics = e.Graphics;
            var font = NodeButton.Font;
            RectangleF rectangleF = e.ClipRectangle;
            //计算垂直偏移
            float dy = (e.ClipRectangle.Height - graphics.MeasureString(text, font).Height) / 2.0f + 50;
            //计算水平偏移
            float dx = (e.ClipRectangle.Width - graphics.MeasureString(text, font).Width) / 2.0f + 50;
            //将文字显示的工作区偏移dx,dy，实现文字居中、水平居中、垂直居中
            rectangleF.Offset(dx, dy);
            float dpi = graphics.DpiY;
            //阴影颜色
            var solidBrush = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            using (GraphicsPath offPath = GetStringPath(text, dpi, rectangleF, font))
            {
                graphics.FillPath(solidBrush, offPath);
                solidBrush.Dispose();
            }
        }

        private GraphicsPath GetStringPath(string s, float dpi, RectangleF rect, Font font)
        {
            GraphicsPath path = new GraphicsPath();
            //计算文字高度
            float emSize = dpi * font.SizeInPoints / 72;
            //向path中添加字符串及相应信息 
            //文本布局信息 详细功能请查看注释 这里可有可无
            path.AddString(s, font.FontFamily, (int)font.Style, emSize, rect, StringFormat.GenericTypographic);
            return path;
        }

        #endregion

        private void StartRolling()
        {
            NodeButton.Click -= NodeButton_Click;
            RollTimer.Start();
            StopButton.Text = "停止";
            _soundPlayer.Stream = Resources.rolling;
            _soundPlayer.PlayLooping();
        }

        private void StopRolling()
        {
            NodeButton.Click += NodeButton_Click;
            _soundPlayer.Stream = Resources.called;
            _soundPlayer.Play();
            //停止滚动
            RollTimer.Stop();
            StopButton.Text = "开始";
        }

        private void RollControl_Leave(object sender, EventArgs e)
        {
            _soundPlayer.Stop();
        }
    }
}
