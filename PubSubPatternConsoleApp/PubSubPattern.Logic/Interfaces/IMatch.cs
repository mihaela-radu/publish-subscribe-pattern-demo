using System;

namespace PubSubPattern.Logic.Interfaces
{
    public interface IMatch
    {
        Guid MatchId { get; set; }
        string AwayTeamName { get; set; }
        string FinalScore { get; set; }
        string HomeTeamName { get; set; }
    }
}