namespace Atack.Toolbox
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
            ExcelSearcherButton = new Button();
            SuspendLayout();
            // 
            // ExcelSearcherButton
            // 
            ExcelSearcherButton.Location = new Point(107, 66);
            ExcelSearcherButton.Name = "ExcelSearcherButton";
            ExcelSearcherButton.Size = new Size(70, 70);
            ExcelSearcherButton.TabIndex = 0;
            ExcelSearcherButton.Text = "ExcelSearcher";
            ExcelSearcherButton.UseVisualStyleBackColor = true;
            ExcelSearcherButton.Click += ExcelSearcherButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExcelSearcherButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ExcelSearcherButton;
    }
}