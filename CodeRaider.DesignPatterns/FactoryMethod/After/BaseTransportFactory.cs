namespace CodeRaider.DesignPatterns.FactoryMethod.After
{
    public abstract class BaseTransportFactory
    {
        public abstract List<ITransport> CreateTransportOptions(ILocation start, ILocation destination);
    }
}
