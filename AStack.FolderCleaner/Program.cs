// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;

Console.WriteLine("空文件夹清理工具：清理给定目录下的空文件夹");

do
{
    Console.WriteLine("请输入路径：");
    //校验路径
    var path = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(path) || Directory.Exists(path) == false)
        continue;

    //筛选空文件夹
    var directoriesAreEmpty = new DirectoryInfo(path).GetDirectories().Where(s => s.GetFileSystemInfos().Length == 0);

    Console.WriteLine("确认删除？（Y/n）");
    var msg = Console.ReadLine();
    if (msg != "Y")
        continue;

    foreach (var directory in directoriesAreEmpty)
    {
        FileSystem.DeleteDirectory(directory.FullName, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
        Console.WriteLine("已删除" + directory.Name);
    }
} while (true);