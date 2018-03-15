using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace OrderCloud.SDK
{
	internal class OrderCloudContractResolver : DefaultContractResolver
	{
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) {
			var prop = base.CreateProperty(member, memberSerialization);
			// don't serialize properties with [ApiReadOnly]
			if (member.GetCustomAttribute(typeof(ApiReadOnlyAttribute)) != null)
				prop.Readable = false;
			return prop;
		}
	}
}