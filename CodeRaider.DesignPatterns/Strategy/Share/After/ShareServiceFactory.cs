using CodeRaider.DesignPatterns.Strategy.Share.After.Strategies;
using CodeRaider.DesignPatterns.Strategy.Share.Models;

namespace CodeRaider.DesignPatterns.Strategy.Share.After
{
    public class ShareServiceFactory
    {

        private static Dictionary<ShareType, Type> RegisteredShareServices = new Dictionary<ShareType, Type>
        {
            { ShareType.Sms, typeof(SmsShareService) },
            { ShareType.Email, typeof(EmailShareService) },
            { ShareType.Instagram, typeof(InstagramShareService) },
            { ShareType.Facebook, typeof(FacebookShareService) },
        };

        public static IShareService CreateShareService(ShareType shareType)
        {
            if (!RegisteredShareServices.ContainsKey(shareType))
            {
                throw new ArgumentException("Share type not supported.");
            }
            else
            {
                var svc = Activator.CreateInstance(RegisteredShareServices[shareType]) as IShareService;
                if (svc == null)
                {
                    throw new Exception("Unable to instantiate Service.");
                }
                return svc;
            }

        }
    }
}
