# OrderCloud.io SDK for .NET

The OrderClould.io SDK for .NET is a client library for building solutions targeting the OrderCloud.io eCommerce platform using C# or other .NET language. Compared to accessing OrderCloud.io's REST API via direct HTTP calls, the SDK aims to greatly improve developer productivity and reduce errors by providing discoverable, strongly typed wrappers for all public endpoints and request/response models.

## Example

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

