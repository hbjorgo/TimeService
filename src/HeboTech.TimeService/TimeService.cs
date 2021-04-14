using System;

namespace HeboTech.TimeService
{
    public static class TimeService
    {
        private static Func<DateTime> timeFunc;

        /// <summary>
        /// Gets a DateTime object that represents the current time
        /// </summary>
        public static DateTime Now => timeFunc();

        /// <summary>
        /// Sets the current time. The func can either return a constant time, or a dynamic one (like DateTime.Now).
        /// </summary>
        /// <param name="timeFunc">Func that returns the current time</param>
        public static void Set(Func<DateTime> timeFunc) =>
            TimeService.timeFunc = timeFunc ?? throw new ArgumentNullException(nameof(timeFunc));

        /// <summary>
        /// Sets the current (constant) time.
        /// </summary>
        /// <param name="now">The current (constant) time</param>
        public static void SetConstant(DateTime now) =>
            timeFunc = () => now;
    }
}
