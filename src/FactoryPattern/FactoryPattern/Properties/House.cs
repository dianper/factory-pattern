namespace FactoryPattern.Properties
{
    using FactoryPattern.Enum;

    public class House : Property
    {
        public House(bool isForSale = false)
        {
            this.IsForSale = isForSale;
            this.Type = Type.House;
        }
    }
}
