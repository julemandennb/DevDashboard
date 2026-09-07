using DevDashboard.Services;
using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime;
using System.Windows.Forms;
using Timers;
using Timers.Dto;

namespace DevDashboard.Control
{
    public partial class TimesControl : UserControl
    {
        private readonly Pomodoro _pomodoro;
        private readonly System.Windows.Forms.Timer _timerPomodoro;
        private PomodoroSettings _pomodoroSetting;

        private StopWatch _StopWatch;
        private readonly System.Windows.Forms.Timer _timerStopWatch;


        public TimesControl()
        {
            InitializeComponent();

            #region Pomodoro
                _pomodoroSetting = new PomodoroSettings
                {
                    WorkMinutes = 25,
                    ShortBreakMinutes = 5,
                    LongBreakMinutes = 15,
                    PomodorosBeforeLongBreak = 4
                };

                _pomodoro = new Pomodoro(_pomodoroSetting, UserDataService.Sounds);

                _timerPomodoro = new System.Windows.Forms.Timer
                {
                    Interval = 1000
                };

                _timerPomodoro.Tick += Timer_Tick_Pomodoro;
            #endregion

            _StopWatch = new StopWatch();
            _timerStopWatch = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            _timerStopWatch.Tick += Timer_Tick_StopWatch;


            UpdateUi();
        }

        private void UpdateUi()
        {
            this.UpdateUiPomodoro();
            this.UpdateUiPomodoroSetting();

            this.UpdateUiStopWatch();
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
    }
}
