using CodeRaider.DesignPatterns.Helpers;

namespace CodeRaider.DesignPatterns.FactoryMethod.After
{
    public class MapsClientAfter
    {
        public MapsClientAfter()
        {
            //client logic - load map, get user's current location, etc.
            //get the client's start and end location
            var start = new Location() { City = "Houston", State = "Texas", Country = "USA"};
            var end = new Location() { City = "Houston", State = "Texas", Country = "USA" }; 
            var availableTransport = GetAvailableTransportation(start, end);
        }

        public IList<ITransport> GetAvailableTransportation(ILocation start, ILocation destination)
        {
            var transports = new List<ITransport>();

            try
            {
                //dynamically get all factories inheriting from BaseTransportFactory
                var factories = ReflectiveEnumerator.GetEnumerableOfType<BaseTransportFactory>();
                foreach (var factory in factories)
                {
                    transports.AddRange(factory.CreateTransportOptions(start, destination));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return transports;
        }

    }
}
