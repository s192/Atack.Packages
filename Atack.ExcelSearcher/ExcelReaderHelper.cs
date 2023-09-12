using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atack.ExcelSearcher
{
    internal class ExcelReaderHelper
    {
        /// <summary>
        /// 打开读取Excel文件，返回
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static DataSet Opene2DataSet(string filePath)
        {
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

                    //处理表头
                    var count = result.Tables.Count;
                    for (int i = 0; i < count; i++)
                    {
                        var table = result.Tables[i];
                        try
                        {
                            foreach (DataColumn column in table.Columns)
                            {
                                column.ColumnName = table.Rows[0][column.Ordinal].ToString();
                            }
                            table.Rows.Remove(table.Rows[0]);
                        }
                        catch
                        {
                            result.Tables.Remove(table);
                            count--;
                            i--;
                        }
                    }
                    return result;
                }
            }
        }

    }
}
