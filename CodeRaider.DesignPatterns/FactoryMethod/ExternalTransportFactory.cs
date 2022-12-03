
namespace CodeRaider.DesignPatterns.FactoryMethod
{
    public class ExternalTransportFactory : BaseTransportFactory
    {
        public override List<ITransport> CreateTransport(ILocation start, ILocation destination)
        {
            var list = new List<ITransport>();

            //example logic
            if (GetHasLyftAvailable(start) && GetHasLyftAvailable(destination))
            {
                list.Add(new Transport("Lyft", TransportCategory.Mass));
            }
            if (GetHasUberAvailable(start) && GetHasUberAvailable(destination))
            {
                list.Add(new Transport("Uber", TransportCategory.Mass));
            }
            return list;
        }

        private bool GetHasLyftAvailable(ILocation location)
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

        private bool GetHasUberAvailable(ILocation location)
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
