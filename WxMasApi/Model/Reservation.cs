using System;
using System.Runtime.Serialization;

namespace WxMasApi.Model
{
    [DataContract]
    public class Reservation
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Department { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public DateTime BeginTime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }
        [DataMember]
        public string ExamName { get; set; }
        [DataMember]
        public string CheckSite { get; set; }
        [DataMember]
        public string StudyFee { get; set; }
        [DataMember]
        public string AppliedDepartment { get; set; }
        [DataMember]
        public string AppliedDoctor { get; set; }
        [DataMember]
        public DateTime AppliedDatetime { get; set; }
        [DataMember]
        public string ClinicDiagnose { get; set; }
    }
}