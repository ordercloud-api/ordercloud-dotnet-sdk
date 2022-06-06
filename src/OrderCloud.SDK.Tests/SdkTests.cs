using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using NUnit.Framework;
using Flurl.Http.Testing;
using Newtonsoft.Json;

namespace OrderCloud.SDK.Tests
{
	[TestFixture]
	public class SdkTests
	{
		[Test]
		public void can_create_strongly_typed_xp() {
			var ba = new BuyerAddress<CustomXP> {
				xp = new CustomXP { Foo = "xyz", Bar = 123 }
			};
			JsonAssert.AreEquivalent(new { Foo = "xyz", Bar = 123 }, ba.xp);
		}

		[Test]
		public async Task can_get_strongly_typed_xp() {
			var ba = new {
				Items = new[] {
					new {
						xp = new { Foo = "abc", Bar = 123 },
						ShipFromAddress = new {
							xp = new { Foo = "xyz", Bar = 456 }
						}
					}
				}
			};

			using (var httpTest = new HttpTest()) {
				httpTest
					.RespondWith("{}") // auth
					.RespondWithJson(ba);

				var lineItems = await GetClient().LineItems.ListAsync<CustomLineItem>(OrderDirection.Incoming, "orderID");

				Assert.IsInstanceOf<ListPage<CustomLineItem>>(lineItems);
				Assert.IsInstanceOf<CustomLineItem>(lineItems.Items[0]);
				Assert.IsInstanceOf<Address<CustomXP>>(lineItems.Items[0].ShipFromAddress);
				Assert.AreEqual("abc", lineItems.Items[0].xp.Foo);
				Assert.AreEqual(123, lineItems.Items[0].xp.Bar);
				Assert.AreEqual("xyz", lineItems.Items[0].ShipFromAddress.xp.Foo);
				Assert.AreEqual(456, lineItems.Items[0].ShipFromAddress.xp.Bar);
			}
		}

		[Test]
		public void strongly_typed_props_backed_by_base_props() {
			void AssertLineItem(LineItem li) {
				Assert.IsNotNull(li.ShippingAddress);
				Assert.IsNotNull(li.ShippingAddress.xp);
				Assert.AreEqual("hello", li.ShippingAddress.xp.Foo);
			}

			var custom = new CustomLineItem {
				ShippingAddress = new CustomAddress {
					xp = new CustomXP { Foo = "hello" }
				}
			};
			AssertLineItem(custom);
		}

		[Test]
		public void can_serialize_partial() {
			// good test case - xp and a nested object
			var p = new PartialProduct {
				Name = "MyProduct",
				xp = new { foo = 1 },
				Description = "blah",
				Inventory = new PartialInventory {
					QuantityAvailable = 999
				}
			};

			JsonAssert.AreEquivalent(new {
				Name = "MyProduct",
				xp = new { foo = 1 },
				Description = "blah",
				Inventory = new { QuantityAvailable = 999 }
			}, p);

			// another good one - collection property
			var li = new PartialLineItem {
				ID = "id",
				Specs = new LineItemSpec[] {
					new PartialLineItemSpec { SpecID = "spec1", Value = "foo" },
					new PartialLineItemSpec { SpecID = "spec2", OptionID = "3" }
				}
			};

			JsonAssert.AreEquivalent(new {
				ID = "id",
				Specs = new object[] {
					new { SpecID = "spec1", Value = "foo" },
					new { SpecID = "spec2", OptionID = "3" }
				}
			}, li);
		}

		/// <summary>
		/// Support partial OrderCloud model deserialization.
		/// Primarily for partial xp where the intention is to reduce xp bloat in OrderCloud, while still enforcing data types in a strongly typed class.
		/// Complete OrderCloud models aren't necessarily expected to be deserialised as the OrderCloud API always returns the complete model,
		/// however the xp models share the same class and interface inheritance to support serialization/deserialization.
		/// </summary>
		[Test]
		public void can_deserialize_partial()
		{
			// Preparing an OrderCloud model that would be expected to be returned by the get product endpoint.
			var product = new Product<CustomPartialXP>
			{
				Name = "MyProduct",
				xp = new CustomPartialXP { Foo = "test" },
				Description = "blah",
				Inventory = new PartialInventory
				{
					QuantityAvailable = 999
				}
			};

			var serializedProduct = OrderCloudClient.Serializer.Serialize(product);
			var deserializedProduct = OrderCloudClient.Serializer.Deserialize<CustomPartialProduct<CustomPartialXP>>(serializedProduct);

			// As the complete model is deserialized, we expect to see all properties be assigned to the Props dictionary.
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.OwnerID)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.DefaultPriceScheduleID)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.AutoForward)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.ID)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.Name)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.Description)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.QuantityMultiplier)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.ShipWeight)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.ShipHeight)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.ShipWidth)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.ShipLength)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.Active)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.SpecCount)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.VariantCount)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.ShipFromAddressID)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.DefaultSupplierID)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.Returnable)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.Inventory)));
			Assert.IsNotNull(deserializedProduct.Props.ContainsKey(nameof(product.xp)));

			// All properties should be mapped, including default values.
			Assert.AreEqual(product.OwnerID, deserializedProduct.OwnerID);
			Assert.AreEqual(product.DefaultPriceScheduleID, deserializedProduct.DefaultPriceScheduleID);
			Assert.AreEqual(product.AutoForward, deserializedProduct.AutoForward);
			Assert.AreEqual(product.ID, deserializedProduct.ID);
			Assert.AreEqual(product.Name, deserializedProduct.Name);
			Assert.AreEqual(product.Description, deserializedProduct.Description);
			Assert.AreEqual(product.QuantityMultiplier, deserializedProduct.QuantityMultiplier);
			Assert.AreEqual(product.ShipWeight, deserializedProduct.ShipWeight);
			Assert.AreEqual(product.ShipHeight, deserializedProduct.ShipHeight);
			Assert.AreEqual(product.ShipWidth, deserializedProduct.ShipWidth);
			Assert.AreEqual(product.ShipLength, deserializedProduct.ShipLength);
			Assert.AreEqual(product.Active, deserializedProduct.Active);
			Assert.AreEqual(product.SpecCount, deserializedProduct.SpecCount);
			Assert.AreEqual(product.VariantCount, deserializedProduct.VariantCount);
			Assert.AreEqual(product.ShipFromAddressID, deserializedProduct.ShipFromAddressID);
			Assert.AreEqual(product.DefaultSupplierID, deserializedProduct.DefaultSupplierID);
			Assert.AreEqual(product.Returnable, deserializedProduct.Returnable);

			// We cannot deserialise a nested partial as the PartialProduct still specifies Inventory as the Inventory OrderCloud model,
			// however OrderCloud API responses return the full model, so this is more an FYI.
			//Assert.AreEqual(product.Inventory, deserializedProduct.Inventory);
			Assert.AreEqual(product.Inventory.QuantityAvailable, deserializedProduct.Inventory.QuantityAvailable);

			// The CustomPartialXP crudely overrides the Object.Equals method as an example, however unboxing the Props dictionary for equality checks may be something we wish to as a future enhancement.
			Assert.AreEqual(product.xp, deserializedProduct.xp);
			// Validating a handful
			Assert.IsTrue(deserializedProduct.xp is CustomPartialXP);
			Assert.AreEqual(1, deserializedProduct.xp.Props.Count, "Only the 'Foo' property should have been added to the Props dictionary.");
			Assert.AreEqual(product.xp.Props.Count, deserializedProduct.xp.Props.Count, "Only the 'Foo' property should have been added to the Props dictionary.");
			Assert.AreEqual(product.xp.Foo, deserializedProduct.xp.Foo);
			Assert.AreEqual(product.xp.Bar, deserializedProduct.xp.Bar);
		}

		[Test]
		public async Task can_provide_alternative_token() {
			// prove that auth credentials are no longer required like in earlier versions
			var cli = new OrderCloudClient(new OrderCloudClientConfig {
				ApiUrl = "https://fake.com",
				AuthUrl = "https://fake.com"
			});

			using (var httpTest = new HttpTest()) {
				var products = await cli.Me.ListProductsAsync(accessToken: "some-other-token");
				httpTest.ShouldHaveMadeACall().WithHeader("Authorization", "Bearer some-other-token");
			}
		}

		[Test]
		public void doesnt_serialize_api_readonly_properties() {
			var catalog = new Catalog { Description = "foo", CategoryCount = 99 };
			var json = OrderCloudClient.Serializer.Serialize(catalog);
			StringAssert.Contains("Description", json);
			StringAssert.Contains("foo", json);
			StringAssert.DoesNotContain("CategoryCount", json);
			StringAssert.DoesNotContain("99", json);
		}

		[Test]
		public void deserializes_api_readonly_properties() {
			var json = "{\"CategoryCount\":\"678\"}";
			var catalog = OrderCloudClient.Serializer.Deserialize<Catalog>(json);
			Assert.AreEqual(678, catalog.CategoryCount);
		}

		[Test]
		public void can_build_list_options_flluently() {
			int a = 10, b = 20;

			var opts = new ListOptionsBuilder<Product<CustomXP>>()
				.SearchFor("something")
				.SearchOn(p => p.Name, p => p.Description)
				.SortByReverse(p => p.Active)
				.SortBy(p => p.ID)
				.AddFilter(p => p.Active && !p.Inventory.Enabled && (p.xp.Foo == "*zing" || p.xp.Foo == "*zang" || p.xp.Foo == "*zong"))
				.AddFilter(p => p.VariantCount >= (a * 2) + b)
				.Page(5)
				.PageSize(100)
				.Build();

			Assert.AreEqual("something", opts.Search);
			Assert.AreEqual("Name,Description", opts.SearchOn);
			Assert.AreEqual("!Active,ID", opts.SortBy);
			Assert.AreEqual(4, opts.Filters.Count);
			CollectionAssert.Contains(opts.Filters, new KeyValuePair<string, string>("Active", "true"));
			CollectionAssert.Contains(opts.Filters, new KeyValuePair<string, string>("Inventory.Enabled", "!true"));
			CollectionAssert.Contains(opts.Filters, new KeyValuePair<string, string>("xp.Foo", "*zing|*zang|*zong"));
			CollectionAssert.Contains(opts.Filters, new KeyValuePair<string, string>("VariantCount", "!<40"));
			Assert.AreEqual(5, opts.Page);
			Assert.AreEqual(100, opts.PageSize);
		}

		[Test] // #31
		public void can_add_multiple_filters_same_key() {
			var expected = "https://fake.com/endpoint?QuantityMultiplier=%3E0&QuantityMultiplier=%3C10";

			var url = GetClient().Request("endpoint").SetListOptions<Product>(opts => opts
				.AddFilter(p => p.QuantityMultiplier > 0)
				.AddFilter(p => p.QuantityMultiplier < 10)).Url;

			Assert.AreEqual(expected, url.ToString());
		}

		[Test] // #24
		public async Task searchOn_and_sortBy_are_excluded_from_query_when_not_specified() {
			using (var httpTest = new HttpTest()) {
				httpTest.RespondWith("{}"); // auth

				await GetClient().Products.ListAsync(opts => opts.AddFilter(p => p.ID != "foo" && p.ID != "bar"));

				await GetClient().Products.ListAsync(opts => opts.SearchFor("something"));

				httpTest.ShouldHaveCalled("*/products")
					.WithVerb(HttpMethod.Get)
					.WithQueryParam("search", "something")
					.WithoutQueryParam("searchOn")
					.WithoutQueryParam("sortBy");
			}
		}

		[Test]
		public void invalid_filter_expressions_throw_useful_errors() {
			AssertInvalidExpression(o => 500 < o.Subtotal, FilterExpressionErrorMessages.LEFT_MUST_BE_PROPERTY);
			AssertInvalidExpression(o => o.ShippingCost + o.TaxCost > 100, FilterExpressionErrorMessages.LEFT_MUST_BE_PROPERTY);
			AssertInvalidExpression(o => Math.Round(o.ShippingCost, 0) == 6, FilterExpressionErrorMessages.LEFT_MUST_BE_PROPERTY);
			AssertInvalidExpression(o => o.ShippingCost == o.TaxCost, FilterExpressionErrorMessages.RIGHT_MUST_BE_VALUE);
			AssertInvalidExpression(o => o.ShippingCost == 6 || o.TaxCost == 6, FilterExpressionErrorMessages.UNSUPPORTED_OR_CLAUSE);
			AssertInvalidExpression(o => !(o.ShippingCost == 6 && o.TaxCost == 6), FilterExpressionErrorMessages.UNSUPPORTED_EXPRESSION);
		}

		private void AssertInvalidExpression(Expression<Func<Order, bool>> exp, string expectedMessage) {
			var builder = new ListOptionsBuilder<Order>();
			var ex = Assert.Throws<FilterExpressionException>(() => builder.AddFilter(exp));
			StringAssert.Contains(expectedMessage, ex.Message);
		}

		[Test]
		public void can_use_stronly_typed_webhook_payload() {
			var date = DateTimeOffset.UtcNow;

			var json = OrderCloudClient.Serializer.Serialize(new {
				Response = new { Body = new { DateSubmitted = date, xp = new { } } },
				RouteParams = new { Direction = "Incoming" },
				ConfigData = new { Foo = "bar" }
			});
			var payload = JsonConvert.DeserializeObject<WebhookPayloads.Orders.Submit<CustomConfigData, CustomOrder>>(json);

			Assert.AreEqual(date, payload.Response.Body.DateSubmitted);
			Assert.AreEqual(OrderDirection.Incoming, payload.RouteParams.Direction);
			Assert.AreEqual("bar", payload.ConfigData.Foo);
			Assert.IsAssignableFrom<CustomOrder>(payload.Response.Body);
			Assert.IsAssignableFrom<CustomXP>(payload.Response.Body.xp);
		}

		[Test]
		public void can_use_weakly_typed_webhook_payload() {
			var date = DateTimeOffset.UtcNow;

			var json = OrderCloudClient.Serializer.Serialize(new {
				Response = new { Body = new { DateSubmitted = date } },
				RouteParams = new { Direction = "Incoming" },
				ConfigData = new { Foo = "bar" }
			});
			var payload = JsonConvert.DeserializeObject<WebhookPayload>(json);

			Assert.AreEqual(date, (DateTimeOffset)payload.Response.Body.DateSubmitted);
			Assert.AreEqual(OrderDirection.Incoming, (OrderDirection)payload.RouteParams.Direction);
			Assert.AreEqual("bar", (string)payload.ConfigData.Foo);
		}

		[Test]
		public void can_use_strongly_typed_webhook_payload_with_weakly_typed_config_data() {
			var date = DateTimeOffset.UtcNow;

			var json = OrderCloudClient.Serializer.Serialize(new {
				Response = new { Body = new { DateSubmitted = date } },
				RouteParams = new { Direction = "Incoming" },
				ConfigData = new { Foo = "bar" }
			});
			var payload = JsonConvert.DeserializeObject<WebhookPayloads.Orders.Submit>(json);

			Assert.AreEqual(date, payload.Response.Body.DateSubmitted);
			Assert.AreEqual(OrderDirection.Incoming, payload.RouteParams.Direction);
			Assert.AreEqual("bar", (string)payload.ConfigData.Foo);
		}

		// OrderCloud.io sends empty bodies as empty objects in webhook payloads (#26)
		[TestCase("{ \"Request\": { \"Body\": {} }, \"Response\": { \"Body\": {} } }")]
		// but just in case, make sure null and empty string work too
		[TestCase("{ \"Request\": { \"Body\": null }, \"Response\": { \"Body\": null } }")]
		[TestCase("{ \"Request\": { \"Body\": \"\" }, \"Response\": { \"Body\": \"\" } }")]
		public void can_deserialize_empty_request_response_body_in_wehook_payload(string json) {
			var payload = JsonConvert.DeserializeObject<WebhookPayloads.Addresses.Delete>(json);
			Assert.IsNotNull(payload?.Request);
			Assert.IsNotNull(payload?.Response);
		}

		private OrderCloudClient GetClient() => new OrderCloudClient(new OrderCloudClientConfig {
			ApiUrl = "https://fake.com",
			AuthUrl = "https://fake.com",
			ClientId = "xyz",
			Username = "u",
			Password = "p"
		});

		private class CustomXP
		{
			public string Foo { get; set; }
			public int Bar { get; set; }
		}

		private class CustomPartialXP : OrderCloudModel, IPartial
		{
			public string Foo { get => GetProp<string>(nameof(Foo)); set => SetProp<string>(nameof(Foo), value); }
			public int Bar { get => GetProp<int>(nameof(Bar)); set => SetProp<int>(nameof(Bar), value); }

			// This is only included to unit test the xp comparison
			public override bool Equals(object xp)
			{
				if (!(xp is CustomPartialXP))
				{
					return false;
				}

				var that = xp as CustomPartialXP;

				if (this.Props.Count != that.Props.Count)
				{
					return false;
				}

				foreach (var pair in this.Props)
				{
					// We don't plan to unbox the Props, so this crude approach is just to demonstrate deserialising custom partial xp is possible.
					if (pair.Value.ToString() != that.Props[pair.Key].ToString())
					{
						return false;
					}
				}

				return this.Foo == that.Foo && this.Bar == that.Bar;
			}

			public override int GetHashCode()
			{
				throw new NotImplementedException();
			}
		}

		private class CustomConfigData
		{
			public string Foo { get; set; }
			public int Bar { get; set; }
		}

		class CustomUser : User<CustomXP> { }
		class CustomAddress : Address<CustomXP> { }
		class CustomLineItem : LineItem<CustomXP, LineItemProduct, LineItemVariant, CustomAddress, CustomAddress> { }
		class CustomOrder : Order<CustomXP, CustomUser, CustomAddress> { }
		class CustomPartialProduct : PartialProduct<CustomPartialXP> { }
		class CustomPartialProduct<Txp> : CustomPartialProduct {
			public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		}

		private static class JsonAssert
		{
			public static void AreEquivalent(object expected, object actual) {
				var j1 = OrderCloudClient.Serializer.Serialize(expected);
				var j2 = OrderCloudClient.Serializer.Serialize(actual);
				Assert.AreEqual(j1, j2);
			}
		}
	}
}
