using Audio;
using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using Timers.Dto;
using Timers.Enum;
using Timers.Interface;

namespace Timers
{
    public class Alarm: IAlarm
    {

        private AlarmSettings _settings;


        public Status _status { get; private set; } = Status.Ready;

        private int _remainingSeconds;

        private string _soundsPath = "";


        private readonly SoundPlayerService _soundPlayerService = new SoundPlayerService();

        public TimeSpan Remaining =>
           TimeSpan.FromSeconds(_remainingSeconds);

        public bool IsRunning =>
           _status == Status.Working ||
           _status == Status.ShortBreak ||
           _status == Status.LongBreak;

        public Alarm(string soundsPath)
        {
            _soundsPath = soundsPath;
            _settings = new AlarmSettings();
        }

        public Alarm(AlarmSettings settings, string soundsPath)
        {
            _soundsPath = soundsPath;
            _settings = settings;

            Reset();
        }

        public void SetSettings(AlarmSettings settings)
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
                _settings.Hour * 3600 +
                _settings.Minute * 60 +
                _settings.Second;
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
                _soundPlayerService.Play(_soundsPath);
                _status = Status.Ready;
            }
        }

    }
}
