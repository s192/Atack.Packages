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
            OpenDataFileButton = new Button();
            OpenFilterFileButton = new Button();
            DataDataGridView = new DataGridView();
            FilterDataGridView = new DataGridView();
            FilterButton = new Button();
            DataColumnsComboBox = new ComboBox();
            FilterColumnsComboBox = new ComboBox();
            ExportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DataDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilterDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OpenDataFileButton
            // 
            OpenDataFileButton.Location = new Point(50, 46);
            OpenDataFileButton.Name = "OpenDataFileButton";
            OpenDataFileButton.Size = new Size(109, 44);
            OpenDataFileButton.TabIndex = 1;
            OpenDataFileButton.Text = "打开数据Excel";
            OpenDataFileButton.UseVisualStyleBackColor = true;
            OpenDataFileButton.Click += OpenDataFileButton_Click;
            // 
            // OpenFilterFileButton
            // 
            OpenFilterFileButton.Location = new Point(207, 51);
            OpenFilterFileButton.Name = "OpenFilterFileButton";
            OpenFilterFileButton.Size = new Size(119, 39);
            OpenFilterFileButton.TabIndex = 2;
            OpenFilterFileButton.Text = "打开筛选Excel";
            OpenFilterFileButton.UseVisualStyleBackColor = true;
            OpenFilterFileButton.Click += OpenFilterFileButton_Click;
            // 
            // DataDataGridView
            // 
            DataDataGridView.AllowUserToAddRows = false;
            DataDataGridView.AllowUserToDeleteRows = false;
            DataDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataDataGridView.Location = new Point(12, 106);
            DataDataGridView.Name = "DataDataGridView";
            DataDataGridView.ReadOnly = true;
            DataDataGridView.RowTemplate.Height = 25;
            DataDataGridView.Size = new Size(417, 463);
            DataDataGridView.TabIndex = 3;
            DataDataGridView.RowStateChanged += DataDataGridView_RowStateChanged;
            // 
            // FilterDataGridView
            // 
            FilterDataGridView.AllowUserToAddRows = false;
            FilterDataGridView.AllowUserToDeleteRows = false;
            FilterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilterDataGridView.Location = new Point(438, 106);
            FilterDataGridView.Name = "FilterDataGridView";
            FilterDataGridView.ReadOnly = true;
            FilterDataGridView.RowTemplate.Height = 25;
            FilterDataGridView.Size = new Size(417, 463);
            FilterDataGridView.TabIndex = 4;
            // 
            // FilterButton
            // 
            FilterButton.Location = new Point(674, 48);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(109, 44);
            FilterButton.TabIndex = 5;
            FilterButton.Text = "筛选";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // DataColumnsComboBox
            // 
            DataColumnsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DataColumnsComboBox.FormattingEnabled = true;
            DataColumnsComboBox.Location = new Point(367, 59);
            DataColumnsComboBox.Name = "DataColumnsComboBox";
            DataColumnsComboBox.Size = new Size(121, 25);
            DataColumnsComboBox.TabIndex = 6;
            // 
            // FilterColumnsComboBox
            // 
            FilterColumnsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterColumnsComboBox.FormattingEnabled = true;
            FilterColumnsComboBox.Location = new Point(530, 59);
            FilterColumnsComboBox.Name = "FilterColumnsComboBox";
            FilterColumnsComboBox.Size = new Size(121, 25);
            FilterColumnsComboBox.TabIndex = 7;
            // 
            // ExportButton
            // 
            ExportButton.Location = new Point(799, 49);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(94, 41);
            ExportButton.TabIndex = 8;
            ExportButton.Text = "导出";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 581);
            Controls.Add(ExportButton);
            Controls.Add(FilterColumnsComboBox);
            Controls.Add(DataColumnsComboBox);
            Controls.Add(FilterButton);
            Controls.Add(FilterDataGridView);
            Controls.Add(DataDataGridView);
            Controls.Add(OpenFilterFileButton);
            Controls.Add(OpenDataFileButton);
            Name = "MainForm";
            Text = "Excel筛选";
            ((System.ComponentModel.ISupportInitialize)DataDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilterDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button OpenDataFileButton;
        private Button OpenFilterFileButton;
        private DataGridView DataDataGridView;
        private DataGridView FilterDataGridView;
        private Button FilterButton;
        private ComboBox DataColumnsComboBox;
        private ComboBox FilterColumnsComboBox;
        private Button ExportButton;
    }
}