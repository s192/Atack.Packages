using Atack.RollCaller.Model;
using Atack.RollCaller.Utils;
using System.Data;
using System.Text;

namespace Atack.RollCaller.Controls
{
    public partial class ImportControl : UserControl
    {
        private static ImportControl? _instance;

        public ImportControl()
        {
            InitializeComponent();

            //初始化根节点
            RollNodesTreeView.Nodes.Add(RollConstant.Root);
        }

        private void BactButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public static ImportControl GetInstance(Control control)
        {
            if (_instance != null)
                return _instance;

            _instance = new ImportControl();
            control.Controls.Add(_instance);
            _instance.Dock = DockStyle.Fill;
            _instance.BringToFront();
            return _instance;
        }

        private void RollNodesTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)//判断你点的是不是右键           
                return;

            Point ClickPoint = new Point(e.X, e.Y);
            TreeNode CurrentNode = RollNodesTreeView.GetNodeAt(ClickPoint);
            if (CurrentNode == null)//判断你点的是不是一个节点               
                return;

            RollNodesTreeView.SelectedNode = CurrentNode;//选中这个节点
        }

        #region 右键菜单点击事件

        private void Import_StripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = RollNodesTreeView.SelectedNode as RollNode;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var filePath = openFileDialog.FileName;
            ImportChildren(selectedNode, filePath, true);
        }

        private void ImportChildren(RollNode parentNode, string filePath, bool isTopNode)
        {
            if (isTopNode == false)
            {
                var dir = Path.GetDirectoryName(filePath);
                filePath = Path.Combine(dir, parentNode.Text + ".xls");
                if (File.Exists(filePath) == false)
                    filePath = Path.Combine(dir, parentNode.Text + ".xlsx");

                if (File.Exists(filePath) == false)
                    return;
            }

            //打开工作簿
            var dataSet = ExcelReaderUtilityr.Opene2DataSet(filePath);
            var dataTable = dataSet.Tables[0];
            foreach (DataRow row in dataTable.Rows)
            {
                var array = row.ItemArray.Select(s => s.ToString()).ToArray();
                var stringBuilder = new StringBuilder();
                foreach (var str in array)
                {
                    stringBuilder.Append(str);
                    stringBuilder.Append(Environment.NewLine);
                }
                var node = new RollNode(array[0], stringBuilder.ToString());
                parentNode.Nodes.Add(node);
                ImportChildren(node, filePath, false);
            }
        }

        private void Remove_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = RollNodesTreeView.SelectedNode as RollNode;
            selectedNode.Remove();
        }

        private void Clear_StripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = RollNodesTreeView.SelectedNode as RollNode;
            selectedNode.Nodes.Clear();
        }

        private void More_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = (RollNode)RollNodesTreeView.SelectedNode;
            selectedNode.ShowTag(this);
        }

        #endregion
    }
}
