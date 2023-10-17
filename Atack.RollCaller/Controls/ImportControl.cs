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

        private void BackButton_Click(object sender, EventArgs e)
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
            if (e.Button != MouseButtons.Right)
                return;

            //选中右键点击的节点
            var point = new Point(e.X, e.Y);
            var node = RollNodesTreeView.GetNodeAt(point);
            if (node == null)
            {
                清空ToolStripMenuItem.Visible = false;
                移除ToolStripMenuItem.Visible = false;
                详情ToolStripMenuItem.Visible = false;
            }
            else
            {
                清空ToolStripMenuItem.Visible = true;
                移除ToolStripMenuItem.Visible = true;
                详情ToolStripMenuItem.Visible = true;
                RollNodesTreeView.SelectedNode = node;
            }
        }

        private void RollNodesTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            var node = RollNodesTreeView.SelectedNode as RollNode;
            if (node == null)
                return;

            if (node.Nodes.Count != 0)
                return;

            node.ShowTag(this);
        }

        private void RollNodesTreeView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                RemoveNode(RollNodesTreeView.SelectedNode);
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

        private void Remove_StripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNode(RollNodesTreeView.SelectedNode);
        }

        private void Clear_StripMenuItem_Click(object sender, EventArgs e)
        {
            RollNodesTreeView.SelectedNode.Nodes.Clear();
        }

        private void More_StripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = (RollNode)RollNodesTreeView.SelectedNode;
            selectedNode.ShowTag(this);
        }

        private void ExpandAll_StripMenuItem_Click(object sender, EventArgs e)
        {
            RollNodesTreeView.SelectedNode.ExpandAll();
        }

        #endregion

        private void RemoveNode(TreeNode node)
        {
            if (node.Level == 0)
            {
                MessageBox.Show(this, "根节点不能删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            node.Remove();
        }
    }
}
