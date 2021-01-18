using System;

namespace HeboTech.TimeService
{
    public interface ITimeProvider
    {
        DateTime UtcNow { get; }
    }
}
