using System;
using System.Windows.Forms;

namespace Atack.WinForm
{
    /// <summary>
    /// 进度条窗体
    /// </summary>
    internal partial class ProgressBarForm : Form
    {
        private int processValue = 0;

        public ProgressBarForm()
        {
            InitializeComponent();
            //置顶显示
            TopLevel = true;
        }

        /// <summary>
        /// 计时器跳动事件订阅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TheTimer_Tick(object sender, EventArgs e)
        {
            if (!AtkProgressBar.IsRunning)
            {
                Close();
                return;
            }
            processValue += 4;
            if (processValue > TheProgressBar.Maximum)
            {
                processValue = 0;
            }
            TheProgressBar.Value = processValue;
            TextGroupBox.Text = AtkProgressBar.ProcessBarText;
        }

    }
}