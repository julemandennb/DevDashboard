namespace DevDashboard.Control
{
    partial class SettingsControl
    {
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

        private CheckBox chkSystemNotifications;

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

            chkSystemNotifications = new CheckBox();

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
                Color.FromArgb(18, 18, 18);

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
                Color.FromArgb(18, 18, 18);

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
                btnClipboard,
                "Clipboard",
                3);

            tabPanel.Controls.Add(
                btnClipboard);

            tabPanel.Controls.Add(
                btnDashboard);

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
                Color.FromArgb(18, 18, 18);

            contentPanel.Padding =
                new Padding(0, 20, 0, 0);

            // =====================================================
            // GENERAL PAGE
            // =====================================================

            generalPage.Dock =
                DockStyle.Fill;

            generalPage.BackColor =
                Color.FromArgb(18, 18, 18);

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
                Color.White;

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
                Color.Gainsboro;

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
                Color.White;

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
                Color.Gainsboro;

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
                Color.FromArgb(18, 18, 18);

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
                Color.White;

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
                Color.Gainsboro;

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
                Color.White;

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
                Color.Gainsboro;

            lblThemeDescription.Location =
                new Point(20, 42);

            ConfigureCheckBox(
                chkDarkMode);

            chkDarkMode.Text =
                "Dark Mode";

            chkDarkMode.Location =
                new Point(20, 75);

            chkDarkMode.Checked =
                true;

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
                Color.FromArgb(18, 18, 18);

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
                Color.White;

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
                Color.Gainsboro;

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
                new Size(600, 190);

            // Refresh title
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
                Color.White;

            lblRefreshTitle.Location =
                new Point(20, 15);

            // Refresh description
            lblRefreshDescription.AutoSize =
                true;

            lblRefreshDescription.Text =
                "Set how often CPU, RAM, disk and network information is updated.";

            lblRefreshDescription.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblRefreshDescription.ForeColor =
                Color.Gainsboro;

            lblRefreshDescription.Location =
                new Point(20, 42);

            // Numeric refresh interval
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
                new Point(20, 75);

            numRefreshInterval.BackColor =
                Color.FromArgb(35, 35, 38);

            numRefreshInterval.ForeColor =
                Color.White;

            // Milliseconds
            lblRefreshMs.AutoSize =
                true;

            lblRefreshMs.Text =
                "milliseconds";

            lblRefreshMs.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblRefreshMs.ForeColor =
                Color.Gainsboro;

            lblRefreshMs.Location =
                new Point(150, 80);

            // Notifications
            ConfigureCheckBox(
                chkSystemNotifications);

            chkSystemNotifications.Text =
                "Show system notifications";

            chkSystemNotifications.Location =
                new Point(20, 125);

            dashboardCard.Controls.Add(
                chkSystemNotifications);

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
            // CLIPBOARD PAGE
            // =====================================================

            clipboardPage.Dock =
                DockStyle.Fill;

            clipboardPage.BackColor =
                Color.FromArgb(18, 18, 18);

            // Title
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
                Color.White;

            lblClipboardTitle.Location =
                new Point(0, 0);

            // Description
            lblClipboardDescription.AutoSize =
                true;

            lblClipboardDescription.Text =
                "Configure clipboard monitoring.";

            lblClipboardDescription.Font =
                new Font(
                    "Segoe UI",
                    10F);

            lblClipboardDescription.ForeColor =
                Color.Gainsboro;

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
                Color.White;

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
                Color.Gainsboro;

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
                Color.FromArgb(45, 45, 48);

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
                    100, 60);

            btnApply.Cursor =
                Cursors.Hand;

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
                Color.FromArgb(28, 28, 30);

            btnReset.FlatStyle =
                FlatStyle.Flat;

            btnReset.FlatAppearance.BorderSize =
                0;

            btnReset.Size =
                new Size(100, 38);

            btnReset.Location =
              new Point(
                 -25, 60);

            btnReset.Anchor =
                AnchorStyles.Bottom |
                AnchorStyles.Right;

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

            generalPage.Visible = true;

            appearancePage.Visible = false;

            dashboardPage.Visible = false;

            clipboardPage.Visible = false;

            SetSelectedTab(
                btnGeneral);

            // =====================================================
            // USER CONTROL
            // =====================================================

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(18, 18, 18);

            Dock =
                DockStyle.Fill;

            Name =
                "SettingsControl";

            ResumeLayout(false);
        }

        #endregion

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
                new Padding(10, 0, 10, 0);

            button.ForeColor =
                Color.Gainsboro;

            button.BackColor =
                Color.FromArgb(18, 18, 18);

            button.FlatStyle =
                FlatStyle.Flat;

            button.FlatAppearance.BorderSize =
                0;

            button.FlatAppearance.MouseOverBackColor =
                Color.FromArgb(28, 28, 30);

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
                Color.FromArgb(28, 28, 30);

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
                Color.Gainsboro;

            checkBox.BackColor =
                Color.Transparent;

            checkBox.Cursor =
                Cursors.Hand;
        }
    }
}
