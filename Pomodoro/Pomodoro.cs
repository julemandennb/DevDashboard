using Timers.Dto;
using Timers.Enum;
using Timers.Interface;

namespace Timers
{
    public class Pomodoro : IPomodoro
    {
        private readonly PomodoroSettings _settings;

        private int _remainingSeconds;

        public PomodoroStatus Status { get; private set; }

        public TimeSpan Remaining =>
            TimeSpan.FromSeconds(_remainingSeconds);

        public bool IsRunning =>
            Status == PomodoroStatus.Working ||
            Status == PomodoroStatus.ShortBreak ||
            Status == PomodoroStatus.LongBreak;

        public bool IsWorkSession =>
            Status == PomodoroStatus.Working;

        public int CompletedPomodoros { get; private set; }

        public Pomodoro()
        {
            _settings = new PomodoroSettings();
        }

        public Pomodoro(PomodoroSettings settings)
        {
            _settings = settings;

            Reset();
        }

        public void Start()
        {
            if (Status == PomodoroStatus.Ready)
            {
                Status = PomodoroStatus.Working;
            }
            else if (Status == PomodoroStatus.Paused)
            {
                Status = PomodoroStatus.Working;
            }
        }

        public void Pause()
        {
            if (IsRunning)
            {
                Status = PomodoroStatus.Paused;
            }
        }

        public void Reset()
        {
            Status = PomodoroStatus.Ready;

            _remainingSeconds =
                _settings.WorkMinutes * 60;

            CompletedPomodoros = 0;
        }

        public void Tick()
        {
            if (!IsRunning)
            {
                return;
            }

            if (_remainingSeconds > 0)
            {
                _remainingSeconds--;
            }

            if (_remainingSeconds == 0)
            {
                NextSession();
            }
        }

        private void NextSession()
        {
            if (Status == PomodoroStatus.Working)
            {
                CompletedPomodoros++;

                if (CompletedPomodoros %
                    _settings.PomodorosBeforeLongBreak == 0)
                {
                    Status = PomodoroStatus.LongBreak;

                    _remainingSeconds =
                        _settings.LongBreakMinutes * 60;
                }
                else
                {
                    Status = PomodoroStatus.ShortBreak;

                    _remainingSeconds =
                        _settings.ShortBreakMinutes * 60;
                }
            }
            else
            {
                Status = PomodoroStatus.Working;

                _remainingSeconds =
                    _settings.WorkMinutes * 60;
            }
        }
    }
}