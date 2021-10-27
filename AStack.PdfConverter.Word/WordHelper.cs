using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace AStack.PdfConverter.Word
{
    internal static class WordHelper
    {
        /// <summary>          
        /// 转换为pdf文件
        /// </summary>
        /// <param name="fileList">文件名list</param>
        public static void Convert2PdfFiles(List<string> fileList)
        {
            Application app = new ApplicationClass
            {
                Visible = true//使文档可见
            };

            //由于使用的是COM库，因此有许多变量需要用Missing.Value代替
            object Nothing = Missing.Value;

            foreach (var file in fileList)
            {
                var doc = app.Documents.Open(file);
                var fileName = Path.GetFileNameWithoutExtension(file);
                var dir = Path.GetDirectoryName(file);
                object path = Path.Combine(dir, fileName + ".pdf");
                object format = WdSaveFormat.wdFormatPDF;
                doc.SaveAs(ref path, ref format, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing, ref Nothing);
                //关闭wordDoc文档对象
                doc.Close(ref Nothing, ref Nothing, ref Nothing);
            }

            //关闭wordApp组件对象
            app.Quit(ref Nothing, ref Nothing, ref Nothing);
        }
    }
}
