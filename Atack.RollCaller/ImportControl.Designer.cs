namespace Atack.RollCaller
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
            RollNodesTreeView = new TreeView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            导入名单ToolStripMenuItem = new ToolStripMenuItem();
            移除ToolStripMenuItem = new ToolStripMenuItem();
            清空ToolStripMenuItem = new ToolStripMenuItem();
            BactButton = new Button();
            详情ToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(RollNodesTreeView);
            panel1.Controls.Add(BactButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // RollNodesTreeView
            // 
            RollNodesTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RollNodesTreeView.ContextMenuStrip = contextMenuStrip1;
            RollNodesTreeView.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            RollNodesTreeView.Location = new Point(110, 67);
            RollNodesTreeView.Name = "RollNodesTreeView";
            RollNodesTreeView.Size = new Size(581, 362);
            RollNodesTreeView.TabIndex = 9;
            RollNodesTreeView.MouseDown += RollNodesTreeView_MouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 导入名单ToolStripMenuItem, 移除ToolStripMenuItem, 清空ToolStripMenuItem, 详情ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 170);
            // 
            // 导入名单ToolStripMenuItem
            // 
            导入名单ToolStripMenuItem.Name = "导入名单ToolStripMenuItem";
            导入名单ToolStripMenuItem.Size = new Size(184, 36);
            导入名单ToolStripMenuItem.Text = "导入名单";
            导入名单ToolStripMenuItem.Click += Import_StripMenuItem_Click;
            // 
            // 移除ToolStripMenuItem
            // 
            移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            移除ToolStripMenuItem.Size = new Size(184, 36);
            移除ToolStripMenuItem.Text = "移除";
            移除ToolStripMenuItem.Click += Remove_ToolStripMenuItem_Click;
            // 
            // 清空ToolStripMenuItem
            // 
            清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            清空ToolStripMenuItem.Size = new Size(184, 36);
            清空ToolStripMenuItem.Text = "清空";
            清空ToolStripMenuItem.Click += Clear_StripMenuItem_Click;
            // 
            // BactButton
            // 
            BactButton.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            BactButton.ForeColor = SystemColors.ControlText;
            BactButton.Location = new Point(12, 12);
            BactButton.MaximumSize = new Size(60, 60);
            BactButton.MinimumSize = new Size(60, 60);
            BactButton.Name = "BactButton";
            BactButton.Size = new Size(60, 60);
            BactButton.TabIndex = 8;
            BactButton.Text = "<";
            BactButton.UseVisualStyleBackColor = true;
            BactButton.Click += BactButton_Click;
            // 
            // 详情ToolStripMenuItem
            // 
            详情ToolStripMenuItem.Name = "详情ToolStripMenuItem";
            详情ToolStripMenuItem.Size = new Size(184, 36);
            详情ToolStripMenuItem.Text = "详情";
            详情ToolStripMenuItem.Click += More_ToolStripMenuItem_Click;
            // 
            // ImportControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private Button BactButton;
        private TreeView RollNodesTreeView;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 导入名单ToolStripMenuItem;
        private ToolStripMenuItem 清空ToolStripMenuItem;
        private ToolStripMenuItem 移除ToolStripMenuItem;
        private ToolStripMenuItem 详情ToolStripMenuItem;
    }
}
