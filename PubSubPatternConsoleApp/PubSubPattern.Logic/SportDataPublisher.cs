using System;
using PubSubPattern.Logic.Interfaces;

namespace PubSubPattern.Logic
{
    public class SportDataPublisher : ISportDataPublisher
    {
        public delegate void SportGameCompletedEventHandler(object sender, SportGameCompletedEventArgs e);
        public event SportGameCompletedEventHandler SportGameCompletedEvent;

        public void Broadcast(IMatch match)
        {
            if (match == null)
                throw new ArgumentException("Match cannot be null");
            OnSportGameCompleted(match);
        }

        protected void OnSportGameCompleted(IMatch match)
        {
            if (SportGameCompletedEvent == null) return;
            var e = new SportGameCompletedEventArgs
            {
                Match = match
            };
            SportGameCompletedEvent(this, e);
        }

        public void AttachEvent(ISportDataSubscriber subscriber)
        {
            SportGameCompletedEvent += subscriber.SportGameCompleted;
        }
    }
}

