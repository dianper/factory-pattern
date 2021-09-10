namespace FactoryPattern.Factories
{
    using Properties;

    public class HotelFactory : PropertyFactory
    {
        public override Property GetProperty()
        {
            return new Hotel();
        }
    }
}
