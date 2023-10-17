using Atack.RollCaller.Model;
using Atack.RollCaller.Utils;

namespace Atack.RollCaller.Controls
{
    public partial class StartControl : UserControl
    {
        public StartControl()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (RollConstant.Root.Nodes.Count == 0)
            {
                MsgBox.ShowInformation("名单为空，请先导入！", this);
                ImportControl.GetInstance().Show();
                return;
            }

            RollControl.Create(RollConstant.Root, panel1);
        }
    }
}
