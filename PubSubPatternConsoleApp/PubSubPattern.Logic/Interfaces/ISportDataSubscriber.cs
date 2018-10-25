using System.Collections.Generic;

namespace PubSubPattern.Logic.Interfaces
{
    public interface ISportDataSubscriber    {

        string Name { get; }
        IList<IMatch> Matches { get; }
        void SportGameCompleted(object sender, SportGameCompletedEventArgs e);
    }
}
