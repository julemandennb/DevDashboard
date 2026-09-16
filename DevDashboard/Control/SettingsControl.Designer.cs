namespace DevDashboard.Control
{
    partial class SettingsControl
    {
        // =========================================================
        // THEME
        // =========================================================

        private bool darkMode = true;

        public bool DarkMode
        {
            get => darkMode;
            set
            {
                if (darkMode == value)
                    return;

                darkMode = value;

                if (chkDarkMode != null &&
                    chkDarkMode.Checked != value)
                {
                    chkDarkMode.Checked = value;
                }

                ApplyTheme();
            }
        }

        private Color DarkColor =
            Color.FromArgb(18, 18, 18);

        private Color LightColor =
            Color.FromArgb(240, 240, 240);

        private System.ComponentModel.IContainer components = null;

        // =========================================================
        // MAIN
        // =========================================================

        private Panel settingsPanel;

        // =========================================================
        // TOP TAB NAVIGATION
        // =========================================================

        private Panel tabPanel;

        private Button btnGeneral;
        private Button btnAppearance;
        private Button btnDashboard;
        private Button btnTimes;
        private Button btnClipboard;

        // =========================================================
        // CONTENT
        // =========================================================

        private Panel contentPanel;

        // =========================================================
        // GENERAL
        // =========================================================

        private Panel generalPage;
        private Label lblGeneralTitle;
        private Label lblGeneralDescription;

        private Panel startupCard;
        private Label lblStartupTitle;
        private Label lblStartupDescription;

        private CheckBox chkStartWithWindows;
        private CheckBox chkStartMinimized;

        // =========================================================
        // APPEARANCE
        // =========================================================

        private Panel appearancePage;
        private Label lblAppearanceTitle;
        private Label lblAppearanceDescription;

        private Panel themeCard;
        private Label lblThemeTitle;
        private Label lblThemeDescription;

        private CheckBox chkDarkMode;

        // =========================================================
        // DASHBOARD
        // =========================================================

        private Panel dashboardPage;
        private Label lblDashboardTitle;
        private Label lblDashboardDescription;

        private Panel dashboardCard;

        private Label lblRefreshTitle;
        private Label lblRefreshDescription;

        private NumericUpDown numRefreshInterval;
        private Label lblRefreshMs;

        private TableLayoutPanel systemChkPanelHold;

        private CheckBox chkSystemNotifications;
        private CheckBox chkSystemCpu;
        private CheckBox chkSystemRam;
        private CheckBox chkSystemDiskUsage;
        private CheckBox chkSystemNetwork;

        // =========================================================
        // TIMES
        // =========================================================

        private Panel timePage;
        private Label lblTimeTitle;
        private Label lblTimeDescription;
        private Panel timeCard;

        private TableLayoutPanel timeChkPanelHold;

        private Panel PomodoroSoundCard;
        private Label lblPomodoroSoundTitle;
        private Label lblPomodoroSoundDescription;
        private TextBox txtPomodoroSoundPath;
        private Button btnBrowsePomodoroSound;

        private Panel AlarmSoundCard;
        private Label lblAlarmSoundTitle;
        private Label lblAlarmSoundDescription;
        private TextBox txtAlarmSoundPath;
        private Button btnBrowseAlarmSound;

        // =========================================================
        // CLIPBOARD
        // =========================================================

        private Panel clipboardPage;
        private Label lblClipboardTitle;
        private Label lblClipboardDescription;

        private Panel clipboardCard;

        private Label lblClipboardMonitoring;
        private Label lblClipboardMonitoringDescription;

        private CheckBox chkClipboardEnabled;

        // =========================================================
        // BUTTONS
        // =========================================================

        private Button btnApply;
        private Button btnReset;

        // =========================================================
        // DISPOSE
        // =========================================================

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

            // =====================================================
            // CREATE CONTROLS
            // =====================================================

            settingsPanel = new Panel();

            tabPanel = new Panel();

            btnGeneral = new Button();
            btnAppearance = new Button();
            btnDashboard = new Button();
            btnTimes = new Button();
            btnClipboard = new Button();

            contentPanel = new Panel();

            // General
            generalPage = new Panel();
            lblGeneralTitle = new Label();
            lblGeneralDescription = new Label();

            startupCard = new Panel();
            lblStartupTitle = new Label();
            lblStartupDescription = new Label();

            chkStartWithWindows = new CheckBox();
            chkStartMinimized = new CheckBox();

            // Appearance
            appearancePage = new Panel();
            lblAppearanceTitle = new Label();
            lblAppearanceDescription = new Label();

            themeCard = new Panel();
            lblThemeTitle = new Label();
            lblThemeDescription = new Label();

            chkDarkMode = new CheckBox();

            // Dashboard
            dashboardPage = new Panel();
            lblDashboardTitle = new Label();
            lblDashboardDescription = new Label();

            dashboardCard = new Panel();

            lblRefreshTitle = new Label();
            lblRefreshDescription = new Label();

            numRefreshInterval = new NumericUpDown();
            lblRefreshMs = new Label();

            systemChkPanelHold =
                new TableLayoutPanel();

            chkSystemNotifications = new CheckBox();
            chkSystemCpu = new CheckBox();
            chkSystemRam = new CheckBox();
            chkSystemDiskUsage = new CheckBox();
            chkSystemNetwork = new CheckBox();

            // Times
            timePage = new Panel();

            lblTimeTitle = new Label();
            lblTimeDescription = new Label();

            timeCard = new Panel();

            PomodoroSoundCard = new Panel();
            lblPomodoroSoundTitle = new Label();
            lblPomodoroSoundDescription = new Label();
            txtPomodoroSoundPath = new TextBox();
            btnBrowsePomodoroSound = new Button();

            AlarmSoundCard = new Panel();
            lblAlarmSoundTitle = new Label();
            lblAlarmSoundDescription = new Label();
            txtAlarmSoundPath = new TextBox();
            btnBrowseAlarmSound = new Button();

            // Clipboard
            clipboardPage = new Panel();
            lblClipboardTitle = new Label();
            lblClipboardDescription = new Label();

            clipboardCard = new Panel();

            lblClipboardMonitoring = new Label();
            lblClipboardMonitoringDescription = new Label();

            chkClipboardEnabled = new CheckBox();

            // Buttons
            btnApply = new Button();
            btnReset = new Button();

            SuspendLayout();

            // =====================================================
            // SETTINGS PANEL
            // =====================================================

            settingsPanel.Dock =
                DockStyle.Fill;

            settingsPanel.BackColor =
                DarkMode
                    ? DarkColor
                    : LightColor;

            settingsPanel.Padding =
                new Padding(0);

            // =====================================================
            // TOP TAB PANEL
            // =====================================================

            tabPanel.Dock =
                DockStyle.Top;

            tabPanel.Height =
                55;

            tabPanel.BackColor =
                DarkMode
                    ? DarkColor
                    : LightColor;

            // =====================================================
            // TABS
            // =====================================================

            ConfigureTabButton(
                btnGeneral,
                "General",
                0);

            ConfigureTabButton(
                btnAppearance,
                "Appearance",
                1);

            ConfigureTabButton(
                btnDashboard,
                "Dashboard",
                2);

            ConfigureTabButton(
                btnTimes,
                "Times",
                3);

            ConfigureTabButton(
                btnClipboard,
                "Clipboard",
                4);

            tabPanel.Controls.Add(
                btnClipboard);

            tabPanel.Controls.Add(
                btnDashboard);

            tabPanel.Controls.Add(
                btnTimes);

            tabPanel.Controls.Add(
                btnAppearance);

            tabPanel.Controls.Add(
                btnGeneral);

            // =====================================================
            // CONTENT PANEL
            // =====================================================

            contentPanel.Dock =
                DockStyle.Fill;

            contentPanel.BackColor =
                DarkMode
                    ? DarkColor
                    : LightColor;

            contentPanel.Padding =
                new Padding(0, 20, 0, 0);

            // =====================================================
            // GENERAL PAGE
            // =====================================================

            generalPage.Dock =
                DockStyle.Fill;

            generalPage.BackColor =
                DarkMode
                    ? DarkColor
                    : LightColor;

            // Title
            lblGeneralTitle.AutoSize =
                true;

            lblGeneralTitle.Text =
                "General";

            lblGeneralTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            lblGeneralTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblGeneralTitle.Location =
                new Point(0, 0);

            // Description
            lblGeneralDescription.AutoSize =
                true;

            lblGeneralDescription.Text =
                "General application settings.";

            lblGeneralDescription.Font =
                new Font(
                    "Segoe UI",
                    10F);

            lblGeneralDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblGeneralDescription.Location =
                new Point(0, 38);

            // =====================================================
            // STARTUP CARD
            // =====================================================

            ConfigureSettingsCard(
                startupCard);

            startupCard.Location =
                new Point(0, 85);

            startupCard.Size =
                new Size(600, 150);

            // Startup title
            lblStartupTitle.AutoSize =
                true;

            lblStartupTitle.Text =
                "Startup";

            lblStartupTitle.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblStartupTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblStartupTitle.Location =
                new Point(20, 15);

            // Startup description
            lblStartupDescription.AutoSize =
                true;

            lblStartupDescription.Text =
                "Choose how the application behaves when Windows starts.";

            lblStartupDescription.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblStartupDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblStartupDescription.Location =
                new Point(20, 42);

            // Start Windows
            ConfigureCheckBox(
                chkStartWithWindows);

            chkStartWithWindows.Text =
                "Start with Windows";

            chkStartWithWindows.Location =
                new Point(20, 75);

            // Start minimized
            ConfigureCheckBox(
                chkStartMinimized);

            chkStartMinimized.Text =
                "Start minimized";

            chkStartMinimized.Location =
                new Point(230, 75);

            startupCard.Controls.Add(
                chkStartMinimized);

            startupCard.Controls.Add(
                chkStartWithWindows);

            startupCard.Controls.Add(
                lblStartupDescription);

            startupCard.Controls.Add(
                lblStartupTitle);

            generalPage.Controls.Add(
                startupCard);

            generalPage.Controls.Add(
                lblGeneralDescription);

            generalPage.Controls.Add(
                lblGeneralTitle);

            // =====================================================
            // APPEARANCE PAGE
            // =====================================================

            appearancePage.Dock =
                DockStyle.Fill;

            appearancePage.BackColor =
                DarkMode
                    ? DarkColor
                    : LightColor;

            // Title
            lblAppearanceTitle.AutoSize =
                true;

            lblAppearanceTitle.Text =
                "Appearance";

            lblAppearanceTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            lblAppearanceTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblAppearanceTitle.Location =
                new Point(0, 0);

            // Description
            lblAppearanceDescription.AutoSize =
                true;

            lblAppearanceDescription.Text =
                "Customize how DevDashboard looks.";

            lblAppearanceDescription.Font =
                new Font(
                    "Segoe UI",
                    10F);

            lblAppearanceDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblAppearanceDescription.Location =
                new Point(0, 38);

            // =====================================================
            // THEME CARD
            // =====================================================

            ConfigureSettingsCard(
                themeCard);

            themeCard.Location =
                new Point(0, 85);

            themeCard.Size =
                new Size(600, 125);

            lblThemeTitle.AutoSize =
                true;

            lblThemeTitle.Text =
                "Theme";

            lblThemeTitle.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblThemeTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblThemeTitle.Location =
                new Point(20, 15);

            lblThemeDescription.AutoSize =
                true;

            lblThemeDescription.Text =
                "Use the dark theme throughout the application.";

            lblThemeDescription.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblThemeDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblThemeDescription.Location =
                new Point(20, 42);

            ConfigureCheckBox(
                chkDarkMode);

            chkDarkMode.Text =
                "Dark Mode";

            chkDarkMode.Location =
                new Point(20, 75);

            chkDarkMode.Checked =
                DarkMode;

            themeCard.Controls.Add(
                chkDarkMode);

            themeCard.Controls.Add(
                lblThemeDescription);

            themeCard.Controls.Add(
                lblThemeTitle);

            appearancePage.Controls.Add(
                themeCard);

            appearancePage.Controls.Add(
                lblAppearanceDescription);

            appearancePage.Controls.Add(
                lblAppearanceTitle);

            // =====================================================
            // DASHBOARD PAGE
            // =====================================================

            dashboardPage.Dock =
                DockStyle.Fill;

            dashboardPage.BackColor =
                DarkMode
                    ? DarkColor
                    : LightColor;

            // Title
            lblDashboardTitle.AutoSize =
                true;

            lblDashboardTitle.Text =
                "Dashboard";

            lblDashboardTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            lblDashboardTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblDashboardTitle.Location =
                new Point(0, 0);

            // Description
            lblDashboardDescription.AutoSize =
                true;

            lblDashboardDescription.Text =
                "Configure dashboard system information.";

            lblDashboardDescription.Font =
                new Font(
                    "Segoe UI",
                    10F);

            lblDashboardDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblDashboardDescription.Location =
                new Point(0, 38);

            // =====================================================
            // DASHBOARD CARD
            // =====================================================

            ConfigureSettingsCard(
                dashboardCard);

            dashboardCard.Location =
                new Point(0, 85);

            dashboardCard.Size =
                new Size(600, 270);

            // -----------------------------------------------------
            // TITLE
            // -----------------------------------------------------

            lblRefreshTitle.AutoSize =
                true;

            lblRefreshTitle.Text =
                "System Information";

            lblRefreshTitle.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblRefreshTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblRefreshTitle.Location =
                new Point(20, 15);

            // -----------------------------------------------------
            // DESCRIPTION
            // -----------------------------------------------------

            lblRefreshDescription.AutoSize =
                true;

            lblRefreshDescription.Text =
                "Set how often CPU, RAM, disk and network information is updated.";

            lblRefreshDescription.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblRefreshDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblRefreshDescription.Location =
                new Point(20, 42);

            // -----------------------------------------------------
            // REFRESH INTERVAL
            // -----------------------------------------------------

            numRefreshInterval.Minimum =
                500;

            numRefreshInterval.Maximum =
                60000;

            numRefreshInterval.Increment =
                500;

            numRefreshInterval.Value =
                2500;

            numRefreshInterval.Size =
                new Size(120, 30);

            numRefreshInterval.Location =
                new Point(20, 72);

            numRefreshInterval.BackColor =
                DarkMode
                    ? Color.FromArgb(35, 35, 38)
                    : Color.White;

            numRefreshInterval.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            // -----------------------------------------------------
            // MILLISECONDS LABEL
            // -----------------------------------------------------

            lblRefreshMs.AutoSize =
                true;

            lblRefreshMs.Text =
                "milliseconds";

            lblRefreshMs.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblRefreshMs.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblRefreshMs.Location =
                new Point(150, 77);

            // =====================================================
            // SYSTEM CHECKBOX PANEL
            // =====================================================

            ConfigureSystemCardsPanel(
                systemChkPanelHold);

            systemChkPanelHold.Location =
                new Point(20, 115);

            systemChkPanelHold.Size =
                new Size(560, 125);

            systemChkPanelHold.Dock =
                DockStyle.None;

            // CPU
            ConfigureCheckBox(
                chkSystemCpu);

            chkSystemCpu.Text =
                "Show system CPU";

            // RAM
            ConfigureCheckBox(
                chkSystemRam);

            chkSystemRam.Text =
                "Show system RAM";

            // DISK
            ConfigureCheckBox(
                chkSystemDiskUsage);

            chkSystemDiskUsage.Text =
                "Show disk usage";

            // NETWORK
            ConfigureCheckBox(
                chkSystemNetwork);

            chkSystemNetwork.Text =
                "Show network";

            // NOTIFICATIONS
            ConfigureCheckBox(
                chkSystemNotifications);

            chkSystemNotifications.Text =
                "Show notifications";

            // ADD CHECKBOXES

            systemChkPanelHold.Controls.Add(
                chkSystemCpu,
                0,
                0);

            systemChkPanelHold.Controls.Add(
                chkSystemRam,
                1,
                0);

            systemChkPanelHold.Controls.Add(
                chkSystemDiskUsage,
                0,
                1);

            systemChkPanelHold.Controls.Add(
                chkSystemNetwork,
                1,
                1);

            systemChkPanelHold.Controls.Add(
                chkSystemNotifications,
                0,
                2);

            // ADD DASHBOARD CONTROLS

            dashboardCard.Controls.Add(
                systemChkPanelHold);

            dashboardCard.Controls.Add(
                lblRefreshMs);

            dashboardCard.Controls.Add(
                numRefreshInterval);

            dashboardCard.Controls.Add(
                lblRefreshDescription);

            dashboardCard.Controls.Add(
                lblRefreshTitle);

            dashboardPage.Controls.Add(
                dashboardCard);

            dashboardPage.Controls.Add(
                lblDashboardDescription);

            dashboardPage.Controls.Add(
                lblDashboardTitle);

            // =====================================================
            // TIMES PAGE
            // =====================================================

            timePage.Dock =
                DockStyle.Fill;

            timePage.BackColor =
                DarkMode
                    ? DarkColor
                    : LightColor;

            // Title

            lblTimeTitle.AutoSize =
                true;

            lblTimeTitle.Text =
                "Times";

            lblTimeTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            lblTimeTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblTimeTitle.Location =
                new Point(0, 0);

            // Description

            lblTimeDescription.AutoSize =
                true;

            lblTimeDescription.Text =
                "Configure sounds used by the Pomodoro timer and alarms.";

            lblTimeDescription.Font =
                new Font(
                    "Segoe UI",
                    10F);

            lblTimeDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblTimeDescription.Location =
                new Point(0, 38);

            // =====================================================
            // POMODORO SOUND CARD
            // =====================================================

            ConfigureSettingsCard(
                PomodoroSoundCard);

            PomodoroSoundCard.Location =
                new Point(0, 85);

            PomodoroSoundCard.Size =
                new Size(600, 145);

            lblPomodoroSoundTitle.AutoSize =
                true;

            lblPomodoroSoundTitle.Text =
                "Pomodoro Sound";

            lblPomodoroSoundTitle.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblPomodoroSoundTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblPomodoroSoundTitle.Location =
                new Point(20, 15);

            lblPomodoroSoundDescription.AutoSize =
                true;

            lblPomodoroSoundDescription.Text =
                "Select a WAV or MP3 file to play when a Pomodoro timer ends.";

            lblPomodoroSoundDescription.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblPomodoroSoundDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblPomodoroSoundDescription.Location =
                new Point(20, 42);

            txtPomodoroSoundPath.Location =
                new Point(20, 75);

            txtPomodoroSoundPath.Size =
                new Size(430, 27);

            txtPomodoroSoundPath.BackColor =
                DarkMode
                    ? Color.FromArgb(35, 35, 38)
                    : Color.White;

            txtPomodoroSoundPath.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            txtPomodoroSoundPath.BorderStyle =
                BorderStyle.FixedSingle;

            txtPomodoroSoundPath.ReadOnly =
                true;

            btnBrowsePomodoroSound.Text =
                "Browse...";

            btnBrowsePomodoroSound.Font =
                new Font(
                    "Segoe UI",
                    9F);

            btnBrowsePomodoroSound.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            btnBrowsePomodoroSound.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnBrowsePomodoroSound.FlatStyle =
                FlatStyle.Flat;

            btnBrowsePomodoroSound.FlatAppearance.BorderSize =
                0;

            btnBrowsePomodoroSound.Size =
                new Size(110, 30);

            btnBrowsePomodoroSound.Location =
                new Point(460, 73);

            btnBrowsePomodoroSound.Cursor =
                Cursors.Hand;

            btnBrowsePomodoroSound.UseVisualStyleBackColor =
                false;

            btnBrowsePomodoroSound.Click +=
                btnBrowsePomodoroSound_Click;

            PomodoroSoundCard.Controls.Add(
                btnBrowsePomodoroSound);

            PomodoroSoundCard.Controls.Add(
                txtPomodoroSoundPath);

            PomodoroSoundCard.Controls.Add(
                lblPomodoroSoundDescription);

            PomodoroSoundCard.Controls.Add(
                lblPomodoroSoundTitle);

            // =====================================================
            // ALARM SOUND CARD
            // =====================================================

            ConfigureSettingsCard(
                AlarmSoundCard);

            AlarmSoundCard.Location =
                new Point(0, 245);

            AlarmSoundCard.Size =
                new Size(600, 145);

            lblAlarmSoundTitle.AutoSize =
                true;

            lblAlarmSoundTitle.Text =
                "Alarm Sound";

            lblAlarmSoundTitle.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblAlarmSoundTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblAlarmSoundTitle.Location =
                new Point(20, 15);

            lblAlarmSoundDescription.AutoSize =
                true;

            lblAlarmSoundDescription.Text =
                "Select a WAV or MP3 file to play when an alarm goes off.";

            lblAlarmSoundDescription.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblAlarmSoundDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblAlarmSoundDescription.Location =
                new Point(20, 42);

            txtAlarmSoundPath.Location =
                new Point(20, 75);

            txtAlarmSoundPath.Size =
                new Size(430, 27);

            txtAlarmSoundPath.BackColor =
                DarkMode
                    ? Color.FromArgb(35, 35, 38)
                    : Color.White;

            txtAlarmSoundPath.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            txtAlarmSoundPath.BorderStyle =
                BorderStyle.FixedSingle;

            txtAlarmSoundPath.ReadOnly =
                true;

            btnBrowseAlarmSound.Text =
                "Browse...";

            btnBrowseAlarmSound.Font =
                new Font(
                    "Segoe UI",
                    9F);

            btnBrowseAlarmSound.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            btnBrowseAlarmSound.BackColor =
                DarkMode
                    ? Color.FromArgb(45, 45, 48)
                    : Color.FromArgb(220, 220, 220);

            btnBrowseAlarmSound.FlatStyle =
                FlatStyle.Flat;

            btnBrowseAlarmSound.FlatAppearance.BorderSize =
                0;

            btnBrowseAlarmSound.Size =
                new Size(110, 30);

            btnBrowseAlarmSound.Location =
                new Point(460, 73);

            btnBrowseAlarmSound.Cursor =
                Cursors.Hand;

            btnBrowseAlarmSound.UseVisualStyleBackColor =
                false;

            btnBrowseAlarmSound.Click +=
                btnBrowseAlarmSound_Click;

            AlarmSoundCard.Controls.Add(
                btnBrowseAlarmSound);

            AlarmSoundCard.Controls.Add(
                txtAlarmSoundPath);

            AlarmSoundCard.Controls.Add(
                lblAlarmSoundDescription);

            AlarmSoundCard.Controls.Add(
                lblAlarmSoundTitle);

            timePage.Controls.Add(
                AlarmSoundCard);

            timePage.Controls.Add(
                PomodoroSoundCard);

            timePage.Controls.Add(
                lblTimeDescription);

            timePage.Controls.Add(
                lblTimeTitle);

            // =====================================================
            // CLIPBOARD PAGE
            // =====================================================

            clipboardPage.Dock =
                DockStyle.Fill;

            clipboardPage.BackColor =
                DarkMode
                    ? DarkColor
                    : LightColor;

            lblClipboardTitle.AutoSize =
                true;

            lblClipboardTitle.Text =
                "Clipboard";

            lblClipboardTitle.Font =
                new Font(
                    "Segoe UI",
                    18F,
                    FontStyle.Bold);

            lblClipboardTitle.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblClipboardTitle.Location =
                new Point(0, 0);

            lblClipboardDescription.AutoSize =
                true;

            lblClipboardDescription.Text =
                "Configure clipboard monitoring.";

            lblClipboardDescription.Font =
                new Font(
                    "Segoe UI",
                    10F);

            lblClipboardDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblClipboardDescription.Location =
                new Point(0, 38);

            // =====================================================
            // CLIPBOARD CARD
            // =====================================================

            ConfigureSettingsCard(
                clipboardCard);

            clipboardCard.Location =
                new Point(0, 85);

            clipboardCard.Size =
                new Size(600, 125);

            lblClipboardMonitoring.AutoSize =
                true;

            lblClipboardMonitoring.Text =
                "Clipboard Monitoring";

            lblClipboardMonitoring.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblClipboardMonitoring.ForeColor =
                DarkMode
                    ? Color.White
                    : Color.Black;

            lblClipboardMonitoring.Location =
                new Point(20, 15);

            lblClipboardMonitoringDescription.AutoSize =
                true;

            lblClipboardMonitoringDescription.Text =
                "Monitor clipboard changes in the background.";

            lblClipboardMonitoringDescription.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblClipboardMonitoringDescription.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.FromArgb(70, 70, 70);

            lblClipboardMonitoringDescription.Location =
                new Point(20, 42);

            ConfigureCheckBox(
                chkClipboardEnabled);

            chkClipboardEnabled.Text =
                "Enable clipboard monitoring";

            chkClipboardEnabled.Location =
                new Point(20, 75);

            clipboardCard.Controls.Add(
                chkClipboardEnabled);

            clipboardCard.Controls.Add(
                lblClipboardMonitoringDescription);

            clipboardCard.Controls.Add(
                lblClipboardMonitoring);

            clipboardPage.Controls.Add(
                clipboardCard);

            clipboardPage.Controls.Add(
                lblClipboardDescription);

            clipboardPage.Controls.Add(
                lblClipboardTitle);

            // =====================================================
            // ADD PAGES
            // =====================================================

            contentPanel.Controls.Add(
                clipboardPage);

            contentPanel.Controls.Add(
                timePage);

            contentPanel.Controls.Add(
                dashboardPage);

            contentPanel.Controls.Add(
                appearancePage);

            contentPanel.Controls.Add(
                generalPage);

            // =====================================================
            // APPLY BUTTON
            // =====================================================

            btnApply.Text =
                "Apply";

            btnApply.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            btnApply.ForeColor =
                Color.White;

            btnApply.BackColor =
                Color.FromArgb(
                    45,
                    45,
                    48);

            btnApply.FlatStyle =
                FlatStyle.Flat;

            btnApply.FlatAppearance.BorderSize =
                0;

            btnApply.Size =
                new Size(100, 38);

            btnApply.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            btnApply.Location =
                new Point(
                    100,
                    60);

            btnApply.Cursor =
                Cursors.Hand;

            btnApply.UseVisualStyleBackColor =
                false;

            btnApply.Click +=
                btnApply_Click;

            // =====================================================
            // RESET BUTTON
            // =====================================================

            btnReset.Text =
                "Reset";

            btnReset.Font =
                new Font(
                    "Segoe UI",
                    10F);

            btnReset.ForeColor =
                Color.Gainsboro;

            btnReset.BackColor =
                Color.FromArgb(
                    28,
                    28,
                    30);

            btnReset.FlatStyle =
                FlatStyle.Flat;

            btnReset.FlatAppearance.BorderSize =
                0;

            btnReset.Size =
                new Size(100, 38);

            btnReset.Location =
                new Point(
                    -25,
                    60);

            btnReset.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

            btnReset.UseVisualStyleBackColor =
                false;

            // =====================================================
            // MAIN PANEL
            // =====================================================

            settingsPanel.Controls.Add(
                btnApply);

            settingsPanel.Controls.Add(
                btnReset);

            settingsPanel.Controls.Add(
                contentPanel);

            settingsPanel.Controls.Add(
                tabPanel);

            Controls.Add(
                settingsPanel);

            // =====================================================
            // EVENTS
            // =====================================================

            btnGeneral.Click +=
                btnGeneral_Click;

            btnAppearance.Click +=
                btnAppearance_Click;

            btnDashboard.Click +=
                btnDashboard_Click;

            btnTimes.Click +=
                btnTimes_Click;

            btnClipboard.Click +=
                btnClipboard_Click;

            btnApply.Click +=
                btnApply_Click;

            btnReset.Click +=
                btnReset_Click;

            chkDarkMode.CheckedChanged +=
                chkDarkMode_CheckedChanged;

            // =====================================================
            // INITIAL PAGE
            // =====================================================

            generalPage.Visible =
                true;

            appearancePage.Visible =
                false;

            dashboardPage.Visible =
                false;

            timePage.Visible =
                false;

            clipboardPage.Visible =
                false;

            SetSelectedTab(
                btnGeneral);

            // =====================================================
            // USER CONTROL
            // =====================================================

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                DarkMode
                    ? DarkColor
                    : LightColor;

            Dock =
                DockStyle.Fill;

            Name =
                "SettingsControl";

            // =====================================================
            // APPLY INITIAL THEME
            // =====================================================

            ApplyTheme();

            ResumeLayout(false);
        }

        #endregion

        // =========================================================
        // THEME
        // =========================================================

        private void ApplyTheme()
        {
            Color bg = DarkMode
                ? DarkColor
                : LightColor;

            Color panelBackground = DarkMode
                ? Color.FromArgb(28, 28, 30)
                : Color.FromArgb(225, 225, 225);

            Color cardBackground = DarkMode
                ? Color.FromArgb(28, 28, 30)
                : Color.FromArgb(235, 235, 235);

            Color foreground = DarkMode
                ? Color.Gainsboro
                : Color.Black;

            Color titleForeground = DarkMode
                ? Color.White
                : Color.Black;

            Color secondaryForeground = DarkMode
                ? Color.Gainsboro
                : Color.FromArgb(70, 70, 70);

            Color inputBackground = DarkMode
                ? Color.FromArgb(35, 35, 38)
                : Color.White;

            Color inputForeground = DarkMode
                ? Color.White
                : Color.Black;

            Color buttonBackground = DarkMode
                ? Color.FromArgb(45, 45, 48)
                : Color.FromArgb(220, 220, 220);

            Color buttonForeground = DarkMode
                ? Color.White
                : Color.Black;

            Color tabBackground = DarkMode
                ? Color.FromArgb(18, 18, 18)
                : Color.FromArgb(240, 240, 240);

            Color tabHoverBackground = DarkMode
                ? Color.FromArgb(28, 28, 30)
                : Color.FromArgb(220, 220, 220);

            // =====================================================
            // MAIN
            // =====================================================

            BackColor = bg;

            if (settingsPanel != null)
                settingsPanel.BackColor = bg;

            if (tabPanel != null)
                tabPanel.BackColor = tabBackground;

            if (contentPanel != null)
                contentPanel.BackColor = bg;

            // =====================================================
            // PAGES
            // =====================================================

            if (generalPage != null)
                generalPage.BackColor = bg;

            if (appearancePage != null)
                appearancePage.BackColor = bg;

            if (dashboardPage != null)
                dashboardPage.BackColor = bg;

            if (timePage != null)
                timePage.BackColor = bg;

            if (clipboardPage != null)
                clipboardPage.BackColor = bg;

            // =====================================================
            // TABS
            // =====================================================

            ApplyTabTheme(
                btnGeneral,
                tabBackground,
                foreground,
                tabHoverBackground);

            ApplyTabTheme(
                btnAppearance,
                tabBackground,
                foreground,
                tabHoverBackground);

            ApplyTabTheme(
                btnDashboard,
                tabBackground,
                foreground,
                tabHoverBackground);

            ApplyTabTheme(
                btnTimes,
                tabBackground,
                foreground,
                tabHoverBackground);

            ApplyTabTheme(
                btnClipboard,
                tabBackground,
                foreground,
                tabHoverBackground);

            // =====================================================
            // GENERAL
            // =====================================================

            ApplyLabelTheme(
                lblGeneralTitle,
                titleForeground);

            ApplyLabelTheme(
                lblGeneralDescription,
                secondaryForeground);

            ApplyLabelTheme(
                lblStartupTitle,
                titleForeground);

            ApplyLabelTheme(
                lblStartupDescription,
                secondaryForeground);

            if (startupCard != null)
                startupCard.BackColor = cardBackground;

            ApplyCheckBoxTheme(
                chkStartWithWindows,
                foreground);

            ApplyCheckBoxTheme(
                chkStartMinimized,
                foreground);

            // =====================================================
            // APPEARANCE
            // =====================================================

            ApplyLabelTheme(
                lblAppearanceTitle,
                titleForeground);

            ApplyLabelTheme(
                lblAppearanceDescription,
                secondaryForeground);

            ApplyLabelTheme(
                lblThemeTitle,
                titleForeground);

            ApplyLabelTheme(
                lblThemeDescription,
                secondaryForeground);

            if (themeCard != null)
                themeCard.BackColor = cardBackground;

            ApplyCheckBoxTheme(
                chkDarkMode,
                foreground);

            // =====================================================
            // DASHBOARD
            // =====================================================

            ApplyLabelTheme(
                lblDashboardTitle,
                titleForeground);

            ApplyLabelTheme(
                lblDashboardDescription,
                secondaryForeground);

            ApplyLabelTheme(
                lblRefreshTitle,
                titleForeground);

            ApplyLabelTheme(
                lblRefreshDescription,
                secondaryForeground);

            ApplyLabelTheme(
                lblRefreshMs,
                secondaryForeground);

            if (dashboardCard != null)
                dashboardCard.BackColor = cardBackground;

            if (numRefreshInterval != null)
            {
                numRefreshInterval.BackColor =
                    inputBackground;

                numRefreshInterval.ForeColor =
                    inputForeground;
            }

            ApplyCheckBoxTheme(
                chkSystemCpu,
                foreground);

            ApplyCheckBoxTheme(
                chkSystemRam,
                foreground);

            ApplyCheckBoxTheme(
                chkSystemDiskUsage,
                foreground);

            ApplyCheckBoxTheme(
                chkSystemNetwork,
                foreground);

            ApplyCheckBoxTheme(
                chkSystemNotifications,
                foreground);

            if (systemChkPanelHold != null)
                systemChkPanelHold.BackColor =
                    Color.Transparent;

            // =====================================================
            // TIMES
            // =====================================================

            ApplyLabelTheme(
                lblTimeTitle,
                titleForeground);

            ApplyLabelTheme(
                lblTimeDescription,
                secondaryForeground);

            if (PomodoroSoundCard != null)
                PomodoroSoundCard.BackColor =
                    cardBackground;

            if (AlarmSoundCard != null)
                AlarmSoundCard.BackColor =
                    cardBackground;

            ApplyLabelTheme(
                lblPomodoroSoundTitle,
                titleForeground);

            ApplyLabelTheme(
                lblPomodoroSoundDescription,
                secondaryForeground);

            ApplyLabelTheme(
                lblAlarmSoundTitle,
                titleForeground);

            ApplyLabelTheme(
                lblAlarmSoundDescription,
                secondaryForeground);

            if (txtPomodoroSoundPath != null)
            {
                txtPomodoroSoundPath.BackColor =
                    inputBackground;

                txtPomodoroSoundPath.ForeColor =
                    inputForeground;
            }

            if (txtAlarmSoundPath != null)
            {
                txtAlarmSoundPath.BackColor =
                    inputBackground;

                txtAlarmSoundPath.ForeColor =
                    inputForeground;
            }

            ApplyButtonTheme(
                btnBrowsePomodoroSound,
                buttonBackground,
                buttonForeground);

            ApplyButtonTheme(
                btnBrowseAlarmSound,
                buttonBackground,
                buttonForeground);

            // =====================================================
            // CLIPBOARD
            // =====================================================

            ApplyLabelTheme(
                lblClipboardTitle,
                titleForeground);

            ApplyLabelTheme(
                lblClipboardDescription,
                secondaryForeground);

            ApplyLabelTheme(
                lblClipboardMonitoring,
                titleForeground);

            ApplyLabelTheme(
                lblClipboardMonitoringDescription,
                secondaryForeground);

            if (clipboardCard != null)
                clipboardCard.BackColor =
                    cardBackground;

            ApplyCheckBoxTheme(
                chkClipboardEnabled,
                foreground);

            // =====================================================
            // BUTTONS
            // =====================================================

            ApplyButtonTheme(
                btnApply,
                buttonBackground,
                buttonForeground);

            ApplyButtonTheme(
                btnReset,
                cardBackground,
                foreground);

            // =====================================================
            // REDRAW
            // =====================================================

            Invalidate();
            Update();
        }

        // =========================================================
        // LABEL THEME
        // =========================================================

        private void ApplyLabelTheme(
            Label label,
            Color foreground)
        {
            if (label == null)
                return;

            label.ForeColor =
                foreground;
        }

        // =========================================================
        // CHECKBOX THEME
        // =========================================================

        private void ApplyCheckBoxTheme(
            CheckBox checkBox,
            Color foreground)
        {
            if (checkBox == null)
                return;

            checkBox.ForeColor =
                foreground;

            checkBox.BackColor =
                Color.Transparent;
        }

        // =========================================================
        // BUTTON THEME
        // =========================================================

        private void ApplyButtonTheme(
            Button button,
            Color background,
            Color foreground)
        {
            if (button == null)
                return;

            button.BackColor =
                background;

            button.ForeColor =
                foreground;

            button.UseVisualStyleBackColor =
                false;
        }

        // =========================================================
        // TAB THEME
        // =========================================================

        private void ApplyTabTheme(
            Button button,
            Color background,
            Color foreground,
            Color hoverBackground)
        {
            if (button == null)
                return;

            button.BackColor =
                background;

            button.ForeColor =
                foreground;

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize =
                0;

            button.FlatAppearance.MouseOverBackColor =
                hoverBackground;

            button.UseVisualStyleBackColor =
                false;
        }

        // =========================================================
        // TIMES - SOUND FILE PICKERS
        // =========================================================

        private void btnBrowsePomodoroSound_Click(
            object sender,
            EventArgs e)
        {
            using (OpenFileDialog dialog =
                   new OpenFileDialog())
            {
                dialog.Title =
                    "Select Pomodoro Sound";

                dialog.Filter =
                    "Audio files (*.wav;*.mp3)|*.wav;*.mp3|" +
                    "WAV files (*.wav)|*.wav|" +
                    "MP3 files (*.mp3)|*.mp3|" +
                    "All files (*.*)|*.*";

                dialog.CheckFileExists =
                    true;

                dialog.Multiselect =
                    false;

                if (dialog.ShowDialog() ==
                    DialogResult.OK)
                {
                    txtPomodoroSoundPath.Text =
                        dialog.FileName;
                }
            }
        }

        private void btnBrowseAlarmSound_Click(
            object sender,
            EventArgs e)
        {
            using (OpenFileDialog dialog =
                   new OpenFileDialog())
            {
                dialog.Title =
                    "Select Alarm Sound";

                dialog.Filter =
                    "Audio files (*.wav;*.mp3)|*.wav;*.mp3|" +
                    "WAV files (*.wav)|*.wav|" +
                    "MP3 files (*.mp3)|*.mp3|" +
                    "All files (*.*)|*.*";

                dialog.CheckFileExists =
                    true;

                dialog.Multiselect =
                    false;

                if (dialog.ShowDialog() ==
                    DialogResult.OK)
                {
                    txtAlarmSoundPath.Text =
                        dialog.FileName;
                }
            }
        }

        // =========================================================
        // TAB BUTTON
        // =========================================================

        private void ConfigureTabButton(
            Button button,
            string text,
            int index)
        {
            button.Text =
                text;

            button.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);

            button.TextAlign =
                ContentAlignment.MiddleCenter;

            button.Padding =
                new Padding(
                    10,
                    0,
                    10,
                    0);

            button.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            button.BackColor =
                DarkMode
                    ? Color.FromArgb(18, 18, 18)
                    : Color.FromArgb(240, 240, 240);

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize =
                0;

            button.FlatAppearance.MouseOverBackColor =
                DarkMode
                    ? Color.FromArgb(28, 28, 30)
                    : Color.FromArgb(220, 220, 220);

            button.Size =
                new Size(
                    130,
                    45);

            button.Location =
                new Point(
                    index * 135,
                    5);

            button.Cursor =
                Cursors.Hand;

            button.UseVisualStyleBackColor =
                false;
        }

        // =========================================================
        // SETTINGS CARD
        // =========================================================

        private void ConfigureSettingsCard(
            Panel card)
        {
            card.BackColor =
                DarkMode
                    ? Color.FromArgb(28, 28, 30)
                    : Color.FromArgb(235, 235, 235);

            card.Padding =
                new Padding(20);

            card.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;
        }

        // =========================================================
        // CHECKBOX
        // =========================================================

        private void ConfigureCheckBox(
            CheckBox checkBox)
        {
            checkBox.AutoSize =
                true;

            checkBox.Font =
                new Font(
                    "Segoe UI",
                    9F);

            checkBox.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            checkBox.BackColor =
                Color.Transparent;

            checkBox.Cursor =
                Cursors.Hand;
        }

        // =========================================================
        // SYSTEM CHECKBOX PANEL
        // =========================================================

        private void ConfigureSystemCardsPanel(
            TableLayoutPanel panel)
        {
            panel.ColumnCount =
                2;

            panel.RowCount =
                3;

            panel.AutoSize =
                false;

            panel.ColumnStyles.Clear();
            panel.RowStyles.Clear();

            // Two equal columns

            panel.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            panel.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            // Three equal rows

            panel.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    38F));

            panel.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    38F));

            panel.RowStyles.Add(
                new RowStyle(
                    SizeType.Absolute,
                    38F));

            panel.Padding =
                new Padding(0);

            panel.Margin =
                new Padding(0);

            panel.BackColor =
                Color.Transparent;
        }
    }
}
