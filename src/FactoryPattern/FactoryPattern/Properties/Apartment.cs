namespace FactoryPattern.Properties
{
    using FactoryPattern.Enum;

    public class Apartment : Property
    {
        public Apartment(bool isForSale = false)
        {
            this.IsForSale = isForSale;
            this.Type = Type.Apartment;
            this.CondominiumFees = 45;
            this.Floor = 8;
        }

        public decimal CondominiumFees { get; set; }
        public int Floor { get; set; }
    }
}
