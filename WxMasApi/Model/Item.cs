using System;
using System.Runtime.Serialization;

namespace WxMasApi.Model
{
    [DataContract]
    public class Item
    {
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