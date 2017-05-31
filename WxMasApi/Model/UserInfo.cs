using System.Runtime.Serialization;

namespace WxMasApi.Model
{
    [DataContract]
    public class UserInfo
    {
        /// <summary>
        /// 患者ID
        /// </summary>
        [DataMember]
        public string PatientId { get; set; }
        /// <summary>
        /// 患者姓名
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        [DataMember]
        public string IdNum { get; set; }
    }
}