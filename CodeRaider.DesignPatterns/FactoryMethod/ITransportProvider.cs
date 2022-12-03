
namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public interface ITransportProvider
    {
        IList<ITransport> GetAvailableTransportation(ILocation start, ILocation end);
    }
}
