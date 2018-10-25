using System;
using PubSubPattern.Logic.Interfaces;

namespace PubSubPattern.Logic.Models
{
    public class FootballMatch : IMatch
    {
        public Guid MatchId { get; set; }
        public string HomeTeamName { get; set; }
        public string AwayTeamName { get; set; }
        public string FinalScore { get; set; }

        public FootballMatch(string homeTeamName, string awayTeamName, string finalScore)
        {
            MatchId = Guid.NewGuid();
            HomeTeamName = homeTeamName;
            AwayTeamName = awayTeamName;
            FinalScore = finalScore;
        }
    }
}
