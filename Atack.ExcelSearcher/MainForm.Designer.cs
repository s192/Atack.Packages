namespace Atack.ExcelSearcher
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
            FilterButton = new Button();
            DataColumnsComboBox = new ComboBox();
            FilterColumnsComboBox = new ComboBox();
            ExportButton = new Button();
            excelPanel1 = new ExcelPanel();
            excelPanel2 = new ExcelPanel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(510, 17);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(121, 68);
            FilterButton.TabIndex = 5;
            FilterButton.Text = "筛选";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // DataColumnsComboBox
            // 
            DataColumnsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DataColumnsComboBox.FormattingEnabled = true;
            DataColumnsComboBox.Location = new Point(331, 17);
            DataColumnsComboBox.Name = "DataColumnsComboBox";
            DataColumnsComboBox.Size = new Size(152, 25);
            DataColumnsComboBox.TabIndex = 6;
            // 
            // FilterColumnsComboBox
            // 
            FilterColumnsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterColumnsComboBox.FormattingEnabled = true;
            FilterColumnsComboBox.Location = new Point(331, 60);
            FilterColumnsComboBox.Name = "FilterColumnsComboBox";
            FilterColumnsComboBox.Size = new Size(152, 25);
            FilterColumnsComboBox.TabIndex = 7;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(660, 17);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(121, 68);
            ExportButton.TabIndex = 8;
            ExportButton.Text = "导出";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // excelPanel1
            // 
            excelPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            excelPanel1.CurrentDataTable = null;
            excelPanel1.Location = new Point(12, 91);
            excelPanel1.Name = "excelPanel1";
            excelPanel1.Size = new Size(471, 631);
            excelPanel1.TabIndex = 9;
            // 
            // excelPanel2
            // 
            excelPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            excelPanel2.CurrentDataTable = null;
            excelPanel2.Location = new Point(510, 91);
            excelPanel2.Name = "excelPanel2";
            excelPanel2.Size = new Size(471, 631);
            excelPanel2.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 21);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 11;
            label1.Text = "被筛选列：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 64);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 12;
            label2.Text = "筛选列：";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 734);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(excelPanel2);
            Controls.Add(excelPanel1);
            Controls.Add(ExportButton);
            Controls.Add(FilterColumnsComboBox);
            Controls.Add(DataColumnsComboBox);
            Controls.Add(FilterButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Excel筛选";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button FilterButton;
        private ComboBox DataColumnsComboBox;
        private ComboBox FilterColumnsComboBox;
        private Button ExportButton;
        private ExcelPanel excelPanel1;
        private ExcelPanel excelPanel2;
        private Label label1;
        private Label label2;
    }
}