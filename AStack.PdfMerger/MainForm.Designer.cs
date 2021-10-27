namespace AStack.PdfMerger
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BrowserFileButton = new System.Windows.Forms.Button();
            this.TargetPathTextBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SourceFileListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(584, 21);
            this.textBox1.TabIndex = 0;
            // 
            // BrowserFileButton
            // 
            this.BrowserFileButton.Location = new System.Drawing.Point(522, 65);
            this.BrowserFileButton.Name = "BrowserFileButton";
            this.BrowserFileButton.Size = new System.Drawing.Size(108, 34);
            this.BrowserFileButton.TabIndex = 1;
            this.BrowserFileButton.Text = "浏览PDF文件";
            this.BrowserFileButton.UseVisualStyleBackColor = true;
            this.BrowserFileButton.Click += new System.EventHandler(this.BrowserFileButton_Click);
            // 
            // TargetPathTextBox
            // 
            this.TargetPathTextBox.Location = new System.Drawing.Point(46, 354);
            this.TargetPathTextBox.Name = "TargetPathTextBox";
            this.TargetPathTextBox.Size = new System.Drawing.Size(584, 21);
            this.TargetPathTextBox.TabIndex = 2;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(284, 390);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(108, 48);
            this.ApplyButton.TabIndex = 3;
            this.ApplyButton.Text = "合并";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // SourceFileListBox
            // 
            this.SourceFileListBox.FormattingEnabled = true;
            this.SourceFileListBox.ItemHeight = 12;
            this.SourceFileListBox.Location = new System.Drawing.Point(46, 121);
            this.SourceFileListBox.Name = "SourceFileListBox";
            this.SourceFileListBox.Size = new System.Drawing.Size(584, 196);
            this.SourceFileListBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "输出文件路径：";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourceFileListBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.TargetPathTextBox);
            this.Controls.Add(this.BrowserFileButton);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 490);
            this.MinimumSize = new System.Drawing.Size(690, 490);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "合并PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BrowserFileButton;
        private System.Windows.Forms.TextBox TargetPathTextBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.ListBox SourceFileListBox;
        private System.Windows.Forms.Label label1;
    }
}

