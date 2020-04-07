using System;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace OrderCloud.SDK
{
	/// <summary>
	/// For OrderCloudModels marked with IPartial, serialize the internal dictionary, which only contains keys/values for properties that were explicitly set.
	/// </summary>
	internal class PartialConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) =>
			JObject.FromObject(((OrderCloudModel)value).Props, serializer).WriteTo(writer);

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) =>
			throw new NotImplementedException();

		public override bool CanConvert(Type type) =>
			typeof(OrderCloudModel).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()) &&
			typeof(IPartial).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo());
	}

	/// <summary>
	/// Convert objects and JObjects to ExpandoObjects (main use case is xp)
	/// </summary>
	internal class DynamicConverter : ExpandoObjectConverter
	{
		public override bool CanConvert(Type objectType) {
			return
				objectType == typeof(object) ||
				objectType == typeof(JObject) ||
				base.CanConvert(objectType);
		}
	}
}
