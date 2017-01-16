using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Reflection;

namespace DevPF.Model
{
    public class ShouldSerializeContractResolver : DefaultContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);
            if (property.DeclaringType == typeof(DeviceClass))
            {
                property.ShouldSerialize = delegate(object Instance)
                {
                    DeviceClass deviceClass = (DeviceClass)Instance;
                    return !deviceClass.IgnoreProperties.Contains(property.PropertyName);
                };
            }
            if (property.DeclaringType == typeof(VideoClass))
            {
                property.ShouldSerialize = delegate(object Instance)
                {
                    VideoClass videoClass = (VideoClass)Instance;
                    return !videoClass.IgnoreProperties.Contains(property.PropertyName);
                };
            }
            return property;
        }
    }
}
