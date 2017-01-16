using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DevPF.Model
{
    public class VideoClass : IFlagBase
    {
        private List<string> _ignoreList;

        [JsonProperty("flag")]
        public int Flag
        {
            get;
            set;
        }

        [JsonProperty("UserId")]
        public int UserId
        {
            get;
            set;
        }

        [JsonProperty("handle")]
        public int Handle
        {
            get;
            set;
        }

        [JsonProperty("channel")]
        public int Channel
        {
            get;
            set;
        }

        [JsonProperty("viewFlag")]
        public int ViewFlag
        {
            get;
            set;
        }

        [JsonProperty("speed")]
        public int Speed
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

}
