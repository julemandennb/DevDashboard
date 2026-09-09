using System;
using System.Collections.Generic;
using System.Text;
using Timers.Dto;

namespace Timers.Interface
{
    public interface IAlarm :ITimer
    {
        TimeSpan Remaining { get; }

        void SetSettings(AlarmSettings settings);

        void SetSoundsPath(string soundsPath);
    }
}
