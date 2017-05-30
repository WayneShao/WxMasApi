using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using WxMasApi.Common;

namespace WxMasApi
{
    public class RetJson
    {
        /// <summary>
        /// 消息发送类型
        /// </summary>
        public int StatusCode { get; set; }
        public Hashtable Data { get; set; } = new Hashtable();


        public RetJson() { }

        public RetJson(int code)
        {
            StatusCode = code;
        }

        public RetJson(int code, params KeyValuePair<object, object>[] args)
        {
            StatusCode = code;
            Data = new Hashtable(args.Length);
            foreach (var pair in args)
                Data.Add(pair.Key, pair.Value);
        }

        public override string ToString()
        {

            return JsonHelper.Serialize(this);
        }
    }
}