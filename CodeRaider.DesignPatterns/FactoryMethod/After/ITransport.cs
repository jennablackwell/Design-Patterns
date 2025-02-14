﻿namespace CodeRaider.DesignPatterns.FactoryMethod.After
{
    public interface ITransport
    {
        public string Name { get; set; }

        public TransportCategory TransportCategory { get; set; }

        IList<IRoute> GetRoutes(ILocation start, ILocation end);
    }
}
