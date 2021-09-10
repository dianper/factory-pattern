namespace FactoryPattern.Factories
{
    using Properties;

    public class HouseFactory : PropertyFactory
    {
        public override Property GetProperty()
        {
            return new House();
        }
    }
}
