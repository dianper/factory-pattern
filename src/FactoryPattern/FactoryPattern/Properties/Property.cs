namespace FactoryPattern.Properties
{
    using FactoryPattern.Enum;
    using FactoryPattern.Models;

    public abstract class Property
    {
        public Address Address { get; set; }
        public Type Type { get; internal set; }
        public double UsefulArea { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int Year { get; set; }
        public bool IsForSale { get; set; }
    }
}
