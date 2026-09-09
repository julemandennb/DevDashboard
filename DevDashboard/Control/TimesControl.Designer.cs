using System.Drawing;

namespace DevDashboard.Control
{
    partial class TimesControl
    {
        private bool darkMode = true;

    public bool DarkMode
        {
            get => darkMode;
            set
            {
                if (darkMode == value)
                    return;

                darkMode = value;
                ApplyTheme();
            }
        }

        private Color Darkcolor =
            Color.FromArgb(18, 18, 18);

        private Color Lightcolor =
            Color.FromArgb(240, 240, 240);

        private System.ComponentModel.IContainer components = null;

        //POMODORO
        private Panel pomodoroPanel;

        private Label lblPomodoroTitle;
        private Label lblStatus;
        private Label lblTime;
        private Label lblCompletedPomodoro;

        private TableLayoutPanel PomodoroSettingsGroupBox;

       

        private Panel nudWorkMinutesCard;
        private NumericUpDown nudWorkMinutes;
        private Label lblWorkMinutes;

        private Panel nudShortBreakCard;
        private NumericUpDown nudShortBreakMinutes;
        private Label lblShortBreakMinutes;

        private Panel nudLongBreakCard;
        private NumericUpDown nudLongBreakMinutes;
        private Label lblLongBreakMinutes;

        private Panel nudPomodorosBeforeLongCard;
        private NumericUpDown nudPomodorosBeforeLongBreak;
        private Label lblPomodorosBeforeLongBreak;

        private Button btnStartPomodoro;
        private Button btnPausePomodoro;
        private Button btnResetPomodoro;
        //End POMODORO
        //STOPWATCH
        private Panel stopWatchPanel;
        private Label lblStopWatchTitle;
        private Label lblStopWatchTime;

        private Button btnStartStopWatch;
        private Button btnPauseStopWatch;
        private Button btnResetStopWatch;

        //End STOPWATCH

        private Label lblAlarmTitle;


        private TableLayoutPanel timesLayout;
        private Panel alarmPanel;

        private Label showTimeAlarm;


        private TableLayoutPanel alarmSettingsGroupBox;

        private Panel hourAlarmCard;
        private Label lblHourAlarm;
        private NumericUpDown hourPickerAlarm;

        private Panel minuteAlarmCard;
        private Label lblMinuteAlarm;
        private NumericUpDown minutePickerAlarm;

        private Panel secondAlarmCard;
        private Label lblSecondAlarm;
        private NumericUpDown secondPickerAlarm;

        private Button btnSetAlarm;
        private Button btnPauselAlarm;
        private Button btnResetAlarm;
        



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows UserControl Designer generated code

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            //POMODORO
            pomodoroPanel =
                new Panel();

            lblPomodoroTitle =
                new Label();

            lblStatus =
                new Label();

            lblTime =
                new Label();

            lblCompletedPomodoro =
                new Label();

            PomodoroSettingsGroupBox = new TableLayoutPanel();

            nudWorkMinutesCard = new Panel();
            nudWorkMinutes = new NumericUpDown();
            lblWorkMinutes = new Label();

            nudShortBreakCard = new Panel();
            nudShortBreakMinutes = new NumericUpDown();
            lblShortBreakMinutes = new Label();

            nudLongBreakCard = new Panel();
            nudLongBreakMinutes = new NumericUpDown();
            lblLongBreakMinutes = new Label();

            nudPomodorosBeforeLongCard = new Panel();
            nudPomodorosBeforeLongBreak = new NumericUpDown();
            lblPomodorosBeforeLongBreak = new Label();

            btnStartPomodoro =
                new Button();

            btnPausePomodoro =
                new Button();

            btnResetPomodoro =
                new Button();

            //End POMODORO
            //STOPWATCH
            stopWatchPanel = new Panel();
            lblStopWatchTitle = new Label();

            lblStopWatchTime = new Label();

            btnStartStopWatch = new Button();
            btnPauseStopWatch = new Button();
            btnResetStopWatch = new Button();
            // ALARM

            lblAlarmTitle = new Label();
            alarmPanel = new Panel();

            showTimeAlarm = new Label();

            alarmSettingsGroupBox = new TableLayoutPanel();

            hourAlarmCard = new Panel();
            lblHourAlarm = new Label();
            hourPickerAlarm = new NumericUpDown();

            minuteAlarmCard = new Panel();
            lblMinuteAlarm = new Label();
            minutePickerAlarm = new NumericUpDown();

            secondAlarmCard = new Panel();
            lblSecondAlarm = new Label();
            secondPickerAlarm = new NumericUpDown();

            btnSetAlarm = new Button();
            btnPauselAlarm = new Button();
            btnResetAlarm = new Button();
            timesLayout = new TableLayoutPanel();
            //end STOPWATCH



            SuspendLayout();

            // =========================================================
            // TIMES CONTROL
            // =========================================================

            BackColor =
                DarkMode ? Darkcolor : Lightcolor;

            Dock =
                DockStyle.Fill;


            // =========================================================
            // POMODORO
            // =========================================================

            // =========================================================
            // POMODORO PANEL
            // =========================================================

            pomodoroPanel.BackColor =
                DarkMode
                    ? Color.FromArgb(28, 28, 30)
                    : Color.FromArgb(201, 201, 201);

            pomodoroPanel.Dock =
                DockStyle.Fill;


            pomodoroPanel.Padding =
                new Padding(20);

            // =========================================================
            // TITLE
            // =========================================================

            lblPomodoroTitle.Text =
                "🍅 Pomodoro";

            lblPomodoroTitle.AutoSize =
                true;

            lblPomodoroTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Regular);

            lblPomodoroTitle.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            lblPomodoroTitle.Location =
                new Point(20, 0);

            // =========================================================
            // STATUS
            // =========================================================

            lblStatus.Text =
                "Ready";

            lblStatus.AutoSize =
                true;

            lblStatus.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Regular);

            lblStatus.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            lblStatus.Location =
                new Point(22, 45);


            // =========================================================
            // Pomodoro Settings
            // =========================================================

            PomodoroSettingsGroupBox.ColumnCount = 4;
            PomodoroSettingsGroupBox.RowCount = 1;

            PomodoroSettingsGroupBox.Dock =
            DockStyle.None;

            PomodoroSettingsGroupBox.Location =
                new Point(20, 65);

            PomodoroSettingsGroupBox.Size =
                new Size(300, 150);

            PomodoroSettingsGroupBox.Height = 70;

            PomodoroSettingsGroupBox.Padding =
                new Padding(0, 10, 0, 0);

            PomodoroSettingsGroupBox.ColumnStyles.Add(
            new ColumnStyle(SizeType.Percent, 25F));

            PomodoroSettingsGroupBox.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            PomodoroSettingsGroupBox.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            PomodoroSettingsGroupBox.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            PomodoroSettingsGroupBox.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));

            // ---------------------------------------------------------
            // Work Minutes
            // ---------------------------------------------------------

            ConfigureCard(nudWorkMinutesCard);

            lblWorkMinutes.AutoSize = true;
            lblWorkMinutes.Text = "Work Minutes:";
            lblWorkMinutes.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            nudWorkMinutes.Location = new Point(10, 24);
            nudWorkMinutes.Minimum = 1;
            nudWorkMinutes.Maximum = 120;
            nudWorkMinutes.Value = 25;
            nudWorkMinutes.Name = "nudWorkMinutes";
            nudWorkMinutes.Size = new Size(100, 23);

            nudWorkMinutesCard.Controls.Add(
                lblWorkMinutes);

            nudWorkMinutesCard.Controls.Add(
                nudWorkMinutes);

            PomodoroSettingsGroupBox.Controls.Add(
                nudWorkMinutesCard,
                0,
                0);

            // ---------------------------------------------------------
            // Short Break
            // ---------------------------------------------------------

            ConfigureCard(nudShortBreakCard);

            lblShortBreakMinutes.AutoSize = true;
            lblShortBreakMinutes.Text = "Short Break Minutes:";
            lblShortBreakMinutes.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            nudShortBreakMinutes.Location = new Point(10, 24);
            nudShortBreakMinutes.Minimum = 1;
            nudShortBreakMinutes.Maximum = 60;
            nudShortBreakMinutes.Value = 5;
            nudShortBreakMinutes.Name = "nudShortBreakMinutes";
            nudShortBreakMinutes.Size = new Size(100, 23);

            nudShortBreakCard.Controls.Add(
               lblShortBreakMinutes);

            nudShortBreakCard.Controls.Add(
                nudShortBreakMinutes);

            PomodoroSettingsGroupBox.Controls.Add(
                nudShortBreakCard,
                1,
                0);


            // ---------------------------------------------------------
            // Long Break
            // ---------------------------------------------------------

            ConfigureCard(nudLongBreakCard);

            lblLongBreakMinutes.AutoSize = true;
            lblLongBreakMinutes.Text = "Long Break Minutes:";
            lblLongBreakMinutes.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            nudLongBreakMinutes.Location = new Point(10, 24);
            nudLongBreakMinutes.Minimum = 1;
            nudLongBreakMinutes.Maximum = 120;
            nudLongBreakMinutes.Value = 15;
            nudLongBreakMinutes.Name = "nudLongBreakMinutes";
            nudLongBreakMinutes.Size = new Size(100, 23);

            nudLongBreakCard.Controls.Add(
              lblLongBreakMinutes);

            nudLongBreakCard.Controls.Add(
                nudLongBreakMinutes);

            PomodoroSettingsGroupBox.Controls.Add(
                nudLongBreakCard,
                2,
                0);

            // ---------------------------------------------------------
            // Pomodoros Before Long Break
            // ---------------------------------------------------------

            ConfigureCard(nudPomodorosBeforeLongCard);

            lblPomodorosBeforeLongBreak.AutoSize = true;
            lblPomodorosBeforeLongBreak.Text = "Long After";
            lblPomodorosBeforeLongBreak.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            nudPomodorosBeforeLongBreak.Location = new Point(10, 24);
            nudPomodorosBeforeLongBreak.Minimum = 1;
            nudPomodorosBeforeLongBreak.Maximum = 20;
            nudPomodorosBeforeLongBreak.Value = 4;
            nudPomodorosBeforeLongBreak.Name = "nudPomodorosBeforeLongBreak";
            nudPomodorosBeforeLongBreak.Size = new Size(100, 23);

            nudPomodorosBeforeLongCard.Controls.Add(
              lblPomodorosBeforeLongBreak);

            nudPomodorosBeforeLongCard.Controls.Add(
                nudPomodorosBeforeLongBreak);

            PomodoroSettingsGroupBox.Controls.Add(
                nudPomodorosBeforeLongCard,
                3,
                0);


            // =========================================================
            // TIMER
            // =========================================================

            lblTime.Text =
                "25:00";

            lblTime.AutoSize =
                true;

            lblTime.Font =
                new Font(
                    "Segoe UI",
                    48F,
                    FontStyle.Bold);

            lblTime.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblTime.Location =
                new Point(20, 65);

            lblTime.Hide();

            // =========================================================
            // COMPLETED
            // =========================================================

            lblCompletedPomodoro.Text =
                "Completed: 0";

            lblCompletedPomodoro.AutoSize =
                true;

            lblCompletedPomodoro.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            lblCompletedPomodoro.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            lblCompletedPomodoro.Location =
                new Point(25, 140);

            // =========================================================
            // START BUTTON
            // =========================================================

            btnStartPomodoro.Text =
                "▶ Start";

            btnStartPomodoro.Size =
                new Size(90, 35);

            btnStartPomodoro.Location =
                new Point(20, 165);

            btnStartPomodoro.FlatStyle =
                FlatStyle.Flat;

            btnStartPomodoro.FlatAppearance.BorderSize =
                0;

            btnStartPomodoro.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnStartPomodoro.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            btnStartPomodoro.UseVisualStyleBackColor =
                false;

            btnStartPomodoro.Click +=
                btnStartPomodoro_Click;

            // =========================================================
            // PAUSE BUTTON
            // =========================================================

            btnPausePomodoro.Text =
                "⏸ Pause";

            btnPausePomodoro.Size =
                new Size(90, 35);

            btnPausePomodoro.Location =
                new Point(120, 165);

            btnPausePomodoro.FlatStyle =
                FlatStyle.Flat;

            btnPausePomodoro.FlatAppearance.BorderSize =
                0;

            btnPausePomodoro.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnPausePomodoro.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            btnPausePomodoro.UseVisualStyleBackColor =
                false;

            btnPausePomodoro.Click +=
                btnPausePomodoro_Click;

            // =========================================================
            // RESET BUTTON
            // =========================================================

            btnResetPomodoro.Text =
                "↻ Reset";

            btnResetPomodoro.Size =
                new Size(90, 35);

            btnResetPomodoro.Location =
                new Point(220, 165);

            btnResetPomodoro.FlatStyle =
                FlatStyle.Flat;

            btnResetPomodoro.FlatAppearance.BorderSize =
                0;

            btnResetPomodoro.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnResetPomodoro.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            btnResetPomodoro.UseVisualStyleBackColor =
                false;

            btnResetPomodoro.Click +=
                btnResetPomodoro_Click;

            // =========================================================
            // END POMODORO
            // =========================================================

            // =========================================================
            // STOPWATCH
            // =========================================================

            // =========================================================
            // STOPWATCH PANEL
            // =========================================================

            stopWatchPanel.BackColor =
                DarkMode
                    ? Color.FromArgb(28, 28, 30)
                    : Color.FromArgb(201, 201, 201);

            stopWatchPanel.Dock =
                DockStyle.Fill;

            stopWatchPanel.Padding =
                new Padding(20);

            // =========================================================
            // TITLE
            // =========================================================

            lblStopWatchTitle.Text =
                "STOPWATCH";

            lblStopWatchTitle.AutoSize =
                true;

            lblStopWatchTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Regular);

            lblStopWatchTitle.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            lblStopWatchTitle.Location =
                new Point(20, 20);


            lblStopWatchTime.Text =
               "00:00";

            lblStopWatchTime.AutoSize =
                true;

            lblStopWatchTime.Font =
                new Font(
                    "Segoe UI",
                    48F,
                    FontStyle.Bold);

            lblStopWatchTime.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblStopWatchTime.Location =
                new Point(20, 65);



            // =========================================================
            // START BUTTON
            // =========================================================

            btnStartStopWatch.Text =
                "▶ Start";

            btnStartStopWatch.Size =
                new Size(90, 35);

            btnStartStopWatch.Location =
                new Point(20, 165);

            btnStartStopWatch.FlatStyle =
                FlatStyle.Flat;

            btnStartStopWatch.FlatAppearance.BorderSize =
                0;

            btnStartStopWatch.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnStartStopWatch.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            btnStartStopWatch.UseVisualStyleBackColor =
                false;

            btnStartStopWatch.Click +=
                btnStartStopWatch_Click;

            // =========================================================
            // PAUSE BUTTON
            // =========================================================

            btnPauseStopWatch.Text =
                "⏸ Pause";

            btnPauseStopWatch.Size =
                new Size(90, 35);

            btnPauseStopWatch.Location =
                new Point(120, 165);

            btnPauseStopWatch.FlatStyle =
                FlatStyle.Flat;

            btnPauseStopWatch.FlatAppearance.BorderSize =
                0;

            btnPauseStopWatch.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnPauseStopWatch.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            btnPauseStopWatch.UseVisualStyleBackColor =
                false;

            btnPauseStopWatch.Click +=
                btnPauseStopWatch_Click;

            // =========================================================
            // RESET BUTTON
            // =========================================================

            btnResetStopWatch.Text =
                "↻ Reset";

            btnResetStopWatch.Size =
                new Size(90, 35);

            btnResetStopWatch.Location =
                new Point(220, 165);

            btnResetStopWatch.FlatStyle =
                FlatStyle.Flat;

            btnResetStopWatch.FlatAppearance.BorderSize =
                0;

            btnResetStopWatch.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnResetStopWatch.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            btnResetStopWatch.UseVisualStyleBackColor =
                false;

            btnResetStopWatch.Click +=
                btnResetStopWatch_Click;




            // =========================================================
            // END STOPWATCH
            // =========================================================

            // =========================================================
            // ALARM
            // =========================================================
            alarmPanel.Dock = DockStyle.Fill;
                alarmPanel.Padding = new Padding(10);
                alarmPanel.BackColor =
                    DarkMode
                        ? Color.FromArgb(28, 28, 30)
                        : Color.FromArgb(201, 201, 201);



            showTimeAlarm.Text =
                "00:00:00";

            showTimeAlarm.AutoSize =
                    true;

            showTimeAlarm.Font =
                    new Font(
                        "Segoe UI",
                        48F,
                        FontStyle.Bold);

            showTimeAlarm.ForeColor =
                    DarkMode
                        ? Color.White
                        : Color.Black;

            showTimeAlarm.Location =
                    new Point(20, 50);

            showTimeAlarm.Hide();

            alarmPanel.Controls.Add(showTimeAlarm);

            // =========================================================
            // TITLE
            // =========================================================

            lblAlarmTitle.Text =
                "Alarm";

            lblAlarmTitle.AutoSize =
                true;

            lblAlarmTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Regular);

            lblAlarmTitle.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            lblAlarmTitle.Location =
                new Point(20, 10);

            alarmPanel.Controls.Add(lblAlarmTitle);

            // =========================================================
            // Alarm Settings
            // =========================================================

            alarmSettingsGroupBox.ColumnCount = 3;
            alarmSettingsGroupBox.RowCount = 1;

            alarmSettingsGroupBox.Dock =
            DockStyle.None;

            alarmSettingsGroupBox.Location =
                new Point(20, 65);

            alarmSettingsGroupBox.Size =
                new Size(300, 150);

            alarmSettingsGroupBox.Height = 70;

            alarmSettingsGroupBox.Padding =
                new Padding(0, 10, 0, 0);

            alarmSettingsGroupBox.ColumnStyles.Add(
            new ColumnStyle(SizeType.Percent, 25F));

            alarmSettingsGroupBox.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            alarmSettingsGroupBox.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            alarmSettingsGroupBox.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 25F));

            alarmSettingsGroupBox.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));

            alarmPanel.Controls.Add(alarmSettingsGroupBox);

            // ---------------------------------------------------------
            // Hour set
            // ---------------------------------------------------------


            ConfigureCard(hourAlarmCard);

            lblHourAlarm.AutoSize = true;
            lblHourAlarm.Text = "Hours";
            lblHourAlarm.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            hourPickerAlarm.Location = new Point(10, 24);
            hourPickerAlarm.Minimum = 0;
            hourPickerAlarm.Maximum = 120;
            hourPickerAlarm.Value = 25;
            hourPickerAlarm.Name = "hourPickerAlarm";
            hourPickerAlarm.Size = new Size(100, 23);

            hourAlarmCard.Controls.Add(
                lblHourAlarm);

            hourAlarmCard.Controls.Add(
                hourPickerAlarm);

            alarmSettingsGroupBox.Controls.Add(
                hourAlarmCard,
                0,
                0);

            // ---------------------------------------------------------
            // Minute set
            // ---------------------------------------------------------


            ConfigureCard(minuteAlarmCard);

            lblMinuteAlarm.AutoSize = true;
            lblMinuteAlarm.Text = "Minute";
            lblMinuteAlarm.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            minutePickerAlarm.Location = new Point(10, 24);
            minutePickerAlarm.Minimum = 0;
            minutePickerAlarm.Maximum = 120;
            minutePickerAlarm.Value = 25;
            minutePickerAlarm.Name = "minutePickerAlarm";
            minutePickerAlarm.Size = new Size(100, 23);

            minuteAlarmCard.Controls.Add(
                lblMinuteAlarm);

            minuteAlarmCard.Controls.Add(
                minutePickerAlarm);

            alarmSettingsGroupBox.Controls.Add(
                minuteAlarmCard,
                1,
                0);

            // ---------------------------------------------------------
            //  Second set
            // ---------------------------------------------------------


            ConfigureCard(secondAlarmCard);

            lblSecondAlarm.AutoSize = true;
            lblSecondAlarm.Text = "Second";
            lblSecondAlarm.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            secondPickerAlarm.Location = new Point(10, 24);
            secondPickerAlarm.Minimum = 0;
            secondPickerAlarm.Maximum = 120;
            secondPickerAlarm.Value = 25;
            secondPickerAlarm.Name = "secondPickerAlarm";
            secondPickerAlarm.Size = new Size(100, 23);

            secondAlarmCard.Controls.Add(
                lblSecondAlarm);

            secondAlarmCard.Controls.Add(
                secondPickerAlarm);

            alarmSettingsGroupBox.Controls.Add(
                secondAlarmCard,
                2,
                0);


            // =========================================================
            // START BUTTON
            // =========================================================

            btnSetAlarm.Text =
                "▶ Start";

            btnSetAlarm.Size =
                new Size(90, 35);

            btnSetAlarm.Location =
                new Point(20, 165);

            btnSetAlarm.FlatStyle =
                FlatStyle.Flat;

            btnSetAlarm.FlatAppearance.BorderSize =
                0;

            btnSetAlarm.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnSetAlarm.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            btnSetAlarm.UseVisualStyleBackColor =
                false;

            btnSetAlarm.Click +=
                btnSetAlarm_Click;

            alarmPanel.Controls.Add(btnSetAlarm);

            // =========================================================
            // PAUSE BUTTON
            // =========================================================

            btnPauselAlarm.Text =
                "⏸ Pause";

            btnPauselAlarm.Size =
                new Size(90, 35);

            btnPauselAlarm.Location =
                new Point(120, 165);

            btnPauselAlarm.FlatStyle =
                FlatStyle.Flat;

            btnPauselAlarm.FlatAppearance.BorderSize =
                0;

            btnPauselAlarm.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnPauselAlarm.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            btnPauselAlarm.UseVisualStyleBackColor =
                false;

            btnPauselAlarm.Click += btnPauselAlarm_Click;

            alarmPanel.Controls.Add(btnPauselAlarm);

            // =========================================================
            // RESET BUTTON
            // =========================================================

            btnResetAlarm.Text =
                "↻ Reset";

            btnResetAlarm.Size =
                new Size(90, 35);

            btnResetAlarm.Location =
                new Point(220, 165);

            btnResetAlarm.FlatStyle =
                FlatStyle.Flat;

            btnResetAlarm.FlatAppearance.BorderSize =
                0;

            btnResetAlarm.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnResetAlarm.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            btnResetAlarm.UseVisualStyleBackColor =
                false;

            btnResetAlarm.Click += btnResetAlarm_Click;

            alarmPanel.Controls.Add(btnResetAlarm);

            // =========================================================
            // END alarm
            // =========================================================

            // =========================================================
            // ADD CONTROLS
            // =========================================================

            pomodoroPanel.Controls.Add(
                btnResetPomodoro);

            pomodoroPanel.Controls.Add(
                btnPausePomodoro);

            pomodoroPanel.Controls.Add(
                btnStartPomodoro);

            pomodoroPanel.Controls.Add(
                lblCompletedPomodoro);

            pomodoroPanel.Controls.Add(
                lblTime);

            pomodoroPanel.Controls.Add(
               PomodoroSettingsGroupBox);

            pomodoroPanel.Controls.Add(
                lblStatus);

            pomodoroPanel.Controls.Add(
                lblPomodoroTitle);

            stopWatchPanel.Controls.Add(
               lblStopWatchTitle);

            stopWatchPanel.Controls.Add(
               lblStopWatchTime);

            stopWatchPanel.Controls.Add(
               btnStartStopWatch);

            stopWatchPanel.Controls.Add(
               btnPauseStopWatch);

            stopWatchPanel.Controls.Add(
               btnResetStopWatch);


            // Use a vertical layout so panels are stacked: pomodoro, stopwatch, alarm
            timesLayout.ColumnCount = 1;
            timesLayout.RowCount = 3;
            timesLayout.Dock = DockStyle.Fill;
            timesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            // Pomodoro 60%, Stopwatch 20%, Alarm 20% so stopwatch and alarm have the same height
            timesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            timesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            timesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));

            timesLayout.Controls.Add(pomodoroPanel, 0, 0);
            timesLayout.Controls.Add(stopWatchPanel, 0, 1);
            timesLayout.Controls.Add(alarmPanel, 0, 2);

            Controls.Add(timesLayout);

            // =========================================================
            // CONTROL SETTINGS
            // =========================================================

            Name =
                "TimesControl";

            Size =
                new Size(340, 270);

            ResumeLayout(false);
        }

        // =============================================================
        // THEME
        // =============================================================

        private void ApplyTheme()
        {
            Color bg = DarkMode
                ? Darkcolor
                : Lightcolor;

            Color panelBackground = DarkMode
                ? Color.FromArgb(28, 28, 30)
                : Color.FromArgb(201, 201, 201);

            Color foreground = DarkMode
                ? Color.Gainsboro
                : Color.Black;

            Color timerForeground = DarkMode
                ? Color.White
                : Color.Black;

            Color buttonBackground = DarkMode
                ? Color.FromArgb(45, 45, 48)
                : Color.FromArgb(220, 220, 220);

            Color buttonForeground = DarkMode
                ? Color.White
                : Color.Black;

            Color numericBackground = DarkMode
                ? Color.FromArgb(45, 45, 48)
                : Color.White;

            Color numericForeground = DarkMode
                ? Color.White
                : Color.Black;


            // =============================================================
            // MAIN CONTROL
            // =============================================================

            BackColor = bg;


            // =============================================================
            // PANELS
            // =============================================================

            if (pomodoroPanel != null)
                pomodoroPanel.BackColor = panelBackground;

            if (stopWatchPanel != null)
                stopWatchPanel.BackColor = panelBackground;

            if (alarmPanel != null)
                alarmPanel.BackColor = panelBackground;


            // =============================================================
            // POMODORO LABELS
            // =============================================================

            if (lblPomodoroTitle != null)
                lblPomodoroTitle.ForeColor = foreground;

            if (lblStatus != null)
                lblStatus.ForeColor = foreground;

            if (lblTime != null)
                lblTime.ForeColor = timerForeground;

            if (lblCompletedPomodoro != null)
                lblCompletedPomodoro.ForeColor = foreground;

            if (lblWorkMinutes != null)
                lblWorkMinutes.ForeColor = foreground;

            if (lblShortBreakMinutes != null)
                lblShortBreakMinutes.ForeColor = foreground;

            if (lblLongBreakMinutes != null)
                lblLongBreakMinutes.ForeColor = foreground;

            if (lblPomodorosBeforeLongBreak != null)
                lblPomodorosBeforeLongBreak.ForeColor = foreground;


            // =============================================================
            // POMODORO CARDS
            // =============================================================

            if (nudWorkMinutesCard != null)
                nudWorkMinutesCard.BackColor = panelBackground;

            if (nudShortBreakCard != null)
                nudShortBreakCard.BackColor = panelBackground;

            if (nudLongBreakCard != null)
                nudLongBreakCard.BackColor = panelBackground;

            if (nudPomodorosBeforeLongCard != null)
                nudPomodorosBeforeLongCard.BackColor = panelBackground;


            // =============================================================
            // POMODORO NUMERIC UP/DOWN
            // =============================================================

            if (nudWorkMinutes != null)
            {
                nudWorkMinutes.BackColor = numericBackground;
                nudWorkMinutes.ForeColor = numericForeground;
            }

            if (nudShortBreakMinutes != null)
            {
                nudShortBreakMinutes.BackColor = numericBackground;
                nudShortBreakMinutes.ForeColor = numericForeground;
            }

            if (nudLongBreakMinutes != null)
            {
                nudLongBreakMinutes.BackColor = numericBackground;
                nudLongBreakMinutes.ForeColor = numericForeground;
            }

            if (nudPomodorosBeforeLongBreak != null)
            {
                nudPomodorosBeforeLongBreak.BackColor = numericBackground;
                nudPomodorosBeforeLongBreak.ForeColor = numericForeground;
            }


            // =============================================================
            // POMODORO SETTINGS GROUP
            // =============================================================

            if (PomodoroSettingsGroupBox != null)
            {
                PomodoroSettingsGroupBox.BackColor = panelBackground;
                PomodoroSettingsGroupBox.ForeColor = foreground;
            }


            // =============================================================
            // POMODORO BUTTONS
            // =============================================================

            if (btnStartPomodoro != null)
            {
                btnStartPomodoro.BackColor = buttonBackground;
                btnStartPomodoro.ForeColor = buttonForeground;
            }

            if (btnPausePomodoro != null)
            {
                btnPausePomodoro.BackColor = buttonBackground;
                btnPausePomodoro.ForeColor = buttonForeground;
            }

            if (btnResetPomodoro != null)
            {
                btnResetPomodoro.BackColor = buttonBackground;
                btnResetPomodoro.ForeColor = buttonForeground;
            }


            // =============================================================
            // STOPWATCH
            // =============================================================

            if (lblStopWatchTitle != null)
                lblStopWatchTitle.ForeColor = foreground;

            if (lblStopWatchTime != null)
                lblStopWatchTime.ForeColor = timerForeground;

            if (btnStartStopWatch != null)
            {
                btnStartStopWatch.BackColor = buttonBackground;
                btnStartStopWatch.ForeColor = buttonForeground;
            }

            if (btnPauseStopWatch != null)
            {
                btnPauseStopWatch.BackColor = buttonBackground;
                btnPauseStopWatch.ForeColor = buttonForeground;
            }

            if (btnResetStopWatch != null)
            {
                btnResetStopWatch.BackColor = buttonBackground;
                btnResetStopWatch.ForeColor = buttonForeground;
            }


            // =============================================================
            // ALARM
            // =============================================================

            if (lblAlarmTitle != null)
                lblAlarmTitle.ForeColor = foreground;

            if (showTimeAlarm != null)
                showTimeAlarm.ForeColor = timerForeground;


            // =============================================================
            // ALARM CARDS
            // =============================================================

            if (hourAlarmCard != null)
                hourAlarmCard.BackColor = panelBackground;

            if (minuteAlarmCard != null)
                minuteAlarmCard.BackColor = panelBackground;

            if (secondAlarmCard != null)
                secondAlarmCard.BackColor = panelBackground;


            // =============================================================
            // ALARM LABELS
            // =============================================================

            if (lblHourAlarm != null)
                lblHourAlarm.ForeColor = foreground;

            if (lblMinuteAlarm != null)
                lblMinuteAlarm.ForeColor = foreground;

            if (lblSecondAlarm != null)
                lblSecondAlarm.ForeColor = foreground;


            // =============================================================
            // ALARM NUMERIC UP/DOWN
            // =============================================================

            if (hourPickerAlarm != null)
            {
                hourPickerAlarm.BackColor = numericBackground;
                hourPickerAlarm.ForeColor = numericForeground;
            }

            if (minutePickerAlarm != null)
            {
                minutePickerAlarm.BackColor = numericBackground;
                minutePickerAlarm.ForeColor = numericForeground;
            }

            if (secondPickerAlarm != null)
            {
                secondPickerAlarm.BackColor = numericBackground;
                secondPickerAlarm.ForeColor = numericForeground;
            }


            // =============================================================
            // ALARM SETTINGS GROUP
            // =============================================================

            if (alarmSettingsGroupBox != null)
            {
                alarmSettingsGroupBox.BackColor = panelBackground;
                alarmSettingsGroupBox.ForeColor = foreground;
            }


            // =============================================================
            // ALARM BUTTONS
            // =============================================================

            if (btnSetAlarm != null)
            {
                btnSetAlarm.BackColor = buttonBackground;
                btnSetAlarm.ForeColor = buttonForeground;
            }

            if (btnPauselAlarm != null)
            {
                btnPauselAlarm.BackColor = buttonBackground;
                btnPauselAlarm.ForeColor = buttonForeground;
            }

            if (btnResetAlarm != null)
            {
                btnResetAlarm.BackColor = buttonBackground;
                btnResetAlarm.ForeColor = buttonForeground;
            }


            // =============================================================
            // FORCE REDRAW
            // =============================================================

            Invalidate();
            Update();
        }

        private void ConfigureCard(Panel card)
        {
            card.Dock = DockStyle.Fill;

            card.Margin = new Padding(5);

            card.Padding = new Padding(10);

            card.BackColor =
                DarkMode
                    ? Color.FromArgb(28, 28, 30)
                    : Color.FromArgb(201, 201, 201);
        }


        #endregion
    }
}
