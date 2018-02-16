using System;
using System.Collections.Generic;
using System.Linq;
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
