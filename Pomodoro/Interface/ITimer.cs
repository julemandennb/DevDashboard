using System;
using System.Collections.Generic;
using System.Text;
using Timers.Enum;

namespace Timers.Interface
{
    public interface ITimer
    {
        Status _status { get; }

        bool IsRunning { get; }
        void Start();

        void Pause();

        void Reset();

        void Tick();
    }
}
