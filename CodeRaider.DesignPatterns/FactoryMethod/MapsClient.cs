
namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public class MapsClient2
    {
        public void GetAvailableTransportation(ILocation start, ILocation destination)
        {
            var factory = new StandardTransportFactory();
            var availableTransportation = factory.CreateTransport(start, destination); 
        }
      
    }
}
