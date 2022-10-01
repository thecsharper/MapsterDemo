using Xunit;
using FluentAssertions;

using MapsterDemo;
using FluentAssertions.Extensions;

namespace MapsterDemoTests
{
    [Trait("Category", "Mapping")]
    public class MapsterTests
    {
        [Fact]
        public void ObjectMap_Test()
        {
            var destination = new MapsterMap().MapTypes();

            destination!.Id.Should().Be(1);
            destination.Name.Should().Be("Test Name");
            DateTime.TryParse(destination.CreatedAt, out DateTime dt);
            dt.Should().BeCloseTo(DateTime.UtcNow, 3.Seconds());
            destination.Email.Should().Be("test@test.com");
            destination.IsActive.Should().BeTrue();
            destination.PostalAddress!.AddressLine1.Should().Be("AddressLine1");
            destination.PostalAddress.AddressLine2.Should().Be("AddressLine2");
            destination.PostalAddress.City.Should().Be("City");
            destination.PostalAddress.Country.Should().Be("Country");
            destination.PostalAddress.State.Should().Be("State");
            destination.PostalAddress.ZipCode.Should().Be("ZipCode");
            destination.PostalAddress.BillingAddress!.AddressLine1.Should().Be("Billing1");
        }
    }
}