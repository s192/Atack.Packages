namespace Atack.RollCaller
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Button();
            startControl1 = new StartControl();
            ImportButton = new Button();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ExitButton.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.ForeColor = SystemColors.ControlText;
            ExitButton.Location = new Point(728, 12);
            ExitButton.MaximumSize = new Size(60, 60);
            ExitButton.MinimumSize = new Size(60, 60);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(60, 60);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // startControl1
            // 
            startControl1.Location = new Point(106, 59);
            startControl1.MinimumSize = new Size(800, 450);
            startControl1.Name = "startControl1";
            startControl1.Size = new Size(800, 450);
            startControl1.TabIndex = 1;
            // 
            // ImportButton
            // 
            ImportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ImportButton.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ImportButton.ForeColor = SystemColors.ControlText;
            ImportButton.Location = new Point(594, 12);
            ImportButton.MaximumSize = new Size(60, 60);
            ImportButton.MinimumSize = new Size(60, 60);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(60, 60);
            ImportButton.TabIndex = 2;
            ImportButton.Text = "I";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(800, 450);
            Controls.Add(ImportButton);
            Controls.Add(ExitButton);
            Controls.Add(startControl1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(800, 450);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "随机点名";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private StartControl startControl1;
        private Button ImportButton;
    }
}