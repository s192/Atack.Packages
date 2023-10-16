using Atack.RollCaller.Model;

namespace Atack.RollCaller.Controls
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
            RollControl.Create(RootNode, panel1);
        }
    }
}
