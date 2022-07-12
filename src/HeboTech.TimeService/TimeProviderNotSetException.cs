using System;

namespace HeboTech.TimeService
{
    public class TimeProviderNotSetException : Exception
    {
        public TimeProviderNotSetException()
        {
        }

        public TimeProviderNotSetException(string message) : base(message)
        {
        }
    }
}
