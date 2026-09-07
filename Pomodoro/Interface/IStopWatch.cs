using System;
using System.Collections.Generic;
using System.Text;

namespace Timers.Interface
{
    internal interface IStopWatch : ITimer
    {
        TimeSpan TotalTime { get; }
    }
}
