using Atack.WinForm;
using CsvHelper;
using ExcelDataReader;
using System.Data;
using System.Globalization;
using System.Text;

namespace Atack.ExcelSearcher
{
    public partial class MainForm : Form
    {
        private DataTable _dt;

        public MainForm()
        {
            InitializeComponent();

            excelPanel1.FileOpened += ExcelPanel1_FileOpened;
            excelPanel2.FileOpened += ExcelPanel2_FileOpened;
            _dt = new DataTable();
        }

        private void ExcelPanel1_FileOpened()
        {
            FeedComboBox(excelPanel1.CurrentDataTable, DataColumnsComboBox);
        }

        private void ExcelPanel2_FileOpened()
        {
            FeedComboBox(excelPanel2.CurrentDataTable, FilterColumnsComboBox);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var strList = new List<string>();
            var dt = excelPanel1.CurrentDataTable.Clone();
            dt.Clear();
            foreach (DataRow row in excelPanel2.CurrentDataTable.Rows)
            {
                strList.Add(row[FilterColumnsComboBox.Text].ToString());
            }

            foreach (DataRow row in excelPanel1.CurrentDataTable.Rows)
            {
                if (strList.Contains(row[DataColumnsComboBox.Text]))
                {
                    dt.Rows.Add(row.ItemArray);
                }
            }
            excelPanel1.CurrentDataTable = dt;
            _dt = dt;
            MsgBox.ShowInformation($"共筛选出了{dt.Rows.Count}项！");
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var desktopDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var targetPath = Path.Combine(desktopDirectory, excelPanel1.CurrentDataTable.TableName + DateTime.Now.Ticks + ".csv");
            using (var writer = new StreamWriter(targetPath, false, Encoding.UTF8))
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
            MsgBox.ShowInformation("导出成功！\n" + targetPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="comboBox"></param>
        private void FeedComboBox(DataTable? dataTable, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            if (dataTable == null)
                return;

            foreach (DataColumn column in dataTable.Columns)
            {
                comboBox.Items.Add(column.ColumnName);
            }
            comboBox.SelectedItem = comboBox.Items[0];
        }
    }
}