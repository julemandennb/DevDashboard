using System;
using Timers.Dto;

namespace Timers.Interface
{
    public interface IPomodoro:ITimer
    {
        TimeSpan Remaining { get; }

        bool IsWorkSession { get; }

        int CompletedPomodoros { get; }
        void SetSettings(PomodoroSettings settings);

        void SetSoundsPath(string soundsPath);
       
    }
}