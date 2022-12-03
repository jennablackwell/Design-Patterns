

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

        public IList<IRoute> GetRoutes(ILocation start, ILocation end)
        {
            throw new NotImplementedException();
        }
    }
}
