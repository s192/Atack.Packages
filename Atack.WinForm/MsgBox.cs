using System.Windows.Forms;

namespace Atack.WinForm
{
    /// <summary>
    /// 提示窗体类
    /// </summary>
    public static class MsgBox
    {

        /// <summary>
        /// 展示错误提示窗体
        /// </summary>
        /// <param name="message"></param>
        /// <param name="owner"></param>
        public static void ShowError(string message, IWin32Window owner = null)
        {
            InnerShow(DialogType.Error, message, owner);
        }

        /// <summary>
        /// 展示信息提示窗体
        /// </summary>
        /// <param name="message"></param>
        /// <param name="owner"></param>
        public static void ShowInformation(string message, IWin32Window owner = null)
        {
            InnerShow(DialogType.Information, message, owner);
        }

        /// <summary>
        /// 展示警告提示窗体
        /// </summary>
        /// <param name="message"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        public static DialogResult ShowWarning(string message, IWin32Window owner = null)
        {
            return InnerShow(DialogType.Warning, message, owner);
        }

        /// <summary>
        /// 显示提示窗体
        /// </summary>
        /// <param name="dialogType"></param>
        /// <param name="message"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        private static DialogResult InnerShow(DialogType dialogType, string message, IWin32Window owner)
        {
            //停止进度条
            var flag = false;
            if (AtkProgressBar.IsRunning)
            {
                AtkProgressBar.Stop();
                flag = true;
            }
            try
            {
                switch (dialogType)
                {
                    case DialogType.Error:
                        return MessageBox.Show(owner, message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    case DialogType.Information:
                        return MessageBox.Show(owner, message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    case DialogType.Warning:
                        return MessageBox.Show(owner, message, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    default:
                        throw new System.ArgumentOutOfRangeException(nameof(dialogType));
                }
            }
            finally
            {
                if (flag)
                {
                    //继续进度条
                    AtkProgressBar.Start();
                }
            }
        }

        /// <summary>
        /// 提示窗体类型
        /// </summary>
        private enum DialogType
        {
            /// <summary>
            /// 错误提示窗体
            /// </summary>
            Error,

            /// <summary>
            /// 信息提示窗体
            /// </summary>
            Information,

            /// <summary>
            /// 警告提示窗体
            /// </summary>
            Warning
        }
    }
}