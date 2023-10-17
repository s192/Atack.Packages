namespace Atack.RollCaller.Controls
{
    partial class ImportControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            BackButton = new Button();
            RollNodesTreeView = new TreeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            导入名单ToolStripMenuItem = new ToolStripMenuItem();
            全部展开ToolStripMenuItem = new ToolStripMenuItem();
            移除ToolStripMenuItem = new ToolStripMenuItem();
            清空ToolStripMenuItem = new ToolStripMenuItem();
            详情ToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BackButton);
            panel1.Controls.Add(RollNodesTreeView);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Bottom;
            BackButton.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.ForeColor = SystemColors.ControlText;
            BackButton.Location = new Point(260, 330);
            BackButton.MinimumSize = new Size(280, 110);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(280, 110);
            BackButton.TabIndex = 0;
            BackButton.Text = "返回";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // RollNodesTreeView
            // 
            RollNodesTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RollNodesTreeView.ContextMenuStrip = contextMenuStrip1;
            RollNodesTreeView.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RollNodesTreeView.Location = new Point(310, 36);
            RollNodesTreeView.Name = "RollNodesTreeView";
            RollNodesTreeView.Size = new Size(181, 288);
            RollNodesTreeView.TabIndex = 1;
            RollNodesTreeView.KeyDown += RollNodesTreeView_KeyDown;
            RollNodesTreeView.MouseDoubleClick += RollNodesTreeView_MouseDoubleClick;
            RollNodesTreeView.MouseDown += RollNodesTreeView_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 导入名单ToolStripMenuItem, 全部展开ToolStripMenuItem, 移除ToolStripMenuItem, 清空ToolStripMenuItem, 详情ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 184);
            // 
            // 导入名单ToolStripMenuItem
            // 
            导入名单ToolStripMenuItem.Name = "导入名单ToolStripMenuItem";
            导入名单ToolStripMenuItem.Size = new Size(184, 36);
            导入名单ToolStripMenuItem.Text = "导入名单";
            导入名单ToolStripMenuItem.Click += Import_StripMenuItem_Click;
            // 
            // 全部展开ToolStripMenuItem
            // 
            全部展开ToolStripMenuItem.Name = "全部展开ToolStripMenuItem";
            全部展开ToolStripMenuItem.Size = new Size(184, 36);
            全部展开ToolStripMenuItem.Text = "全部展开";
            全部展开ToolStripMenuItem.Click += ExpandAll_StripMenuItem_Click;
            // 
            // 移除ToolStripMenuItem
            // 
            移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            移除ToolStripMenuItem.Size = new Size(184, 36);
            移除ToolStripMenuItem.Text = "移除";
            移除ToolStripMenuItem.Click += Remove_StripMenuItem_Click;
            // 
            // 清空ToolStripMenuItem
            // 
            清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            清空ToolStripMenuItem.Size = new Size(184, 36);
            清空ToolStripMenuItem.Text = "清空";
            清空ToolStripMenuItem.Click += Clear_StripMenuItem_Click;
            // 
            // 详情ToolStripMenuItem
            // 
            详情ToolStripMenuItem.Name = "详情ToolStripMenuItem";
            详情ToolStripMenuItem.Size = new Size(184, 36);
            详情ToolStripMenuItem.Text = "详情";
            详情ToolStripMenuItem.Click += More_StripMenuItem_Click;
            // 
            // ImportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "ImportControl";
            Size = new Size(800, 450);
            panel1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TreeView RollNodesTreeView;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 导入名单ToolStripMenuItem;
        private ToolStripMenuItem 清空ToolStripMenuItem;
        private ToolStripMenuItem 移除ToolStripMenuItem;
        private ToolStripMenuItem 详情ToolStripMenuItem;
        private Button BackButton;
        private ToolStripMenuItem 全部展开ToolStripMenuItem;
    }
}
