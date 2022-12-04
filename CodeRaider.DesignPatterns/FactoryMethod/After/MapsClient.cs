namespace CodeRaider.DesignPatterns.FactoryMethod.After
{
    public class MapsClientAfter
    {
        public MapsClientAfter()
        {
            //client logic - load map, get user's current location, etc.
            //get the client's start and end location
            var start = new Location();
            var end = new Location();
            var availableTransport = GetAvailableTransportation(start, end);
        }

        public IList<ITransport> GetAvailableTransportation(ILocation start, ILocation destination)
        {
            var transports = new List<ITransport>();
            var factory = new StandardTransportFactory();
            var standard = factory.CreateTransportOptions(start, destination);
            //in the future could dynamically load all factories dynamically via reflection
            //inheriting from BaseTransportFactory to get all transport categories
            transports.AddRange(standard);
            return transports;
        }

    }
}
