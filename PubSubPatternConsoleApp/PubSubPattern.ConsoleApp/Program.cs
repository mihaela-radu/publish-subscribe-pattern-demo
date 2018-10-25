using PubSubPattern.Logic;
using System;
using System.Linq;
using PubSubPattern.Logic.Interfaces;
using SimpleInjector;

namespace PubSubPattern.ConsoleApp
{
    class Program
    {
        private static readonly Container Container;
        static Program()
        {
            Container = new Container();

            Container.Register<ISportDataPublisher, SportDataPublisher>();
            Container.Register<IFootbalMatchDataProcessor, FootbalMatchDataProcessor>();

            Container.Verify();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Welcome to the publisher-subscribe pattern demo app. This demo is built around a sports data broadcasting example.");
            Console.WriteLine(
                "Please enter a test football match result in this format: [home team name],[away team name],[final score]");
            var rawMatchData = Console.ReadLine();

            var dataProcessor = Container.GetInstance<IFootbalMatchDataProcessor>();
            var match = dataProcessor.ProcessRawData(rawMatchData);          

            var fan1 = new SportDataSubscriber("Sports Fan #1");
            var fan2 = new SportDataSubscriber("Sports Fan #2");

            var publisher = Container.GetInstance<ISportDataPublisher>();

            publisher.AttachEvent(fan1);
            publisher.AttachEvent(fan2);

            Console.WriteLine("{0}-{1} match completed with score {2}, broadcasting results..", match.HomeTeamName, match.AwayTeamName, match.FinalScore);
            publisher.Broadcast(match);

            //Console.WriteLine("{0} received the match result for {1} vs {2}: {3}", fan1.Name, match.HomeTeamName, match.AwayTeamName, fan1.Matches.Any(m => m.MatchId == match.MatchId));
            //Console.WriteLine("{0} received the match result for {1} vs {2}: {3}", fan2.Name, match.HomeTeamName, match.AwayTeamName, fan2.Matches.Any(m => m.MatchId == match.MatchId));

            Console.ReadLine();
        }
    }
}
