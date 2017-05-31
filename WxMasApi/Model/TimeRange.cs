using System;
using System.Runtime.Serialization;

namespace WxMasApi.Model
{
    [DataContract]
    public class TimeRange
    {
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
        /// 时间长度
        /// </summary>
        [DataMember]
        public TimeSpan Span => EndTime.Subtract(BeginTime);
    }
}