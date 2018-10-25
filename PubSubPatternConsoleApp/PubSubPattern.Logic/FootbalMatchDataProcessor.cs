using System;
using System.IO;
using PubSubPattern.Logic.Interfaces;
using PubSubPattern.Logic.Models;

namespace PubSubPattern.Logic
{
    public class FootbalMatchDataProcessor : IFootbalMatchDataProcessor
    {
        public IMatch ProcessRawData(string rawMatchData)
        {
            var dataParts = rawMatchData.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
            if (dataParts.Length < 3)
                throw new InvalidDataException();
            return new FootballMatch(dataParts[0], dataParts[1], dataParts[2]);

        }
    }
}
