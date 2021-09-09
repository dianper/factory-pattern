namespace FactoryPattern.Properties
{
    using Models;

    public class House : Property
    {
        public override Address GetAddress() => new Address
        {
            Street = "Av. Paulista, 1000",
            City = "São Paulo",
            State = "São Paulo",
            ZipCode = "04563-963",
            Country = "Brazil"
        };

        public override bool IsForSale() => false;
    }
}
