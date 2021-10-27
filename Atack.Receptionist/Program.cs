using System;
using System.Windows.Forms;

namespace Atack.Receptionist
{
    /// <summary>
    /// 实现将所选择的文件夹的下级目录的文件移动到所选文件夹
    /// </summary>
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
