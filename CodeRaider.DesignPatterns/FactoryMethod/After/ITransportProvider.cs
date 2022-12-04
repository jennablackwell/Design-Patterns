namespace CodeRaider.DesignPatterns.FactoryMethod.After
{
    public interface ITransportProvider
    {
        IList<ITransport> GetAvailableTransportation(ILocation start, ILocation end);
    }
}
