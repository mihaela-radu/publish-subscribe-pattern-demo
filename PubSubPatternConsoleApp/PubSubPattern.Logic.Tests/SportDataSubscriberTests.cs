using PubSubPattern.Logic.Interfaces;
using Xunit;

namespace PubSubPattern.Logic.Tests
{
    public class SportDataSubscriberTests
    {
        private readonly ISportDataSubscriber _subscriber;

        public SportDataSubscriberTests()
        {
            _subscriber = new SportDataSubscriber("Test");
        }

        [Fact]
        public void SubscriberHasName()
        {          
            Assert.True(_subscriber.Name != string.Empty);
        }

        [Fact]
        public void SubscriberNameIsTest()
        {
            Assert.Equal("Test", _subscriber.Name);
        }
    }
}
