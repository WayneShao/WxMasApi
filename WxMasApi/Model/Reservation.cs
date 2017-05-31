using System;
using System.Runtime.Serialization;

namespace WxMasApi.Model
{
    [DataContract]
    public class Reservation
    {
        /// <summary>
        /// ID
        /// </summary>
        [DataMember]
        public string Id { get; set; }
        /// <summary>
        /// 预约科室
        /// </summary>
        [DataMember]
        public string Department { get; set; }
        /// <summary>
        /// 申请单状态
        /// </summary>
        [DataMember]
        public string Status { get; set; }
        /// <summary>
        /// 预约日期
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        [DataMember]
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 结束时间
        /// </summary>
        [DataMember]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 检查项目
        /// </summary>
        [DataMember]
        public string ExamName { get; set; }
        /// <summary>
        /// 检查部位
        /// </summary>
        [DataMember]
        public string CheckSite { get; set; }
        /// <summary>
        /// 费用
        /// </summary>
        [DataMember]
        public string StudyFee { get; set; }
        /// <summary>
        /// 申请科室
        /// </summary>
        [DataMember]
        public string AppliedDepartment { get; set; }
        /// <summary>
        /// 申请医生
        /// </summary>
        [DataMember]
        public string AppliedDoctor { get; set; }
        /// <summary>
        /// 申请时间
        /// </summary>
        [DataMember]
        public DateTime AppliedDatetime { get; set; }
        /// <summary>
        /// 临床诊断
        /// </summary>
        [DataMember]
        public string ClinicDiagnose { get; set; }
    }
}