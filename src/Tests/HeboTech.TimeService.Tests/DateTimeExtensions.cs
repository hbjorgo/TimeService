using System;

namespace HeboTech.TimeService.Tests
{
    public static class DateTimeExtensions
    {
        public static bool IsWithinRange(this DateTime time, DateTime reference, TimeSpan range) =>
            time >= reference - range && time <= reference + range;
    }
}
