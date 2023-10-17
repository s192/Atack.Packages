using Atack.RollCaller.Controls;
using Atack.RollCaller.Utils;
using System.Text;

namespace Atack.RollCaller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

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
            startControl1.BringToFront();
            ImportButton.BringToFront();
            SetPictureButton.BringToFront();
            CalledListButton.BringToFront();

            ImportControl.GetInstance(this).Show();

            ExitButton.BringToFront();
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

        private void CalledListButton_Click(object sender, EventArgs e)
        {
            string msg;
            if (RollConstant.CalledNodeList.Count == 0)
            {
                msg = "ªπŒ¥≥È«©£°";
            }
            else
            {
                var stringBuilder = new StringBuilder();
                foreach (var node in RollConstant.CalledNodeList)
                {
                    stringBuilder.AppendLine(node.Text);
                }
                msg = stringBuilder.ToString();
            }
            MessageBox.Show(this, msg, "“—≥È«©√˚µ•", MessageBoxButtons.OK, MessageBoxIcon.Information);
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