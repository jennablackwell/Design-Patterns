﻿using CodeRaider.DesignPatterns.Strategy.Share.Models;

namespace CodeRaider.DesignPatterns.Strategy.Share.After.Strategies
{
    public class SmsShareService : IShareService
    {
        public void Share(PodcastEpisode episode)
        {
            //share code here
            Console.WriteLine("Podcast shared via SmsShareService");

        }
    }
}
