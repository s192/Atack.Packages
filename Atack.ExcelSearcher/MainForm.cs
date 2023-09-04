using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Text;
using Atack.WinForm;
using CsvHelper;
using ExcelDataReader;

namespace Atack.ExcelSearcher
{
    public partial class MainForm : Form
    {
        private DataTable _dataDataTable;
        private DataTable _filterDataTable;
        private DataTable _dt;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenDataFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            var filePath = openFileDialog.FileName;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read())
                        {
                            // reader.GetDouble(0);
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                    // The result of each spreadsheet is in result.Tables
                    var table = result.Tables[0];
                    foreach (DataColumn item in table.Columns)
                    {
                        item.ColumnName = table.Rows[0][item.Ordinal].ToString();
                        DataColumnsComboBox.Items.Add(item.ColumnName);
                    }
                    DataColumnsComboBox.SelectedItem = DataColumnsComboBox.Items[0];
                    table.Rows.Remove(table.Rows[0]);
                    _dataDataTable = table;
                    DataDataGridView.DataSource = _dataDataTable;
                }
            }
        }

        private void OpenFilterFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            var filePath = openFileDialog.FileName;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    do
                    {
                        while (reader.Read())
                        {
                            // reader.GetDouble(0);
                        }
                    } while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                    // The result of each spreadsheet is in result.Tables
                    var table = result.Tables[0];
                    foreach (DataColumn item in table.Columns)
                    {
                        item.ColumnName = table.Rows[0][item.Ordinal].ToString();
                        FilterColumnsComboBox.Items.Add(item.ColumnName);
                    }
                    FilterColumnsComboBox.SelectedItem = FilterColumnsComboBox.Items[0];
                    table.Rows.Remove(table.Rows[0]);
                    _filterDataTable = table;
                    FilterDataGridView.DataSource = _filterDataTable;
                }
            }
        }

        private void DataDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var strList = new List<string>();
            var dt = _dataDataTable.Clone();
            dt.Clear();
            foreach (DataRow row in _filterDataTable.Rows)
            {
                strList.Add(row[FilterColumnsComboBox.Text].ToString());
            }

            foreach (DataRow row in _dataDataTable.Rows)
            {
                if (strList.Contains(row[DataColumnsComboBox.Text]))
                {
                    dt.Rows.Add(row.ItemArray);
                }
            }
            DataDataGridView.DataSource = dt;
            _dt = dt;
            MsgBox.ShowInformation($"共筛选出了{dt.Rows.Count}项！");
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("C:\\Users\\mmzx\\OneDrive\\桌面\\123.csv", false, Encoding.UTF8))
            {
                using (var csvWriter = new CsvWriter(writer, CultureInfo.CurrentCulture))
                {
                    foreach (DataColumn column in _dt.Columns)
                    {
                        csvWriter.WriteField(column.ColumnName);
                    }
                    csvWriter.NextRecord();

                    foreach (DataRow row in _dt.Rows)
                    {
                        for (var i = 0; i < _dt.Columns.Count; i++)
                        {
                            csvWriter.WriteField(row[i].ToString());
                        }
                        csvWriter.NextRecord();
                    }
                }
            }
        }
    }
}