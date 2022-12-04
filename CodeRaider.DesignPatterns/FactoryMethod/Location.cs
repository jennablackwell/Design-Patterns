using CodeRaider.DesignPatterns.FactoryMethod.After;

namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public class Location : ILocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
    }
}
