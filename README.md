# OrderCloud.io SDK for .NET

[![OrderCloud.SDK](https://img.shields.io/nuget/v/OrderCloud.SDK.svg?maxAge=3600)](https://www.nuget.org/packages/OrderCloud.SDK/)

The OrderClould.io SDK for .NET is a client library for building solutions targeting the [OrderCloud.io](https://developer.ordercloud.io/documentation/) eCommerce platform using C# or other .NET language. Compared to accessing OrderCloud.io's REST API via direct HTTP calls, the SDK aims to greatly improve developer productivity and reduce errors by providing discoverable, strongly typed wrappers for all public endpoints and request/response models.

- [Example](#example)
- [Notable Features](#notable-features)
- [Supported Platforms](#supported-platforms)
- [Getting Help](#getting-help)

### Example
```c#
using OrderClould.SDK;

var client = new OrderCloudClient(new OrderCloudClientConfig {
    ClientId = "my-client-id",
    
    // client credentials grant flow:
    ClientSecret = "my-client-secret"
    
    // OR password grant flow:
    Username = u,
    Password = p,
    
    Roles = new[] { ApiRole.OrderAdmin }
});

var orders = await client.Orders.ListAsync(OrderDirection.Incoming, filters: new { Status = OrderStatus.Open });

Console.WriteLine($"{orders.Meta.TotalCount} open orders found.");
Console.WriteLine($"Fetched page {orders.Meta.Page} of {orders.Meta.TotalPages}.");
foreach (var order in orders.Items) {
    Console.WriteLine($"ID: {order.ID}, Total: {order.Total:C}");
}

```

### Notable Features
A few niceties that this SDK provides. Features of the OrderCloud.io _platform_ are documented [here](https://developer.ordercloud.io/documentation).

#### Strongly Typed xp
Extended Properties, or `xp`, is a platform feature that allows you to extend the OrderCloud.io data model. This is modeled in the SDK using (by default) a C# [dynamic](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/dynamic):

```c#
var user = new User();
user.xp.Gender = "male";
```

Even though `Gender` does not exist the native model, the code above will compile and work just fine with the API. But with dynamics you don't get compile-time type checking. If this is desired, the SDK gives you an alternative that works like this:

```c#
public class MyUserXp
{
    public string Gender { get; set; }
}

var user = new User<MyUserXp>()
user.xp.Gender = "male";
```

This time `Gender` is strongly typed, so you'll get the compile-time checking, Intellisense, and autocomplete you're used to with other properties. This is also available on calls that GET an object (or list):

```c#
var users = await client.Users.ListAsync<MyUserXp>(buyerId);
```

#### Strongly Typed Partials

OrderCloud.io supports PATCH endpoints that partially update a resource. The idea is that if you only send the fields you want to change, you not only reduce the payload, you might also avoid excessive GETs that could be needed if the entire model was required for an update. For example, here's how you might activate an inactive user:

```c#
await client.Users.PatchAsync(buyerId, userId, new PartialUser { Active = true });
```

`PartialUser` is type provided out of the box by the SDK (and similarly for all models with a corresponding PATCH endpoint). A couple things to note about `PartialUser`:

1. It has all the same strongly-typed properties as `User`; in fact, it inherits from `User`.

2. What makes it different from `User` is how it gets serialized to JSON when the the API call is made. Instead of serializing _all_ properties, it only serializes those that are _explicitly set_. (In this example, `{"Active":true}` is sent in the request body.) This behavior is important to understand - once you set a property, you cannot "remove" it, even by setting it to `null`, for example.

### Supported Platforms
The SDK targets [.NET Standard 1.3](https://docs.microsoft.com/en-us/dotnet/standard/net-standard), meaning it will run on .NET Framework/Mono 4.6 and above, .NET Core 1.0, Xamarin, and UWP 10.

### Getting Help
If you're new to OrderCloud.io, exploring the [documentation](https://developer.ordercloud.io/documentation) is recommended, specifically the [Intro to OrderCloud.io](https://developer.ordercloud.io/documentation/platform-guides/getting-started/introduction-to-ordercloud) and [Quick Start Guide](https://developer.ordercloud.io/documentation/platform-guides/getting-started/quick-start-guide). When you're ready to dive deeper, check out the [platform guides](https://developer.ordercloud.io/documentation/platform-guides) and [API reference](https://developer.ordercloud.io/documentation/api-reference).

For programming questions, please [ask](https://stackoverflow.com/questions/ask?tags=ordercloud) on Stack Overflow.

To report a bug, request a feature, or suggest a how-to guide specific to the SDK, please open an [issue](https://github.com/ordercloud-api/ordercloud-dotnet-sdk/issues/new). 
