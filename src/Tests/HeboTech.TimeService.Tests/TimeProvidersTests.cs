using System;
using Xunit;

namespace HeboTech.TimeService.Tests
{
    public class TimeProvidersTests
    {
        private readonly TimeSpan range = TimeSpan.FromSeconds(2);

        [Fact]
        public void SystemTime_returns_current_time_test()
        {
            DateTime now = TimeProviders.SystemTime();

            Assert.True(IsWithinRange(now, range));
        }

        [Fact]
        public void SystemTimeUtc_returns_current_time_test()
        {
            DateTime now = TimeProviders.SystemTimeUtc();

            Assert.True(IsWithinRange(now, range));
        }

        [Fact]
        public void SystemTimeUtc_returns_current_kind_test()
        {
            DateTime now = TimeProviders.SystemTimeUtc();

            Assert.Equal(DateTimeKind.Utc, now.Kind);
        }

        private static bool IsWithinRange(DateTime time, TimeSpan range) =>
            time > time - range && time < time + range;
    }
}
