namespace FactoryPattern.Properties
{
    using Models;

    public class Apartment : Property
    {
        public override Address GetAddress() => new Address
        {
            Street = "Av. da Republica, 2000",
            City = "Vila Nova de Gaia",
            State = "Porto",
            ZipCode = "4405-000",
            Country = "Portugal"
        };

        public override bool IsForSale() => false;
    }
}
