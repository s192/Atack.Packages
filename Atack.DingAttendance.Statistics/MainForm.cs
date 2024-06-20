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
            //�򿪹�����
            var res = ExcelReaderHelper.Open2PersonalAttendances(filePath).ToList();

            var dt = new DataTable();
            dt.Columns.Add("����", typeof(string));
            dt.Columns.Add("�ϰ�ȱ��", typeof(double));
            dt.Columns.Add("�°�ȱ��", typeof(double));
            dt.Columns.Add("�ϼ�ȱ��", typeof(double));

            //Сѧ��
            Sift("Сѧ��", dt, res, w => (w.Department.Contains("Сѧ��") || w.Department == "ѧУ�����Ŷ�") && w.AttendanceGroup != "���в�");
            //���в�
            Sift("���в�", dt, res, w => (w.Department.Contains("���в�") || w.Department == "ѧУ�����Ŷ�") && w.AttendanceGroup != "Сѧ��");
            //������������
            Sift("������������", dt, res, w => w.Department == "������������");
            //���ڷ�������
            Sift("���ڷ�������", dt, res, w => w.Department == "���ڷ�������");
            //��˲���ѧ���칫��
            Sift("��˲���ѧ���칫��", dt, res, w => w.Department == "��˲���ѧ���칫��");

            DataDataGridView.DataSource = dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">��������</param>
        /// <param name="dt">���ݱ�</param>
        /// <param name="personalAttendances">������Ϣ��</param>
        /// <param name="func">ɸѡ����</param>
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
