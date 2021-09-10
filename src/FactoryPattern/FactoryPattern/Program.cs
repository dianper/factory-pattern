namespace FactoryPattern
{
    using FactoryPattern.Factories;
    using FactoryPattern.Properties;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PropertyFactory factory = default;

            Console.WriteLine("Choose an option to get property information:");
            Console.WriteLine("1 - Apartment");
            Console.WriteLine("2 - Hotel");
            Console.WriteLine("3 - House");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    factory = new ApartmentFactory();
                    break;
                case "2":
                    factory = new HotelFactory();
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
                Console.WriteLine($"This property is: {property.Type}");

                switch (property.Type)
                {
                    case Enum.Type.Hotel:
                        Console.WriteLine($"Does this hotel have a swimming pool? {((Hotel)property).HasPool}");
                        Console.WriteLine($"Does this hotel accept pets? {((Hotel)property).PetFriendly}");
                        break;
                    case Enum.Type.Apartment:
                        Console.WriteLine($"Which floor? {((Apartment)property).Floor}");
                        Console.WriteLine($"Condominium Fees? {((Apartment)property).CondominiumFees}");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Unkown option!!");
            }

            Console.ReadKey();
        }
    }
}
