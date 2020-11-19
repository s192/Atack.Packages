using iText.Kernel.Pdf;
using System.Collections.Generic;
using System.IO;

namespace AStack.PdfMerger
{
    internal static class PdfHelper
    {
        /// <summary>          
        /// 合成pdf文件
        /// </summary>
        /// <param name="fileList">文件名list</param>
        /// <param name="outMergeFile">输出路径</param>
        public static void MergePdfFiles(List<string> fileList, string outMergeFile)
        {
            PdfWriter writer = new PdfWriter(new FileStream(outMergeFile, FileMode.Create));
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(writer));
            var merger = new iText.Kernel.Utils.PdfMerger(pdfDoc);
            for (int i = 0; i < fileList.Count; i++)
            {
                var reader = new PdfReader(fileList[i]);
                PdfDocument document = new PdfDocument(reader);
                int iPageNum = document.GetNumberOfPages();
                merger.Merge(document, 1, iPageNum);
                document.Close();
            }
            pdfDoc.Close();
        }
    }
}
