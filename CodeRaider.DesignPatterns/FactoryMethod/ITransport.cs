
namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public interface ITransport
    {
        public string Name { get; set; }

        public TransportCategory TransportCategory { get; set; }

        TimeSpan GetEstimatedArrival();

        IList<IRoute> GetRoutes();
    }
}
