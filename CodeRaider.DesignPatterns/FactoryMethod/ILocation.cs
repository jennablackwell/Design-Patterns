namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public interface ILocation
    {
        double Latitude { get; set; }
        double Longitude { get; set; }

        string City { get; set; }
        string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

    }
}
