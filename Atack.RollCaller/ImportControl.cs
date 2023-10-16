using Atack.RollCaller.Utils;
using Atack.RollCaller.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Atack.RollCaller
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

        private void Import_StripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = RollNodesTreeView.SelectedNode as RollNode;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var filePath = openFileDialog.FileName;
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
                selectedNode.Nodes.Add(new RollNode(array[0], stringBuilder.ToString()));
            }
            selectedNode.Expand();
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

        private void More_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = RollNodesTreeView.SelectedNode as RollNode;
            MessageBox.Show(this, selectedNode?.Tag?.ToString() ?? string.Empty, "详情", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
