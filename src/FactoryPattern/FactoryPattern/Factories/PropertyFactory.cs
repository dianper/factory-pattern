namespace FactoryPattern.Factories
{
    using Properties;

    public abstract class PropertyFactory
    {
        public abstract Property GetProperty();
    }
}
