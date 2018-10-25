using System.IO;
using PubSubPattern.Logic.Interfaces;
using Xunit;

namespace PubSubPattern.Logic.Tests
{
    public class FootbalMatchDataProcessorTests
    {
        private readonly IFootbalMatchDataProcessor _dataProcessor;

        public FootbalMatchDataProcessorTests()
        {
            _dataProcessor = new FootbalMatchDataProcessor();
        }

        [Fact]
        public void ReturnsFootballMatchObjectForValidData()
        {
            var match = _dataProcessor.ProcessRawData("AVFC, Bristol City FC, 1-1");
            Assert.True(match is IMatch match1);
        }

        [Fact]
        public void ThrowsExceptionForInvalidData()
        {
            Assert.Throws<InvalidDataException>(() => _dataProcessor.ProcessRawData("AVFCBristol City FC1-1"));
        }
    }
}
