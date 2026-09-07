using Audio;
using Timers.Dto;
using Timers.Enum;
using Timers.Interface;

namespace Timers
{
    public class Pomodoro : IPomodoro
    {
        private PomodoroSettings _settings;

        private int _remainingSeconds;

        private string _soundsPath = "";

        private readonly SoundPlayerService _soundPlayerService = new SoundPlayerService();

        public Status _status { get; private set; }

        public TimeSpan Remaining =>
            TimeSpan.FromSeconds(_remainingSeconds);

        public bool IsRunning =>
            _status == Status.Working ||
            _status == Status.ShortBreak ||
            _status == Status.LongBreak;

        public bool IsWorkSession =>
            _status == Status.Working;

        public int CompletedPomodoros { get; private set; }

        public Pomodoro(string soundsPath)
        {
            _soundsPath = soundsPath;
            _settings = new PomodoroSettings();
        }

        public Pomodoro(PomodoroSettings settings,string soundsPath)
        {
            _soundsPath = soundsPath;
            _settings = settings;

            Reset();
        }

        public void SetSettings(PomodoroSettings settings)
        {
            _settings = settings;
            if (_status != Status.Paused)
                Reset();
        }

        public void SetSoundsPath(string soundsPath)
        {
            _soundsPath = soundsPath;
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
            if (IsRunning)
            {
                _status = Status.Paused;
            }
        }

        public void Reset()
        {
            _status = Status.Ready;

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
            if (_status == Status.Working)
            {
                CompletedPomodoros++;

                if (CompletedPomodoros %
                    _settings.PomodorosBeforeLongBreak == 0)
                {
                    _status = Status.LongBreak;

                    _remainingSeconds =
                        _settings.LongBreakMinutes * 60;
                }
                else
                {
                    _status = Status.ShortBreak;

                    _remainingSeconds =
                        _settings.ShortBreakMinutes * 60;
                }
            }
            else
            {
                _status = Status.Working;

                _remainingSeconds =
                    _settings.WorkMinutes * 60;
            }

            _soundPlayerService.Play(_soundsPath);
        }
    }
}