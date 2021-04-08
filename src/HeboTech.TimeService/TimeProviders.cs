using System;

namespace HeboTech.TimeService
{
    public class TimeProviders
    {
        public static Func<DateTime> SystemTime => () => DateTime.Now;
        public static Func<DateTime> SystemTimeUtc => () => DateTime.UtcNow;
    }
}
