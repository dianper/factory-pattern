namespace FactoryPattern.Properties
{
    using Models;

    public class Flat : Property
    {
        public override Address GetAddress() => new Address
        {
            Street = "Beach Street",
            City = "Los Angeles",
            State = "California",
            ZipCode = "ACB 88",
            Country = "United States"
        };

        public override bool IsForSale() => true;
    }
}
