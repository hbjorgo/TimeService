using System;

namespace HeboTech.TimeService
{
    public static class TimeService
    {
        private static Func<DateTime> timeFunc;
        public static DateTime Now => timeFunc();

        public static void Set(Func<DateTime> timeFunc) =>
            TimeService.timeFunc = timeFunc ?? throw new ArgumentNullException(nameof(timeFunc));
    }
}
