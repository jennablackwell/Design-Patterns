
namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public class MassTransportFactory : BaseTransportFactory
    {
        public override List<ITransport> CreateTransport(ILocation start, ILocation destination)
        {
            var list = new List<ITransport>();

            //example logic
            if (GetHasSubwayAvailable(start) && GetHasSubwayAvailable(destination))
            {
                list.Add(new Transport("Subway", TransportCategory.Mass));
            }
            if (GetHasBusAvailable(start) && GetHasBusAvailable(destination))
            {
                list.Add(new Transport("Bus", TransportCategory.Mass));
            }
            return list;
        }

        private bool GetHasSubwayAvailable(ILocation location)
        {
            //just an over-simplified example.  in reality would probably call a service to do this check
            if (location.State == "Texas")
            {
                // dont really have subways in TX
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool GetHasBusAvailable(ILocation location)
        {
            //again an over simplified example
            if (location.City == "Orlando")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
