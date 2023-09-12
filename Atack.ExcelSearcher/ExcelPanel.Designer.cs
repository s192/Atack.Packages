namespace Atack.ExcelSearcher
{
    partial class ExcelPanel
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
            SheetNamesComboBox = new ComboBox();
            DataDataGridView = new DataGridView();
            OpenExcelFileButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(SheetNamesComboBox);
            panel1.Controls.Add(DataDataGridView);
            panel1.Controls.Add(OpenExcelFileButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 544);
            panel1.TabIndex = 0;
            // 
            // SheetNamesComboBox
            // 
            SheetNamesComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SheetNamesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SheetNamesComboBox.FormattingEnabled = true;
            SheetNamesComboBox.Location = new Point(3, 503);
            SheetNamesComboBox.Name = "SheetNamesComboBox";
            SheetNamesComboBox.Size = new Size(121, 25);
            SheetNamesComboBox.TabIndex = 9;
            SheetNamesComboBox.SelectedIndexChanged += SheetNamesComboBox_SelectedIndexChanged;
            // 
            // DataDataGridView
            // 
            DataDataGridView.AllowUserToAddRows = false;
            DataDataGridView.AllowUserToDeleteRows = false;
            DataDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDataGridView.Location = new Point(3, 61);
            DataDataGridView.Name = "DataDataGridView";
            DataDataGridView.ReadOnly = true;
            DataDataGridView.RowTemplate.Height = 25;
            DataDataGridView.Size = new Size(453, 432);
            DataDataGridView.TabIndex = 8;
            DataDataGridView.RowStateChanged += DataDataGridView_RowStateChanged;
            // 
            // OpenExcelFileButton
            // 
            OpenExcelFileButton.Location = new Point(3, 9);
            OpenExcelFileButton.Name = "OpenExcelFileButton";
            OpenExcelFileButton.Size = new Size(109, 44);
            OpenExcelFileButton.TabIndex = 7;
            OpenExcelFileButton.Text = "打开Excel";
            OpenExcelFileButton.UseVisualStyleBackColor = true;
            OpenExcelFileButton.Click += OpenExcelFileButton_Click;
            // 
            // ExcelPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "ExcelPanel";
            Size = new Size(459, 544);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox SheetNamesComboBox;
        private DataGridView DataDataGridView;
        private Button OpenExcelFileButton;
    }
}
