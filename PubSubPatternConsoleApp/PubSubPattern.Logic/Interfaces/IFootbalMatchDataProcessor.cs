namespace PubSubPattern.Logic.Interfaces
{
    public interface IFootbalMatchDataProcessor
    {
        IMatch ProcessRawData(string rawMatchData);
    }
}