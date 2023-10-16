﻿using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atack.RollCaller.Utils
{
    internal static class ExcelReaderUtilityr
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
                    return result;
                }
            }
        }

    }
}
