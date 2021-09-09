namespace FactoryPattern
{
    using FactoryPattern.Factory;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PropertyFactory factory = default;

            Console.WriteLine("Choose an option to get property information:");
            Console.WriteLine("1 - Apartment");
            Console.WriteLine("2 - Flat");
            Console.WriteLine("3 - House");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    factory = new ApartmentFactory();
                    break;
                case "2":
                    factory = new FlatFactory();
                    break;
                case "3":
                    factory = new HouseFactory();
                    break;
                default:
                    break;
            }

            Console.WriteLine();

            if (factory != null)
            {
                var property = factory.GetProperty();
                var address = property.GetAddress();
                var isForSale = property.IsForSale() ? "Yes" : "No";

                Console.WriteLine("** Address **");
                Console.WriteLine($"Street: { address.Street }");
                Console.WriteLine($"City: { address.City }");
                Console.WriteLine($"State: { address.State }");
                Console.WriteLine($"ZipCode: { address.ZipCode }");
                Console.WriteLine($"Country: { address.Country }");
                Console.WriteLine();
                Console.WriteLine($"** For Sale: { isForSale } **");
            }
            else
            {
                Console.WriteLine("Unkown option!!");
            }

            Console.ReadKey();
        }
    }
}
