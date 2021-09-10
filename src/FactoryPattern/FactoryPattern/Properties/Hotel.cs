namespace FactoryPattern.Properties
{
    using FactoryPattern.Enum;

    public class Hotel : Property
    {
        public Hotel(bool isForSale = false)
        {
            this.IsForSale = isForSale;
            this.Type = Type.Hotel;
            this.HasPool = true;
            this.PetFriendly = true;
        }

        public bool HasPool { get; set; }
        public bool PetFriendly { get; set; }
    }
}
