using CodeRaider.DesignPatterns.Strategy.Share.Models;

namespace CodeRaider.DesignPatterns.Strategy.Share.After
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
                var shareService = ShareServiceFactory.CreateShareService(shareType);
                shareService.Share(episode);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}
