using System;

namespace GitDemo
{
    internal class CurrentTimeProvider : ITimeProvider
    {
        public DateTime Time()
        {
           return DateTime.Now;
        }
    }
}