using System;
using PubSubPattern.Logic.Interfaces;
using PubSubPattern.Logic.Models;
using Xunit;

namespace PubSubPattern.Logic.Tests
{
    public class SportDataPublisherTests
    {
        private readonly ISportDataPublisher _publisher;
        private readonly IMatch _match;
        public SportDataPublisherTests()
        {
            _publisher = new SportDataPublisher();
            _match = new FootballMatch("AVFC", "Bristol City FC", "1-1");
        }

        [Fact]
        public void BroadcastMethodThowsExceptionIfMatchIsNull()
        {
            Assert.Throws<ArgumentException>(() => _publisher.Broadcast(null));
        }
    }
}
