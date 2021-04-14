using System;

namespace HeboTech.TimeService
{
    public class TimeProviders
    {
        /// <summary>
        /// Returns DateTime.Now
        /// </summary>
        public static Func<DateTime> SystemTime => () => DateTime.Now;

        /// <summary>
        /// Returns DateTime.UtcNow
        /// </summary>
        public static Func<DateTime> SystemTimeUtc => () => DateTime.UtcNow;
    }
}
