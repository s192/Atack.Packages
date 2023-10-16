namespace Atack.RollCaller
{
    partial class RollControl
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
            BactButton = new Button();
            StopButton = new Button();
            RollTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BactButton);
            panel1.Controls.Add(StopButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.MouseClick += panel1_MouseClick;
            panel1.MouseEnter += panel1_MouseEnter;
            // 
            // BactButton
            // 
            BactButton.Anchor = AnchorStyles.Bottom;
            BactButton.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Bold, GraphicsUnit.Point);
            BactButton.ForeColor = SystemColors.ControlText;
            BactButton.Location = new Point(120, 330);
            BactButton.MinimumSize = new Size(280, 110);
            BactButton.Name = "BactButton";
            BactButton.Size = new Size(280, 110);
            BactButton.TabIndex = 6;
            BactButton.Text = "返回";
            BactButton.UseVisualStyleBackColor = true;
            BactButton.Click += BactButton_Click;
            // 
            // StopButton
            // 
            StopButton.Anchor = AnchorStyles.Bottom;
            StopButton.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Bold, GraphicsUnit.Point);
            StopButton.Location = new Point(400, 330);
            StopButton.MinimumSize = new Size(280, 110);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(280, 110);
            StopButton.TabIndex = 5;
            StopButton.Text = "停止";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // RollTimer
            // 
            RollTimer.Tick += RollTimer_Tick;
            // 
            // RollControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "RollControl";
            Size = new Size(800, 450);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer RollTimer;
        private Button StopButton;
        private Button BactButton;
    }
}
