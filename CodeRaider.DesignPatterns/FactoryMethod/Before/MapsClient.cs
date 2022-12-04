using CodeRaider.DesignPatterns.FactoryMethod.After;

namespace CodeRaider.DesignPatterns.FactoryMethod.Before
{
    public class MapsClientBefore
    {
        public MapsClientBefore()
        {
            //client logic - load map, get user's current location
            //get the client's start and end location
            var start = new Location();
            var end = new Location();
            var availableTransport = GetAvailableTransportation(start, end);
        }

        public IList<ITransport> GetAvailableTransportation(ILocation start, ILocation destination)
        {
            var list = new List<ITransport>();
            list.Add(new Transport("Car", TransportCategory.Standard));

            if (IsDistanceWalkable(start, destination))
            {
                list.Add(new Transport("Walk", TransportCategory.Standard));
            }

            list.Add(new Transport("Bike", TransportCategory.Standard));

            if (GetHasSubwayAvailable(start) && GetHasSubwayAvailable(destination))
            {
                list.Add(new Transport("Subway", TransportCategory.Mass));
            }
            if (GetHasBusAvailable(start) && GetHasBusAvailable(destination))
            {
                list.Add(new Transport("Bus", TransportCategory.Mass));
            }

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

        private bool IsDistanceWalkable(ILocation start, ILocation destination)
        {
            //do some distance calculation
            //based on distance return true or false

            return true;
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
