namespace Atack.WinForm
{
    partial class ProgressBarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TextGroupBox = new System.Windows.Forms.GroupBox();
            this.TheTimer = new System.Windows.Forms.Timer(this.components);
            this.ThePanel = new System.Windows.Forms.Panel();
            this.TheProgressBar = new System.Windows.Forms.ProgressBar();
            this.TextGroupBox.SuspendLayout();
            this.ThePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // curProcessText
            // 
            this.TextGroupBox.Controls.Add(this.TheProgressBar);
            this.TextGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextGroupBox.Location = new System.Drawing.Point(0, 0);
            this.TextGroupBox.Name = "curProcessText";
            this.TextGroupBox.Size = new System.Drawing.Size(364, 45);
            this.TextGroupBox.TabIndex = 1;
            this.TextGroupBox.TabStop = false;
            this.TextGroupBox.Text = "正在执行操作,请稍后......";
            // 
            // curTimer
            // 
            this.TheTimer.Enabled = true;
            this.TheTimer.Tick += new System.EventHandler(this.TheTimer_Tick);
            // 
            // panel1
            // 
            this.ThePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ThePanel.Controls.Add(this.TextGroupBox);
            this.ThePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThePanel.Location = new System.Drawing.Point(0, 0);
            this.ThePanel.Name = "panel1";
            this.ThePanel.Size = new System.Drawing.Size(366, 47);
            this.ThePanel.TabIndex = 2;
            // 
            // curProgressBar
            // 
            this.TheProgressBar.Location = new System.Drawing.Point(6, 15);
            this.TheProgressBar.Name = "curProgressBar";
            this.TheProgressBar.Size = new System.Drawing.Size(354, 23);
            this.TheProgressBar.TabIndex = 0;
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 47);
            this.Controls.Add(this.ThePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressBarForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TextGroupBox.ResumeLayout(false);
            this.ThePanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox TextGroupBox;
        private System.Windows.Forms.Timer TheTimer;
        private System.Windows.Forms.ProgressBar TheProgressBar;
        private System.Windows.Forms.Panel ThePanel;
    }
}