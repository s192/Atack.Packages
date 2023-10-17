namespace Atack.RollCaller.Utils
{
    /// <summary>
    /// ��ʾ������
    /// </summary>
    public static class MsgBox
    {

        /// <summary>
        /// չʾ������ʾ����
        /// </summary>
        /// <param name="message"></param>
        /// <param name="owner"></param>
        public static void ShowError(string message, IWin32Window owner = null)
        {
            InnerShow(DialogType.Error, message, owner);
        }

        /// <summary>
        /// չʾ��Ϣ��ʾ����
        /// </summary>
        /// <param name="message"></param>
        /// <param name="owner"></param>
        public static void ShowInformation(string message, IWin32Window owner = null)
        {
            InnerShow(DialogType.Information, message, owner);
        }

        /// <summary>
        /// չʾ������ʾ����
        /// </summary>
        /// <param name="message"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        public static DialogResult ShowWarning(string message, IWin32Window owner = null)
        {
            return InnerShow(DialogType.Warning, message, owner);
        }

        /// <summary>
        /// ��ʾ��ʾ����
        /// </summary>
        /// <param name="dialogType"></param>
        /// <param name="message"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        private static DialogResult InnerShow(DialogType dialogType, string message, IWin32Window owner)
        {
            switch (dialogType)
            {
                case DialogType.Error:
                    return MessageBox.Show(owner, message, "����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                case DialogType.Information:
                    return MessageBox.Show(owner, message, "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                case DialogType.Warning:
                    return MessageBox.Show(owner, message, "����", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                default:
                    throw new ArgumentOutOfRangeException(nameof(dialogType));
            }
        }

        /// <summary>
        /// ��ʾ��������
        /// </summary>
        private enum DialogType
        {
            /// <summary>
            /// ������ʾ����
            /// </summary>
            Error,

            /// <summary>
            /// ��Ϣ��ʾ����
            /// </summary>
            Information,

            /// <summary>
            /// ������ʾ����
            /// </summary>
            Warning
        }
    }
}