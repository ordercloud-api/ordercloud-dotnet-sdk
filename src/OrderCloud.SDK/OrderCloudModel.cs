using System;
using System.Collections.Generic;

namespace OrderCloud.SDK
{
	/// <summary>
	/// A marker interface used on OrderCloud models to indicate that only explicitly set properties should be serialized.
	/// </summary>
	public interface IPartial { }

	/// <summary>
	/// Abstract base class for models passed in request and response bodies of the OrderCloud API. Supports serializing
	/// only properties that are explicitly set, when class is marked with IPartial interface.
	/// </summary>
	public abstract class OrderCloudModel
	{
		internal Dictionary<string, object> Props { get; set; } = new Dictionary<string, object>();

		/// <summary>
		/// Get a property value by name.
		/// </summary>
		protected T GetProp<T>(string name) => Props.TryGetValue(name, out object value) ? (T)value : default(T);

		/// <summary>
		/// Get a property value by name, and provide a default value if the property hasn't been explicitly set.
		/// </summary>
		protected T GetProp<T>(string name, T defaultValue) {
			if (Props.TryGetValue(name, out object value))
				return (T)value;

			if (this is IPartial)
				return default(T);
			else  {
				SetProp(name, defaultValue);
				return defaultValue;
			}
		}

		/// <summary>
		/// Set a property value by name.
		/// </summary>
		protected void SetProp<T>(string name, T value) => Props[name] = value;
	}

	/// <summary>
	/// Marker interface for required model properties.
	/// </summary>
	// Using .NET's RequiredAttribute would require taking a dependency on System.ComponentModel.DataAnnotations (out of band). Doesn't seem worth it.
	public class RequiredAttribute : Attribute { }

	/// <summary>
	/// Marker interface for properties that are received on GET but cannot be written to on POST/PUT/PATCH. (OrderCloud.io will ignore them if sent.)
	/// </summary>
	public class ApiReadOnlyAttribute : Attribute { }
}
