namespace PubSubPattern.Logic.Interfaces
{
    public interface ISportDataPublisher
    {
        event SportDataPublisher.SportGameCompletedEventHandler SportGameCompletedEvent;

        void AttachEvent(ISportDataSubscriber subscriber);
        void Broadcast(IMatch match);
    }
}