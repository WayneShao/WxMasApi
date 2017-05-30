using System;
using System.Runtime.Serialization;

namespace WxMasApi.Model
{
    [DataContract]
    public class TimeRange
    {
        [DataMember]
        public DateTime BeginTime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }
        [DataMember]
        public TimeSpan Span => EndTime.Subtract(BeginTime);
    }
}