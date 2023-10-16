namespace Atack.RollCaller.Model
{
    public class RollNode : TreeNode
    {
        public RollNode(string name) : base(name)
        {
        }

        public RollNode(string name, string tag) : base(name)
        {
            Tag = tag;
        }

        public void ShowTag(IWin32Window owner = null)
        {
            var msg = this.Tag?.ToString();
            if (string.IsNullOrEmpty(msg))
                msg = "无详情！";

            MessageBox.Show(owner, this.Tag?.ToString() ?? string.Empty, "详情", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
