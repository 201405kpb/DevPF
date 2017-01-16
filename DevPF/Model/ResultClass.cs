using Newtonsoft.Json;
using System;

namespace DevPF.Model
{
    public class ResultClass<T>
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonProperty("result")]
        public bool Result
        {
            get;
            set;
        }

        /// <summary>
        /// 返回信息
        /// </summary>
        [JsonProperty("msg")]
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// 返回结果，结构可能为空
        /// </summary>
        [JsonProperty("data")]
        public T ResultInfo
        {
            get;
            set;
        }
    }
}
