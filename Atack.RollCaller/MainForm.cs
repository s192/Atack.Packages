using Atack.RollCaller.Controls;
using Atack.RollCaller.Utils;

namespace Atack.RollCaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            ExitButton.BringToFront();
            startControl1.Dock = DockStyle.Fill;

            startControl1.RootNode = RollConstant.Root;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportControl.GetInstance(this).Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ImportControl.GetInstance(this).Show();
        }

        private void SetPictureButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var filePath = openFileDialog.FileName;
            this.BackgroundImage = Image.FromFile(filePath);//…Ë÷√±≥æ∞ÕºŒ™formBackImg.png
            this.BackgroundImageLayout = ImageLayout.Stretch;//…Ë÷√±≥æ∞Õº◊‘  ”¶
        }

        #region ∑¿÷π…¡À∏

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED    
                if (this.IsXpOr2003 == true)
                {
                    cp.ExStyle |= 0x00080000;  // Turn on WS_EX_LAYERED  
                    this.Opacity = 1;
                }
                return cp;
            }
        }

        private Boolean IsXpOr2003
        {
            get
            {
                OperatingSystem os = Environment.OSVersion;
                Version vs = os.Version;
                if (os.Platform == PlatformID.Win32NT)
                    if ((vs.Major == 5) && (vs.Minor != 0))
                        return true;
                    else
                        return false;
                else
                    return false;
            }
        }

        #endregion

    }
}