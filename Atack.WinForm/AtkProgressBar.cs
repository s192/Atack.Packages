using System.Threading;

namespace Atack.WinForm
{
    /// <summary>
    /// 进度条
    /// </summary>
    public static class AtkProgressBar
    {
        /// <summary>
        /// 是否正在运行
        /// </summary>
        public static bool IsRunning { get; private set; } = false;

        /// <summary>
        /// 
        /// </summary>
        internal static string ProcessBarText { get; private set; } = "正在执行操作,请稍后......";

        /// <summary>
        /// 启动进度条
        /// </summary>
        public static void Start()
        {
            if (!IsRunning)
            {
                var thread = new Thread(RunProcessBar);
                thread.IsBackground = true;
                thread.Start();
            }
        }

        /// <summary>
        /// 终止进度条
        /// </summary>
        public static void Stop()
        {
            ProcessBarText = "正在执行操作，请稍后......";
            IsRunning = false;
        }

        /// <summary>
        /// 设置文本
        /// </summary>
        /// <param name="text"></param>
        public static void SetText(string text)
        {
            if (text != null)
            {
                if (!IsRunning)
                {
                    Start();
                }
                ProcessBarText = text + "......";
            }
        }

        /// <summary>
        /// 启动进度条
        /// </summary>
        private static void RunProcessBar()
        {
            IsRunning = true;
            new ProgressBarForm().ShowDialog();
        }

    }
}