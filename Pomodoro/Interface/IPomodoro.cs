using System;

namespace Timers.Interface
{
    public interface IPomodoro
    {
        TimeSpan Remaining { get; }

        bool IsRunning { get; }

        bool IsWorkSession { get; }

        int CompletedPomodoros { get; }

        void Start();

        void Pause();

        void Reset();

        void Tick();
    }
}