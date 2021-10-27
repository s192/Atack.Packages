
namespace AStack.PdfConverter.Word
{
    partial class MainForm
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
            this.SourceFileListBox = new System.Windows.Forms.ListBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.BrowserFileButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SourceFileListBox
            // 
            this.SourceFileListBox.FormattingEnabled = true;
            this.SourceFileListBox.ItemHeight = 12;
            this.SourceFileListBox.Location = new System.Drawing.Point(108, 108);
            this.SourceFileListBox.Name = "SourceFileListBox";
            this.SourceFileListBox.Size = new System.Drawing.Size(584, 196);
            this.SourceFileListBox.TabIndex = 9;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(346, 348);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(108, 48);
            this.ApplyButton.TabIndex = 8;
            this.ApplyButton.Text = "转换";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // BrowserFileButton
            // 
            this.BrowserFileButton.Location = new System.Drawing.Point(584, 52);
            this.BrowserFileButton.Name = "BrowserFileButton";
            this.BrowserFileButton.Size = new System.Drawing.Size(108, 34);
            this.BrowserFileButton.TabIndex = 6;
            this.BrowserFileButton.Text = "浏览文件";
            this.BrowserFileButton.UseVisualStyleBackColor = true;
            this.BrowserFileButton.Click += new System.EventHandler(this.BrowserFileButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(584, 21);
            this.textBox1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 436);
            this.Controls.Add(this.SourceFileListBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.BrowserFileButton);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SourceFileListBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button BrowserFileButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}