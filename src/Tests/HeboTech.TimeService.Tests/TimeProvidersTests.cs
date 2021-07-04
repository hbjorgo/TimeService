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

            Assert.True(now.IsWithinRange(DateTime.Now, range));
        }

        [Fact]
        public void SystemTimeUtc_returns_current_time_test()
        {
            DateTime now = TimeProviders.SystemTimeUtc();

            Assert.True(now.IsWithinRange(DateTime.UtcNow, range));
        }

        [Fact]
        public void SystemTimeUtc_returns_current_kind_test()
        {
            DateTime now = TimeProviders.SystemTimeUtc();

            Assert.Equal(DateTimeKind.Utc, now.Kind);
        }
    }
}
