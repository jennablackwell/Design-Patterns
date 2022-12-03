
namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public abstract class BaseTransportFactory
    {
        public abstract List<ITransport> CreateTransportOptions(ILocation start, ILocation destination);
    }
}
