namespace FactoryPattern.Factories
{
    using Properties;

    public class ApartmentFactory : PropertyFactory
    {
        public override Property GetProperty()
        {
            return new Apartment();
        }
    }
}
