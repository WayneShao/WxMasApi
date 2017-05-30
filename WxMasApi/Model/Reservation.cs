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
        public Item Item { get; set; }
    }
}