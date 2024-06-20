namespace Atack.DingAttendance.Statistics.Models
{
    /// <summary>
    /// 个人考勤信息
    /// </summary>
    internal class PersonalAttendance
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// 考勤组
        /// </summary>
        public string AttendanceGroup { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// 上班缺卡次数
        /// </summary>
        public double MissingPunchingInCount { get; set; }

        /// <summary>
        /// 下班缺卡次数
        /// </summary>
        public double MissingPunchingOutCount { get; set; }
    }
}
