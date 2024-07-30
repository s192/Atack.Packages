using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace AStack.ClipbrdMonitor
{
    public partial class MainForm : Form
    {
        public const int WM_CLIPBOARDUPDATE = 0x031D;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool AddClipboardFormatListener(IntPtr hWnd);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool RemoveClipboardFormatListener(IntPtr hWnd);

        //private int lastTickCount;

        private Queue<string> queue = new Queue<string>(10);

        public MainForm()
        {
            InitializeComponent();

            AddClipboardFormatListener(this.Handle);
        }

        private void ClipboardNotification_ClipboardUpdate()
        {
            //DataFormats.WaveAudio
            if (Clipboard.ContainsText())
            {
                queue.Enqueue(Clipboard.GetText());

            }
            else if (Clipboard.ContainsAudio())
            {
                queue.Enqueue("Audio");
            }
            else if (Clipboard.ContainsFileDropList())
            {
                queue.Enqueue("FileDropList");
            }
            else if (Clipboard.ContainsImage())
            {
                queue.Enqueue("Image");
            }

            if (queue.Count == 10)
                queue.Dequeue();

            textBox1.Text = string.Concat(queue.Reverse().Select(s => s + Environment.NewLine));
        }

        ~MainForm()
        {
            RemoveClipboardFormatListener(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_CLIPBOARDUPDATE)
            {
                //列表类解析，会阻止时间，用此法不行，再用lastText方法
                // if (Environment.TickCount - this.lastTickCount >= 200)
                ClipboardNotification_ClipboardUpdate();
                //this.lastTickCount = Environment.TickCount;
                m.Result = IntPtr.Zero;
            }
            base.WndProc(ref m);
        }
    }
}
