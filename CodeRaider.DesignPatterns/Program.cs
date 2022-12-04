// See https://aka.ms/new-console-template for more information
using CodeRaider.DesignPatterns.FactoryMethod.After;
using CodeRaider.DesignPatterns.Strategy.Share.After;
using CodeRaider.DesignPatterns.Strategy.Share.Models;

Console.WriteLine("Hello, World!");

//var shareViewModel = new ShareViewModel();
//Console.WriteLine("SMS share selected by user");
//shareViewModel.OnShareTypeSelected(ShareType.Sms, new PodcastEpisode() { Author = "Code Raider", Id = 1, Name = "Dev Tips Episode 1" });
//Console.WriteLine("Success");


var mapClient = new MapsClientAfter();