using Mapster;
using MapsterDemo.Models;

namespace MapsterDemo
{
    public class MapsterMap
    {
        public static ModelDTO? MapTypes()
        {
            TypeAdapterConfig<Model, ModelDTO>
                .NewConfig()
                .Map(dest => dest.PostalAddress, src => src.Address);

            var source = new Model
            {
                Id = 1,
                Name = "Test Name",
                Email = "test@test.com",
                CreatedAt = DateTime.UtcNow,
                IsActive = true,
                Address = new Address()
                {
                    AddressLine1 = "AddressLine1",
                    AddressLine2 = "AddressLine2",
                    City = "City",
                    Country = "Country",
                    State = "State",
                    ZipCode = "ZipCode",
                    BillingAddress = new Address()
                    {
                        AddressLine1 = "Billing1",
                    }
                }
            };

            var destination = source.Adapt<ModelDTO>();

            return destination;
        }
    }
}
