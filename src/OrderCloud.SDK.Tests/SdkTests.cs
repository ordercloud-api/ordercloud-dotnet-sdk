using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Flurl.Http.Testing;

namespace OrderCloud.SDK.Tests
{
	[TestFixture]
	public class SdkTests
	{
		[Test]
		public async Task can_have_strongly_typed_xp() {
			var ba = new BuyerAddress<CustomXP> {
				xp = new CustomXP { Foo = "xyz", Bar = 123 }
			};
			JsonAssert.AreEquivalent(new { Foo = "xyz", Bar = 123 }, ba.xp);

			using (var httpTest = new HttpTest()) {
				httpTest
					.RespondWith("{}") // auth
					.RespondWithJson(ba);

				var get = await GetClient().Me.GetAddressAsync<CustomXP>("id");

				Assert.IsInstanceOf<BuyerAddress<CustomXP>>(get);
				Assert.AreEqual("xyz", get.xp.Foo);
				Assert.AreEqual(123, get.xp.Bar);
			}
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
				var products = await GetClient().Me.ListProductsAsync(accessToken: "some-other-token");
				httpTest.ShouldHaveMadeACall().WithHeader("Authorization", "Bearer some-other-token");
			}
		}

		[Test]
		public void can_build_list_options() {
			int a = 10, b = 20;

			var opts = new ListOptionsBuilder<Product<CustomXP>>()
				.SearchFor("something")
				.SearchOn(p => p.Name, p => p.Description)
				.SortByReverse(p => p.Active)
				.SortBy(p => p.ID)
				.AddFilter(p => p.Active && !p.Inventory.Enabled && (p.xp.Foo == "*zing" || p.xp.Foo == "*zang" || p.xp.Foo == "*zong") && p.VariantCount >= (a * 2) + b)
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
