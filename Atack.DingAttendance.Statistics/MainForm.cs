using System.Data;

using Atack.DingAttendance.Statistics.Models;

namespace Atack.DingAttendance.Statistics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenExcelFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            var filePath = openFileDialog.FileName;
            //打开工作簿
            var res = ExcelReaderHelper.Open2PersonalAttendances(filePath).ToList();

            var dt = new DataTable();
            dt.Columns.Add("部门", typeof(string));
            dt.Columns.Add("上班缺卡", typeof(double));
            dt.Columns.Add("下班缺卡", typeof(double));
            dt.Columns.Add("合计缺卡", typeof(double));

            //小学部
            Sift("小学部", dt, res, w => (w.Department.Contains("小学部") || w.Department == "学校管理团队") && w.AttendanceGroup != "初中部");
            //初中部
            Sift("初中部", dt, res, w => (w.Department.Contains("初中部") || w.Department == "学校管理团队") && w.AttendanceGroup != "小学部");
            //行政服务中心
            Sift("行政服务中心", dt, res, w => w.Department == "行政服务中心");
            //后勤服务中心
            Sift("后勤服务中心", dt, res, w => w.Department == "后勤服务中心");
            //凤凰博文学区办公室
            Sift("凤凰博文学区办公室", dt, res, w => w.Department == "凤凰博文学区办公室");

            DataDataGridView.DataSource = dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">部门名称</param>
        /// <param name="dt">数据表</param>
        /// <param name="personalAttendances">考勤信息表</param>
        /// <param name="func">筛选条件</param>
        private void Sift(string name, DataTable dt, IEnumerable<PersonalAttendance> personalAttendances, Func<PersonalAttendance, bool> func)
        {
            var missingInCount = personalAttendances
                .Where(func)
                .Sum(s => s.MissingPunchingInCount);
            var missingOutCount = personalAttendances
                .Where(func)
                .Sum(s => s.MissingPunchingOutCount);
            dt.Rows.Add(name, missingInCount, missingOutCount, missingInCount + missingOutCount);

        }
    }
}
