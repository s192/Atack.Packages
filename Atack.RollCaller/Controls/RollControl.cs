using Atack.RollCaller.Model;

namespace Atack.RollCaller.Controls
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

        public RollNode RollNode { get; internal set; }

        private void BactButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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
            button.Text = RollNode.Nodes[0].Text;
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
            var random = new Random();
            var index = random.Next(RollNode.Nodes.Count);
            var rollNode = RollNode.Nodes[index] as RollNode;

            _buttons[0].Text = rollNode.Text;
            _buttons[0].Tag = rollNode;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            RollTimer.Stop();
            _buttons[0].Click += NodeButton_Click;
        }

        private void NodeButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button == false)
                return;

            var button = (Button)sender;
            var node = (RollNode)button.Tag;
            var newRollControl = RollControl.Create(node, panel1);
            if (newRollControl == null)
                node.ShowTag();

        }

        public static RollControl? Create(RollNode rollNode, Panel panel)
        {
            if (rollNode.Nodes.Count == 0)
                return null;

            var rollControl = new RollControl();
            rollControl.RollNode = rollNode;

            panel.Controls.Add(rollControl);

            rollControl.Dock = DockStyle.Fill;
            rollControl.BringToFront();

            return rollControl;
        }
    }
}
