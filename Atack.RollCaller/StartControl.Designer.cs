namespace Atack.RollCaller
{
    partial class StartControl
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
            panel1 = new Panel();
            label1 = new Label();
            CountNumericUpDown = new NumericUpDown();
            StartButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CountNumericUpDown);
            panel1.Controls.Add(StartButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(260, 259);
            label1.Name = "label1";
            label1.Size = new Size(195, 46);
            label1.TabIndex = 6;
            label1.Text = "点名人数：";
            label1.Visible = false;
            // 
            // CountNumericUpDown
            // 
            CountNumericUpDown.Anchor = AnchorStyles.None;
            CountNumericUpDown.Font = new Font("Microsoft YaHei UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            CountNumericUpDown.Location = new Point(472, 257);
            CountNumericUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            CountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CountNumericUpDown.Name = "CountNumericUpDown";
            CountNumericUpDown.ReadOnly = true;
            CountNumericUpDown.Size = new Size(53, 52);
            CountNumericUpDown.TabIndex = 5;
            CountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            CountNumericUpDown.Visible = false;
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.None;
            StartButton.Font = new Font("Microsoft YaHei UI", 42F, FontStyle.Bold, GraphicsUnit.Point);
            StartButton.Location = new Point(260, 141);
            StartButton.MinimumSize = new Size(280, 110);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(280, 110);
            StartButton.TabIndex = 4;
            StartButton.Text = "开始";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StartControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "StartControl";
            Size = new Size(800, 450);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CountNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private NumericUpDown CountNumericUpDown;
        private Button StartButton;
    }
}
