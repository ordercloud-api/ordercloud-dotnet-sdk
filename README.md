# OrderCloud.io SDK for .NET

[![Flurl](https://img.shields.io/nuget/v/OrderCloud.SDK.svg?maxAge=3600)](https://www.nuget.org/packages/OrderCloud.SDK/)

The OrderClould.io SDK for .NET is a client library for building solutions targeting the [OrderCloud.io](https://developer.ordercloud.io/documentation/) eCommerce platform using C# or other .NET language. Compared to accessing OrderCloud.io's REST API via direct HTTP calls, the SDK aims to greatly improve developer productivity and reduce errors by providing discoverable, strongly typed wrappers for all public endpoints and request/response models.

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

### Supported Platforms
The SDK targets [.NET Standard 1.3](https://docs.microsoft.com/en-us/dotnet/standard/net-standard), meaning it will run on .NET Framework/Mono 4.6 and above, .NET Core 1.0, Xamarin, and UWP 10.

### Getting Help
If you're new to OrderCloud.io, exploring the [documentation](https://developer.ordercloud.io/documentation) is recommended, specifically the [Intro to OrderCloud.io](https://developer.ordercloud.io/documentation/platform-guides/getting-started/introduction-to-ordercloud) and [Quick Start Guide](https://developer.ordercloud.io/documentation/platform-guides/getting-started/quick-start-guide). When you're ready to dive deeper, check out the [platform guides](https://developer.ordercloud.io/documentation/platform-guides) and [API reference](https://developer.ordercloud.io/documentation/api-reference).

For programming questions, please [ask](https://stackoverflow.com/questions/ask?tags=ordercloud) on Stack Overflow.

To report a bug, request a feature, or suggest a how-to guide specific to the SDK, please open an [issue](https://github.com/ordercloud-api/ordercloud-dotnet-sdk/issues/new). 
