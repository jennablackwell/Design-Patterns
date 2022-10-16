namespace CodeRaider.DesignPatterns.Strategy.Share.Models
{
    public class PodcastEpisode
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Author { get; set; }

        public DateTime PublishDate { get; set; }

        public PodcastEpisode()
        {
            PublishDate = DateTime.Now;
        }
    }
}
