using System.Data;

using Atack.DingAttendance.Statistics.Models;

using ExcelDataReader;

namespace Atack.DingAttendance.Statistics
{
    internal class ExcelReaderHelper
    {
        /// <summary>
        /// 打开Excel文件，获取考勤信息
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <returns>考勤信息</returns>
        public static IEnumerable<PersonalAttendance> Open2PersonalAttendances(string filePath)
        {
            foreach (DataRow row in OpenAttendancesTable(filePath).Rows)
                yield return Parse2PersonalAttendance(row);

        }

        /// <summary>
        /// 打开读取Excel文件，读取所需信息
        /// </summary>
        /// <param name="filePath">Excel文件路径</param>
        /// <returns></returns>
        private static DataTable OpenAttendancesTable(string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, FileStream?ports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Choose one of either 1 or 2:

                    // 1. Use the reader methods
                    //do
                    //{
                    //    while (reader.Read())
                    //    {
                    //        // reader.GetDouble(0);
                    //    }
                    //} while (reader.NextResult());

                    // 2. Use the AsDataSet extension method
                    var result = reader.AsDataSet();
                    // The result of each spreadsheet is in result.Tables
                    var table = result.Tables[0];

                    #region 处理表头

                    //删除表头信息行
                    table.Rows.Remove(table.Rows[3]);
                    table.Rows.Remove(table.Rows[1]);
                    table.Rows.Remove(table.Rows[0]);

                    //按Row[0]命名DataTable的ColumnName
                    for (int i = 0; i <= 15; i++)
                    {
                        var column = table.Columns[i];
                        column.ColumnName = table.Rows[0][i].ToString();
                    }
                    //删除Row[0]
                    table.Rows.Remove(table.Rows[0]);

                    #endregion

                    return table;
                }
            }
        }

        /// <summary>
        /// Parse DataRow to PersonalAttendance
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        private static PersonalAttendance Parse2PersonalAttendance(DataRow row)
        {
            var personalAttendance = new PersonalAttendance();

            personalAttendance.Name = row[0].ToString();
            personalAttendance.AttendanceGroup = row[1].ToString();
            personalAttendance.Department = row[2].ToString();
            personalAttendance.MissingPunchingInCount = row[10] is DBNull ? 0d : (double)row[10];
            personalAttendance.MissingPunchingOutCount = row[11] is DBNull ? 0d : (double)row[11];

            return personalAttendance;
        }

    }
}
