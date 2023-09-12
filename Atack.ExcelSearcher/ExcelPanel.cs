using System.Data;

namespace Atack.ExcelSearcher
{
    public partial class ExcelPanel : UserControl
    {
        private DataTable _currentDataTable;

        /// <summary>
        /// Excel文件转换得到的DataSet
        /// </summary>
        public DataSet? DataSet { get; private set; }

        /// <summary>
        /// 当前展示的Sheet对应的DataTable
        /// </summary>
        public DataTable CurrentDataTable
        {
            get
            {
                return _currentDataTable;
            }
            set
            {
                _currentDataTable = value;
                DataDataGridView.DataSource = _currentDataTable;
            }
        }

        public ExcelPanel()
        {
            InitializeComponent();

            _currentDataTable = new DataTable();
        }

        public event Action? FileOpened;

        private void OpenExcelFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var filePath = openFileDialog.FileName;
            //打开工作簿
            DataSet = ExcelReaderHelper.Opene2DataSet(filePath);
            CurrentDataTable = DataSet.Tables[0];

            //Sheet页名称下拉
            SheetNamesComboBox.Items.Clear();
            foreach (DataTable item in DataSet.Tables)
                SheetNamesComboBox.Items.Add(item.TableName);

            SheetNamesComboBox.SelectedItem = SheetNamesComboBox.Items[0];

            FileOpened?.Invoke();
        }

        private void SheetNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentDataTable = DataSet?.Tables[SheetNamesComboBox.SelectedItem.ToString()];
        }

        private void DataDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
