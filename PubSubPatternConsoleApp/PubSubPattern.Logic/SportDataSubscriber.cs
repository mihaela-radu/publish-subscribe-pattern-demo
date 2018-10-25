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
        }
    }
}
