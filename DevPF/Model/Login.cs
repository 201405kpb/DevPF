using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraRichEdit.API.Word;

namespace DevPF.Model
{
    public class UserLogin : IBase
    {
        [JsonProperty("username")]
        public string UserName
        {
            get;
            set;
        }

        [JsonProperty("password")]
        public string PassWord
        {
            get;
            set;
        }

        public override string ToString()
        {
            return UserName;
        }
    }

    public class ClientLogin
    {
        private List<UserLogin> _userLogins; 
        public bool RemberUser { get; set; }

        public bool RemberPassword { get; set; }

        public List<UserLogin> UserLogins
        {
            get { return _userLogins ?? (_userLogins = new List<UserLogin>()); }
            set { _userLogins = value; } }

        public UserLogin ContainLogion(string username)
        {
            UserLogin userLogin = (from p in UserLogins where p.UserName == username select p).FirstOrDefault() ??
                                  new UserLogin();
            return userLogin;
        }
    }

    public class VideoLogin : UserLogin, IFlagBase
    {
        [JsonProperty("ip")]
        public string IpStr
        {
            get;
            set;
        }

        [JsonProperty("port")]
        public string Port
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
    }
}
