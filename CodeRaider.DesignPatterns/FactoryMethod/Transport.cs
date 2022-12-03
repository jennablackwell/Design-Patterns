

namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public class Transport : ITransport
    {
        
        public string Name { get; set; }
        public TransportCategory TransportCategory { get; set; }

        public Transport(string name, TransportCategory category)
        {
            Name = name;
            TransportCategory = category;
        }

        public TimeSpan GetEstimatedArrival()
        {
            throw new NotImplementedException();
        }

        public IList<IRoute> GetRoutes()
        {
            throw new NotImplementedException();
        }
    }
}
