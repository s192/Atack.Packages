using Atack.RollCaller.Controls;

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
            SetPictureButton = new Button();
            CalledListButton = new Button();
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
            ExitButton.TabIndex = 4;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // startControl1
            // 
            startControl1.BackColor = Color.Transparent;
            startControl1.Dock = DockStyle.Fill;
            startControl1.Location = new Point(0, 0);
            startControl1.MinimumSize = new Size(800, 450);
            startControl1.Name = "startControl1";
            startControl1.Size = new Size(800, 450);
            startControl1.TabIndex = 0;
            // 
            // ImportButton
            // 
            ImportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ImportButton.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            ImportButton.ForeColor = SystemColors.ControlText;
            ImportButton.Location = new Point(537, 12);
            ImportButton.MaximumSize = new Size(60, 60);
            ImportButton.MinimumSize = new Size(60, 60);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(60, 60);
            ImportButton.TabIndex = 2;
            ImportButton.Text = "I";
            ImportButton.UseVisualStyleBackColor = true;
            ImportButton.Click += ImportButton_Click;
            // 
            // SetPictureButton
            // 
            SetPictureButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SetPictureButton.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            SetPictureButton.ForeColor = SystemColors.ControlText;
            SetPictureButton.Location = new Point(603, 12);
            SetPictureButton.MaximumSize = new Size(60, 60);
            SetPictureButton.MinimumSize = new Size(60, 60);
            SetPictureButton.Name = "SetPictureButton";
            SetPictureButton.Size = new Size(60, 60);
            SetPictureButton.TabIndex = 3;
            SetPictureButton.Text = "B";
            SetPictureButton.UseVisualStyleBackColor = true;
            SetPictureButton.Click += SetPictureButton_Click;
            // 
            // CalledListButton
            // 
            CalledListButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CalledListButton.Font = new Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            CalledListButton.ForeColor = SystemColors.ControlText;
            CalledListButton.Location = new Point(471, 12);
            CalledListButton.MaximumSize = new Size(60, 60);
            CalledListButton.MinimumSize = new Size(60, 60);
            CalledListButton.Name = "CalledListButton";
            CalledListButton.Size = new Size(60, 60);
            CalledListButton.TabIndex = 1;
            CalledListButton.Text = "已";
            CalledListButton.UseVisualStyleBackColor = true;
            CalledListButton.Click += CalledListButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = Properties.Resources.R_C;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(CalledListButton);
            Controls.Add(SetPictureButton);
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
        private Button SetPictureButton;
        private Button CalledListButton;
    }
}