using Mapster;
using MapsterDemo.Models;

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

Console.WriteLine(destination.Id);
Console.WriteLine(destination.Name);
Console.WriteLine(destination.CreatedAt);
Console.WriteLine(destination.Email);
Console.WriteLine(destination.IsActive);
Console.WriteLine(destination.PostalAddress.AddressLine1);
Console.WriteLine(destination.PostalAddress.AddressLine2);
Console.WriteLine(destination.PostalAddress.City);
Console.WriteLine(destination.PostalAddress.Country);
Console.WriteLine(destination.PostalAddress.State); 
Console.WriteLine(destination.PostalAddress.ZipCode);
Console.WriteLine(destination.PostalAddress.BillingAddress.AddressLine1);
