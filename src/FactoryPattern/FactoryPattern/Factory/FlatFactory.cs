namespace FactoryPattern.Factory
{
    using Properties;

    public class FlatFactory : PropertyFactory
    {
        public override Property GetProperty()
        {
            return new Flat();
        }
    }
}
