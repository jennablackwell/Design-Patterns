using CodeRaider.DesignPatterns.Strategy.Share.Models;

namespace CodeRaider.DesignPatterns.Strategy.Share.After.Strategies
{
    public interface IShareService
    {
        void Share(PodcastEpisode episode);
    }
}
