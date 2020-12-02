using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace AStack.BarCodeCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "1954585eqwwe";
            var dir = GetRuntimePath();
            var filePath = Path.Combine(dir, "barcode.jpg");
            BarCode.Create(text, filePath);

            Process.Start("explorer", "\"" + dir + "\"");
        }

        /// <summary>
        /// 获取当前程序集所在的目录
        /// </summary>
        public static string GetRuntimePath()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            var directory = Path.GetDirectoryName(path);
            return directory;
        }
    }
}
