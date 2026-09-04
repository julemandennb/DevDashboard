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

            SuspendLayout();

            // =========================================================
            // TIMES CONTROL
            // =========================================================

            BackColor =
                DarkMode ? Darkcolor : Lightcolor;

            Dock =
                DockStyle.Fill;

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
                new Point(20, 20);

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
                new Point(22, 65);


            // =========================================================
            // Pomodoro Settings
            // =========================================================

            PomodoroSettingsGroupBox.ColumnCount = 4;
            PomodoroSettingsGroupBox.RowCount = 1;

            PomodoroSettingsGroupBox.Dock =
            DockStyle.None;

            PomodoroSettingsGroupBox.Location =
                new Point(20, 85);

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
                new Point(20, 85);

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
                new Point(25, 170);

            // =========================================================
            // START BUTTON
            // =========================================================

            btnStartPomodoro.Text =
                "▶ Start";

            btnStartPomodoro.Size =
                new Size(90, 35);

            btnStartPomodoro.Location =
                new Point(20, 205);

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
                new Point(120, 205);

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
                new Point(220, 205);

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

            Controls.Add(
                pomodoroPanel);

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
            Color bg =
                DarkMode
                    ? Darkcolor
                    : Lightcolor;

            try
            {
                BackColor = bg;
            }
            catch
            {
            }

            if (pomodoroPanel != null)
            {
                pomodoroPanel.BackColor =
                    DarkMode
                        ? Color.FromArgb(28, 28, 30)
                        : Color.FromArgb(201, 201, 201);
            }

            if (lblPomodoroTitle != null)
            {
                lblPomodoroTitle.ForeColor =
                    DarkMode
                        ? Color.Gainsboro
                        : Color.Black;
            }

            if (lblStatus != null)
            {
                lblStatus.ForeColor =
                    DarkMode
                        ? Color.Gainsboro
                        : Color.Black;
            }

            if (lblTime != null)
            {
                lblTime.ForeColor =
                    DarkMode
                        ? Color.White
                        : Color.Black;
            }

            if (lblCompletedPomodoro != null)
            {
                lblCompletedPomodoro.ForeColor =
                    DarkMode
                        ? Color.Gainsboro
                        : Color.Black;
            }

            Color buttonBackground =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            Color buttonForeground =
                DarkMode
                    ? Color.White
                    : Color.Black;

            if (btnStartPomodoro != null)
            {
                btnStartPomodoro.BackColor =
                    buttonBackground;

                btnStartPomodoro.ForeColor =
                    buttonForeground;
            }

            if (btnPausePomodoro != null)
            {
                btnPausePomodoro.BackColor =
                    buttonBackground;

                btnPausePomodoro.ForeColor =
                    buttonForeground;
            }

            if (btnResetPomodoro != null)
            {
                btnResetPomodoro.BackColor =
                    buttonBackground;

                btnResetPomodoro.ForeColor =
                    buttonForeground;
            }
        }

        private void ConfigureCard(
            Panel card)
        {
            card.BackColor =
                DarkMode ? Color.FromArgb(28, 28, 30) : Color.FromArgb(201, 201, 201);

            card.Dock =
                DockStyle.Fill;

            card.Margin =
                new Padding(5);

            card.Padding =
                new Padding(10);
        }


        #endregion
    }
}
