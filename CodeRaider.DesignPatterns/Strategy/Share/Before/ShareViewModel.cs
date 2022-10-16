using CodeRaider.DesignPatterns.Strategy.Share.Models;

namespace CodeRaider.DesignPatterns.Strategy.Share.Before
{
    public class ShareViewModel
    {

        public ShareViewModel()
        {

        }

        public void OnShareTypeSelected(ShareType shareType, PodcastEpisode episode)
        {
            try
            {
                if (shareType == ShareType.Email)
                {
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email
                    //code to share via email


                }
                else if (shareType == ShareType.Sms)
                {
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS
                    //code to share via SMS

                }
                else if (shareType == ShareType.Instagram)
                {
                    //code to share via instagram
                    //code to share via instagram
                    //code to share via instagram
                    //code to share via instagram
                    //code to share via instagram
                    //code to share via instagram
                    //code to share via instagram
                    //code to share via instagram
                    //code to share via instagram
                    //code to share via instagram


                }
                else if (shareType == ShareType.Facebook)
                {
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook
                    //code to share via Facebook

                }
                //etc.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
