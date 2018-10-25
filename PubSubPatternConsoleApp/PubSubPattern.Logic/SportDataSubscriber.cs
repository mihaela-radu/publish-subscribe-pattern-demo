using System;
using System.Collections.Generic;
using PubSubPattern.Logic.Interfaces;

namespace PubSubPattern.Logic
{
    public class SportDataSubscriber : ISportDataSubscriber
    {
        public string Name { get; }
        public IList<IMatch> Matches { get; }

        public SportDataSubscriber(string name)
        {
            Name = name;
            Matches = new List<IMatch>();
        }

        void ISportDataSubscriber.SportGameCompleted(object sender, SportGameCompletedEventArgs e)
        {
            Matches.Add(e.Match);
            DisplayMatchData(e.Match);
        }

        private void DisplayMatchData(IMatch eMatch)
        {
            Console.WriteLine("{0} received data for a match: {1} vs. {2}, final score {3}", Name, eMatch.HomeTeamName, eMatch.AwayTeamName, eMatch.FinalScore);
        }
    }
}
