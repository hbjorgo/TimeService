using System;
using Xunit;

namespace HeboTech.TimeService.Tests
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void IsWithinRange_exactly_same_time_returns_true_test()
        {
            TimeSpan range = TimeSpan.FromSeconds(0);
            DateTime now = new(2021, 6, 1, 12, 0, 0);
            DateTime reference = new(2021, 6, 1, 12, 0, 0);

            Assert.True(now.IsWithinRange(reference, range));
        }

        [Fact]
        public void IsWithinRange_not_same_time_returns_false_test()
        {
            TimeSpan range = TimeSpan.FromSeconds(0);
            DateTime now = new(2021, 6, 1, 12, 0, 0);
            DateTime reference = new(2021, 6, 1, 12, 0, 1);

            Assert.False(now.IsWithinRange(reference, range));
        }

        [Fact]
        public void IsWithinRane_returns_true_when_in_range_positive_test()
        {
            TimeSpan range = TimeSpan.FromSeconds(1);
            DateTime now = new(2021, 6, 1, 12, 0, 0);
            DateTime reference = new(2021, 6, 1, 12, 0, 1);

            Assert.True(now.IsWithinRange(reference, range));
        }

        [Fact]
        public void IsWithinRane_returns_true_when_in_range_negative_test()
        {
            TimeSpan range = TimeSpan.FromSeconds(1);
            DateTime now = new(2021, 6, 1, 12, 0, 0);
            DateTime reference = new(2021, 6, 1, 11, 59, 59);

            Assert.True(now.IsWithinRange(reference, range));
        }
    }
}
