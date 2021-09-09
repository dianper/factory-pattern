namespace FactoryPattern.Properties
{
    using Models;

    public abstract class Property
    {
        public abstract Address GetAddress();
        public abstract bool IsForSale();
    }
}
