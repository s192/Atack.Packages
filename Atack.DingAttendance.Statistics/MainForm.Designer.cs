namespace Atack.DingAttendance.Statistics
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
            OpenExcelFileButton = new Button();
            DataDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OpenExcelFileButton
            // 
            OpenExcelFileButton.Location = new Point(12, 12);
            OpenExcelFileButton.Name = "OpenExcelFileButton";
            OpenExcelFileButton.Size = new Size(144, 62);
            OpenExcelFileButton.TabIndex = 0;
            OpenExcelFileButton.Text = "OpenExcelFile";
            OpenExcelFileButton.UseVisualStyleBackColor = true;
            OpenExcelFileButton.Click += OpenExcelFileButton_Click;
            // 
            // DataDataGridView
            // 
            DataDataGridView.AllowUserToAddRows = false;
            DataDataGridView.AllowUserToDeleteRows = false;
            DataDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDataGridView.Location = new Point(12, 80);
            DataDataGridView.Name = "DataDataGridView";
            DataDataGridView.ReadOnly = true;
            DataDataGridView.Size = new Size(595, 342);
            DataDataGridView.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 434);
            Controls.Add(DataDataGridView);
            Controls.Add(OpenExcelFileButton);
            Name = "MainForm";
            Text = "考勤汇总";
            ((System.ComponentModel.ISupportInitialize)DataDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button OpenExcelFileButton;
        private DataGridView DataDataGridView;
    }
}
