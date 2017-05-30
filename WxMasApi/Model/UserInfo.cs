using System.Runtime.Serialization;

namespace WxMasApi.Model
{
    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string PatientId { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}