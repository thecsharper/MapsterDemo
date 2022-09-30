using MapsterDemo;

var destination = new MapsterMap().MapTypes();

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