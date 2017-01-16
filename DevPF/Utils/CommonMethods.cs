using DevPF.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DevPF.Utils
{
    public class CommonMethods
    {
        public static ResultClass<string> Login(string username, string password)
        {
           
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("用户名为空！");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("密码为空！");
            }
            UserLogin userLogin = new UserLogin
            {
                UserName = username,
                PassWord = password
            };
            object result = WsHelper.InvokeWebService( MethodConstants.BASEURL, "UserLogin", new object[]
			{
				JsonConvert.SerializeObject(userLogin)
			});
            return JsonConvert.DeserializeObject<ResultClass<string>>(result.ToString());
        }

        public static ResultClass<string> SendReceiveInfo(string Content)
        {
            if (string.IsNullOrEmpty(Content))
            {
                throw new Exception("发送内容为空");
            }
            SendReceive sendReceive = new SendReceive
            {
                Content = Content
            };
            object result = WsHelper.InvokeWebService( MethodConstants.UIMURL, "SendReceive", new object[]
			{
				JsonConvert.SerializeObject(sendReceive)
			});
            return JsonConvert.DeserializeObject<ResultClass<string>>(result.ToString());
        }

        public static ResultClass<List<int>> SearchDeviceInfo()
        {
            SearchDevice searchDevice = new SearchDevice();
            object result = WsHelper.InvokeWebService( MethodConstants.UIMURL, "SearchDevice", new object[]
			{
				JsonConvert.SerializeObject(searchDevice)
			});
            return JsonConvert.DeserializeObject<ResultClass<List<int>>>(result.ToString());
        }

        public static ResultClass<DeviceClassResult> ConnectDeviceInfo(int device, int flag)
        {
            DeviceClass deviceClass = new DeviceClass
            {
                Device = device,
                Flag = flag
            };
            Type type = deviceClass.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                object ob = propertyInfo.GetValue(deviceClass);
                if (ob == null)
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
                else if (string.IsNullOrEmpty(ob.ToString()))
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
            }
            object result = WsHelper.InvokeWebService( MethodConstants.UIMURL, "ConnectDevice", new object[]
			{
				JsonConvert.SerializeObject(deviceClass)
			});
            return JsonConvert.DeserializeObject<ResultClass<DeviceClassResult>>(result.ToString());
        }

        public static ResultClass<List<DeviceClassResult>> GREGInfo(int device)
        {
            DeviceClass deviceClass = new DeviceClass
            {
                Device = device
            };
            Type type = deviceClass.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                object ob = propertyInfo.GetValue(deviceClass);
                if (ob == null)
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
                else if (string.IsNullOrEmpty(ob.ToString()))
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
            }
            object result = WsHelper.InvokeWebService( MethodConstants.UIMURL, "GREG", new object[]
			{
				JsonConvert.SerializeObject(deviceClass)
			});
            return JsonConvert.DeserializeObject<ResultClass<List<DeviceClassResult>>>(result.ToString());
        }

        public static ResultClass<DeviceClassResult> ENAInfo(int siteid, SiteEnum siteEnum)
        {
            DeviceClass deviceClass = new DeviceClass
            {
                Device = siteid
            };
            Type type = deviceClass.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                object ob = propertyInfo.GetValue(deviceClass);
                if (ob == null)
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
                else if (string.IsNullOrEmpty(ob.ToString()))
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
            }
            string strmethod = "ENA";
            if (siteEnum == SiteEnum.ENA)
            {
                strmethod = "ENA";
            }
            else if (siteEnum == SiteEnum.OFF)
            {
                strmethod = "OFF";
            }
            object result = WsHelper.InvokeWebService( MethodConstants.UIMURL, strmethod, new object[]
			{
				JsonConvert.SerializeObject(deviceClass)
			});
            return JsonConvert.DeserializeObject<ResultClass<DeviceClassResult>>(result.ToString());
        }

        public static ResultClass<DeviceClassResult> ORGInfo(int device, int siteid, ORGORFBK orgorfbk)
        {
            DeviceClass deviceClass = new DeviceClass
            {
                Device = device,
                SiteId = siteid
            };
            Type type = deviceClass.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                object ob = propertyInfo.GetValue(deviceClass);
                if (ob == null)
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
                else if (string.IsNullOrEmpty(ob.ToString()))
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
            }
            string strmethod = "ORG";
            if (orgorfbk == ORGORFBK.ORG)
            {
                strmethod = "ORG";
            }
            else if (orgorfbk == ORGORFBK.FBK)
            {
                strmethod = "FBK";
            }
            object result = WsHelper.InvokeWebService( MethodConstants.UIMURL, strmethod, new object[]
			{
				JsonConvert.SerializeObject(deviceClass)
			});
            return JsonConvert.DeserializeObject<ResultClass<DeviceClassResult>>(result.ToString());
        }

        public static ResultClass<DeviceClassResult> SetSPDInfo(int device, int siteid, int value, SetEnum setEnum)
        {
            DeviceClass deviceClass = new DeviceClass
            {
                Device = device,
                SiteId = siteid,
                Value = value
            };
            string strmethod = "SetSPD";
            switch (setEnum)
            {
                case SetEnum.SPD:
                    strmethod = "SetSPD";
                    break;
                case SetEnum.STP:
                    strmethod = "SetSTP";
                    break;
                case SetEnum.POS:
                    strmethod = "SetPOS";
                    break;
                case SetEnum.QEC:
                    strmethod = "SetQEC";
                    break;
            }
            Type type = deviceClass.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                object ob = propertyInfo.GetValue(deviceClass);
                if (ob == null)
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
                else if (string.IsNullOrEmpty(ob.ToString()))
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
            }
            object result = WsHelper.InvokeWebService( MethodConstants.UIMURL, strmethod, new object[]
			{
				JsonConvert.SerializeObject(deviceClass)
			});
            return JsonConvert.DeserializeObject<ResultClass<DeviceClassResult>>(result.ToString());
        }

        public static ResultClass<string> QuerySPDInfo(int device, int siteid, QueryEnum queryEnum)
        {
            DeviceClass deviceClass = new DeviceClass
            {
                Device = device,
                SiteId = siteid
            };
            Type type = deviceClass.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                object ob = propertyInfo.GetValue(deviceClass);
                if (ob == null)
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
                else if (string.IsNullOrEmpty(ob.ToString()))
                {
                    deviceClass.IgnoreProperties.Add(propertyInfo.Name);
                }
            }
            string strmethod = "SetSPD";
            switch (queryEnum)
            {
                case QueryEnum.SPD:
                    strmethod = "SetSPD";
                    break;
                case QueryEnum.STP:
                    strmethod = "SetSTP";
                    break;
                case QueryEnum.POS:
                    strmethod = "SetPOS";
                    break;
                case QueryEnum.QEC:
                    strmethod = "SetQEC";
                    break;
            }
            object result = WsHelper.InvokeWebService( MethodConstants.UIMURL, strmethod, new object[]
			{
				JsonConvert.SerializeObject(deviceClass)
			});
            return JsonConvert.DeserializeObject<ResultClass<string>>(result.ToString());
        }

        public static ResultClass<int> VideoLogionInfo(string username, string password, string ip, string port, int flag)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("用户名为空！");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("密码 为空");
            }
            if (string.IsNullOrEmpty(ip))
            {
                throw new Exception("IP 为空！");
            }
            if (string.IsNullOrEmpty(port))
            {
                throw new Exception("端口号 为空");
            }
            VideoLogin videoLogin = new VideoLogin
            {
                UserName = username,
                PassWord = password,
                IpStr = ip,
                Port = port,
                Flag = flag
            };
            object result = WsHelper.InvokeWebService( MethodConstants.BASEURL, "VideoLogin", new object[]
			{
				JsonConvert.SerializeObject(videoLogin)
			});
            return JsonConvert.DeserializeObject<ResultClass<int>>(result.ToString());
        }

        public static ResultClass<string> PreviewInfo(int userid, int handle, int channel, int flag, VideoEnum videoEnum)
        {
            VideoClass video = new VideoClass
            {
                UserId = userid,
                Handle = handle,
                Channel = channel,
                Flag = flag
            };
            Type type = video.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                object ob = propertyInfo.GetValue(video);
                if (ob == null)
                {
                    video.IgnoreProperties.Add(propertyInfo.Name);
                }
                else if (string.IsNullOrEmpty(ob.ToString()))
                {
                    video.IgnoreProperties.Add(propertyInfo.Name);
                }
            }
            string strmethod = "Preview";
            switch (videoEnum)
            {
                case VideoEnum.PREVIEW:
                    strmethod = "Preview";
                    break;
                case VideoEnum.CAPTUREJPG:
                    strmethod = "CaptureJPG";
                    break;
                case VideoEnum.RECORD:
                    strmethod = "Record";
                    break;
            }
            object result = WsHelper.InvokeWebService( MethodConstants.BASEURL, strmethod, new object[]
			{
				JsonConvert.SerializeObject(video)
			});
            return JsonConvert.DeserializeObject<ResultClass<string>>(result.ToString());
        }

        public static ResultClass<string> TurnInfo(int userid, int handle, int channel, int flag, int viewflag, int speed, TurnEnum turntype)
        {
            VideoClass video = new VideoClass
            {
                UserId = userid,
                Handle = handle,
                Channel = channel,
                Flag = flag,
                ViewFlag = viewflag,
                Speed = speed
            };
            Type type = video.GetType();
            PropertyInfo[] properties = type.GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                object ob = propertyInfo.GetValue(video);
                if (ob == null)
                {
                    video.IgnoreProperties.Add(propertyInfo.Name);
                }
                else if (string.IsNullOrEmpty(ob.ToString()))
                {
                    video.IgnoreProperties.Add(propertyInfo.Name);
                }
            }
            string menthodstr = "TurnUp";
            switch (turntype)
            {
                case TurnEnum.UP:
                    menthodstr = "TurnUp";
                    break;
                case TurnEnum.DOWN:
                    menthodstr = "TurnDown";
                    break;
                case TurnEnum.LEFT:
                    menthodstr = "TurnLeft";
                    break;
                case TurnEnum.RIGHT:
                    menthodstr = "TurnRight";
                    break;
                case TurnEnum.AUTO:
                    menthodstr = "TurnAuto";
                    break;
            }
            object result = WsHelper.InvokeWebService( MethodConstants.BASEURL, menthodstr, new object[]
			{
				JsonConvert.SerializeObject(video)
			});
            return JsonConvert.DeserializeObject<ResultClass<string>>(result.ToString());
        }
    }

    public enum ORGORFBK
    {
        ORG,
        FBK
    }
    public enum QueryEnum
    {
        SPD,
        STP,
        POS,
        QEC
    }

    public enum SetEnum
    {
        SPD,
        STP,
        POS,
        QEC
    }

    public enum SiteEnum
    {
        ENA,
        OFF
    }

    public enum TurnEnum
    {
        UP,
        DOWN,
        LEFT,
        RIGHT,
        AUTO
    }
    public enum VideoEnum
    {
        PREVIEW,
        CAPTUREJPG,
        RECORD
    }
}
