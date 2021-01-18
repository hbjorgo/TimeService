using System;

namespace HeboTech.TimeService
{
    public class ManualTimeProvider : ITimeProvider
    {
        public ManualTimeProvider() {}
        
        public ManualTimeProvider(DateTime utcNow) => SetTime(utcNow);

        public DateTime UtcNow { get; private set; }
        
        public void Elapse(TimeSpan elapsedTime) => UtcNow += elapsedTime;
        
        public void SetTime(DateTime utcNow)
        {
            if (utcNow.Kind != DateTimeKind.Utc)
            {
                throw new ArgumentException("DateTime not in UTC format");
            }
            UtcNow = utcNow;
        }
    }
}
