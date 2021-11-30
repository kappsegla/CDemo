using System;

namespace GitDemo
{
    public interface ITimeProvider
    { 
        DateTime Time();
    }
}