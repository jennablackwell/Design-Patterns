namespace CodeRaider.DesignPatterns.FactoryMethod.After
{
    public class StandardTransportFactory : BaseTransportFactory
    {
        public override List<ITransport> CreateTransportOptions(ILocation start, ILocation destination)
        {
            var list = new List<ITransport>();
            list.Add(new Transport("Car", TransportCategory.Standard));

            if (IsDistanceWalkable(start, destination))
            {
                list.Add(new Transport("Walk", TransportCategory.Standard));
            }

            list.Add(new Transport("Bike", TransportCategory.Standard));

            return list;
        }

        private bool IsDistanceWalkable(ILocation start, ILocation destination)
        {
            //do some distance calculation
            //based on distance return true or false

            return true;
        }
    }
}
