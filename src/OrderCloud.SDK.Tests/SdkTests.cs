using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using NUnit.Framework;
using Flurl.Http.Testing;
using Newtonsoft.Json;
using Flurl.Http;
using NUnit.Framework.Legacy;
using Assert = NUnit.Framework.Legacy.ClassicAssert;

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
		public async Task missing_bearer_token_obtains_new_token() {
			var cli = new OrderCloudClient(new OrderCloudClientConfig {
				ApiUrl = "https://fake.com",
				AuthUrl = "https://fake.com",
				ClientId = "client-id",
				ClientSecret = "client-secret",
			});

			using (var httpTest = new HttpTest())
			{
				_ = await cli.Me.GetAsync();
				httpTest
					.ShouldHaveCalled("https://fake.com/oauth/token")
					.WithoutHeader("Authorization");
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
		public void can_build_list_options_fluently_for_unary_expression() {
			
			var opts = new ListOptionsBuilder<Order>()
				.AddFilter(o => o.Status == OrderStatus.Unsubmitted)
				.Build();
			
			Assert.AreEqual(1, opts.Filters.Count);
			CollectionAssert.Contains(opts.Filters, new KeyValuePair<string, string>("Status", "0"));
		}

		[Test]
		public void can_build_list_options_fluently() {
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

		[Test]
		public void http_error_auth_exception_handled() {
			using var httpTest = new HttpTest();

			httpTest.RespondWith("<>", 502); // auth response with 500 level error code with response that could cause stackoverflow exception if it gets deserialized

			AsyncTestDelegate del = async () => await GetClient().Me.GetAsync(); // Will ThrowAuthExceptionAsync

			var response = Assert.ThrowsAsync<OrderCloudException>(del);
			Assert.NotNull(response);
			Assert.AreEqual(response.HttpStatus, HttpStatusCode.BadGateway);
		}

		[Test]
		public void http_error_api_exception_handled() {
			using var httpTest = new HttpTest();

			httpTest.RespondWith("{}"); // auth response
			httpTest.RespondWith("<>", 504); // api response that could cause stackoverflow exception if it gets deserialized

			AsyncTestDelegate del = async () => await GetClient().Me.GetAsync(); //Will ThrowApiExceptionAsync

			var response = Assert.ThrowsAsync<OrderCloudException>(del);
			Assert.NotNull(response);
			Assert.AreEqual(response.HttpStatus, HttpStatusCode.GatewayTimeout);
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

		private class CustomConfigData
		{
			public string Foo { get; set; }
			public int Bar { get; set; }
		}

		class CustomUser : User<CustomXP> { }
		class CustomAddress : Address<CustomXP> { }
		class CustomLineItem : LineItem<CustomXP, LineItemProduct, LineItemVariant, CustomAddress, CustomAddress> { }
		class CustomOrder : Order<CustomXP, CustomUser, CustomAddress> { }

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
