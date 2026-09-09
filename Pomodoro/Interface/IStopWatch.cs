using System;
using System.Collections.Generic;
using System.Text;

namespace Timers.Interface
{
    public interface IStopWatch : ITimer
    {
        TimeSpan TotalTime { get; }
    }
}
