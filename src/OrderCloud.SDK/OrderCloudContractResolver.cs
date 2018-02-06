using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OrderCloud.SDK
{
	/// <summary>
	/// Read-only properties still need to be set on deserialization. This allows Json.NET to use private setters.
	/// </summary>
	// http://stackoverflow.com/questions/4066947/private-setters-in-json-net
	internal class OrderCloudContractResolver : DefaultContractResolver
	{
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) {
			var prop = base.CreateProperty(member, memberSerialization);
			if (member is PropertyInfo pi) {
				prop.Readable = (pi.GetMethod != null);
				prop.Writable = (pi.SetMethod != null);
			}
			return prop;
		}
	}
}