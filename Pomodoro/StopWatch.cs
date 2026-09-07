using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using Timers.Enum;
using Timers.Interface;

namespace Timers
{
    public class StopWatch: IStopWatch
    {
        public Status _status { get; private set; } = Status.Ready;

        private ulong _totalSeconds;
        public TimeSpan TotalTime => TimeSpan.FromSeconds(_totalSeconds);

        public bool IsRunning =>
            _status == Status.Working ||
            _status == Status.ShortBreak ||
            _status == Status.LongBreak;

        public StopWatch()
        {
            _totalSeconds = 0;
        }

        public void Tick()
        {
            if (_status != Status.Working)
            {
                return;
            }

            _totalSeconds++;
            
        }

        public void Start()
        {
            if (_status == Status.Ready)
            {
                _status = Status.Working;
            }
            else if (_status == Status.Paused)
            {
                _status = Status.Working;
            }
        }

        public void Pause()
        {
            if (_status == Status.Working)
            {
                _status = Status.Paused;
            }
        }

        public void Reset()
        {
            _status = Status.Ready;

            _totalSeconds = 0;
        }
    }
}
