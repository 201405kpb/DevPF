using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DevPF.Model
{
    public class DeviceClass : IFlagBase
    {
        private List<string> _ignoreList;

        [JsonProperty("device")]
        public int Device
        {
            get;
            set;
        }

        [JsonProperty("siteId")]
        public int SiteId
        {
            get;
            set;
        }

        [JsonProperty("flag")]
        public int Flag
        {
            get;
            set;
        }

        [JsonProperty("val")]
        public int Value
        {
            get;
            set;
        }

        [JsonIgnore]
        public List<string> IgnoreProperties
        {
            get
            {
                if (this._ignoreList == null)
                {
                    this._ignoreList = new List<string>();
                }
                return this._ignoreList;
            }
            set
            {
                this._ignoreList = value;
            }
        }
    }
    public class DeviceClassResult : IBase
    {
        [JsonProperty("nodeId")]
        public int NodeId
        {
            get;
            set;
        }

        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("version")]
        public string Version
        {
            get;
            set;
        }
    }
    public interface IBase

    {
    }

    public interface IFlagBase:IBase
    {
        int Flag{get;set;}
    }
}
