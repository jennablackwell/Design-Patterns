
namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public abstract class BaseTransportFactory
    {
        public abstract List<ITransport> CreateTransport(ILocation start, ILocation destination);
    }
}
