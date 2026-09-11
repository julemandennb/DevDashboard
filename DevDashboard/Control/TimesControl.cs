using Settings;
using Settings.Models;
using Settings.Services;
using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime;
using System.Windows.Forms;
using Timers;
using Timers.Dto;
using Timers.Interface;

namespace DevDashboard.Control
{
    public partial class TimesControl : UserControl
    {
        private readonly SettingsFile<TimesSetting> _settingsFile;

        private TimesSetting _timesSetting;



        private readonly IPomodoro _pomodoro;
        private readonly System.Windows.Forms.Timer _timerPomodoro;
        private PomodoroSettings _pomodoroSetting;

        private IStopWatch _StopWatch;
        private readonly System.Windows.Forms.Timer _timerStopWatch;

        private readonly IAlarm _alarm;
        private readonly System.Windows.Forms.Timer _timerAlarm;
        private AlarmSettings _AlarmSettings;


        public TimesControl()
        {
            InitializeComponent();

            _settingsFile = new SettingsFile<TimesSetting>();
            _timesSetting = _settingsFile.Load();


            #region Pomodoro
            _pomodoroSetting = new PomodoroSettings
                {
                    WorkMinutes = 25,
                    ShortBreakMinutes = 5,
                    LongBreakMinutes = 15,
                    PomodorosBeforeLongBreak = 4
                };

                string pomodoroSound = FilePathServices.GetSoundsFilePath(_timesSetting.PomodoroSoundName);

                _pomodoro = new Pomodoro(_pomodoroSetting, pomodoroSound);

                _timerPomodoro = new System.Windows.Forms.Timer
                {
                    Interval = 1000
                };

                _timerPomodoro.Tick += Timer_Tick_Pomodoro;
            #endregion

            #region StopWatch
            _StopWatch = new StopWatch();
            _timerStopWatch = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            _timerStopWatch.Tick += Timer_Tick_StopWatch;
            #endregion

            #region Alarm
            _AlarmSettings = new AlarmSettings
            {
                Hour = 0,
                Minute = 0,
                Second = 0,
            };

            string alarmSound = FilePathServices.GetSoundsFilePath(_timesSetting.AlarmSoundName);

            _alarm = new Alarm(_AlarmSettings, alarmSound);

            _timerAlarm = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            _timerAlarm.Tick += Timer_Tick_Alarm;
            #endregion

            UpdateUi();
        }

        private void UpdateUi()
        {
            this.UpdateUiPomodoro();
            this.UpdateUiPomodoroSetting();

            this.UpdateUiStopWatch();

            this.UpdateUiAlarmSetting();
            this.UpdateUiAlarm();

        }

        #region Pomodoro

        private void btnStartPomodoro_Click(object? sender, EventArgs e)
        {

            PomodoroSettingsGroupBox.Hide();
            UpdatePomodoroSetting();
            lblTime.Show();

            _pomodoro.Start();

            _timerPomodoro.Start();

            UpdateUi();
        }

        private void btnPausePomodoro_Click(object? sender, EventArgs e)
        {
            _pomodoro.Pause();

            _timerPomodoro.Stop();

            UpdateUi();
        }

        private void btnResetPomodoro_Click(object? sender, EventArgs e)
        {
            PomodoroSettingsGroupBox.Show();
            lblTime.Hide();

            _pomodoro.Reset();

            _timerPomodoro.Stop();

            UpdateUi();
        }

        private void Timer_Tick_Pomodoro(object? sender, EventArgs e)
        {
            _pomodoro.Tick();

            UpdateUi();
        }

        private void UpdateUiPomodoro()
        {
            TimeSpan remaining = _pomodoro.Remaining;

            lblTime.Text =
                $"{(int)remaining.TotalMinutes:00}:{remaining.Seconds:00}";

            lblStatus.Text =
                _pomodoro._status.ToString();

            lblCompletedPomodoro.Text =
                $"Completed: {_pomodoro.CompletedPomodoros}";

            btnStartPomodoro.Enabled =
                !_pomodoro.IsRunning;

            btnPausePomodoro.Enabled =
                _pomodoro.IsRunning;

        }

        private void UpdateUiPomodoroSetting()
        {
            nudWorkMinutes.Value = _pomodoroSetting.WorkMinutes;
            nudShortBreakMinutes.Value = _pomodoroSetting.ShortBreakMinutes;
            nudLongBreakMinutes.Value = _pomodoroSetting.LongBreakMinutes;
            nudPomodorosBeforeLongBreak.Value = _pomodoroSetting.PomodorosBeforeLongBreak;
        }

        private void UpdatePomodoroSetting()
        {
            _pomodoroSetting.WorkMinutes = Convert.ToInt32(nudWorkMinutes.Value);
            _pomodoroSetting.ShortBreakMinutes = Convert.ToInt32(nudShortBreakMinutes.Value);
            _pomodoroSetting.LongBreakMinutes = Convert.ToInt32(nudLongBreakMinutes.Value);
            _pomodoroSetting.PomodorosBeforeLongBreak = Convert.ToInt32(nudPomodorosBeforeLongBreak.Value);

            _pomodoro.SetSettings(_pomodoroSetting);
        }

        #endregion

        #region StopWatch
        private void btnStartStopWatch_Click(object? sender, EventArgs e)
        {
            _StopWatch.Start();

            _timerStopWatch.Start();

            UpdateUi();
        }

        private void btnPauseStopWatch_Click(object? sender, EventArgs e)
        {
            _StopWatch.Pause();

            _timerStopWatch.Stop();

            UpdateUi();
        }

        private void btnResetStopWatch_Click(object? sender, EventArgs e)
        {

            _StopWatch.Reset();

            _timerStopWatch.Stop();

            UpdateUi();
        }


        private void Timer_Tick_StopWatch(object? sender, EventArgs e)
        {
            _StopWatch.Tick();
            UpdateUi();
        }

        private void UpdateUiStopWatch()
        {
            TimeSpan remaining = _StopWatch.TotalTime;

            lblStopWatchTime.Text =
                $"{(int)remaining.TotalMinutes:00}:{remaining.Seconds:00}";


            btnStartStopWatch.Enabled =
                !_StopWatch.IsRunning;

            btnPauseStopWatch.Enabled =
                _StopWatch.IsRunning;

        }
        #endregion

        #region Alarm

        private void btnSetAlarm_Click(object? sender, EventArgs e)
        {

            alarmSettingsGroupBox.Hide();
            UpdateAlarmSetting();
            showTimeAlarm.Show();

            _alarm.Start();

            _timerAlarm.Start();

            UpdateUi();
        }

        private void btnPauselAlarm_Click(object? sender, EventArgs e)
        {
            _alarm.Pause();

            _timerAlarm.Stop();

            UpdateUi();
        }

        private void btnResetAlarm_Click(object? sender, EventArgs e)
        {
            alarmSettingsGroupBox.Show();
            showTimeAlarm.Hide();

            _alarm.Reset();

            _timerAlarm.Stop();

            UpdateUi();
        }

        private void Timer_Tick_Alarm(object? sender, EventArgs e)
        {
            _alarm.Tick();

            if (!_alarm.IsRunning)
            {
                _timerAlarm.Stop();
            }

            UpdateUiAlarm();
        }

        private void UpdateUiAlarm()
        {
            TimeSpan remaining = _alarm.Remaining;

            showTimeAlarm.Text =
                $"{(int)remaining.TotalHours:00}:{(int)remaining.Minutes:00}:{remaining.Seconds:00}";


            btnSetAlarm.Enabled =
                !_alarm.IsRunning;

            btnPauselAlarm.Enabled =
                _alarm.IsRunning;

        }

        private void UpdateUiAlarmSetting()
        {
            hourPickerAlarm.Value = _AlarmSettings.Hour;
            minutePickerAlarm.Value = _AlarmSettings.Minute;
            secondPickerAlarm.Value = _AlarmSettings.Second;
        }

        private void UpdateAlarmSetting()
        {
            _AlarmSettings.Hour = Convert.ToInt32(hourPickerAlarm.Value);
            _AlarmSettings.Minute = Convert.ToInt32(minutePickerAlarm.Value);
            _AlarmSettings.Second = Convert.ToInt32(secondPickerAlarm.Value);


            _alarm.SetSettings(_AlarmSettings);
        }


        #endregion
    }
}
