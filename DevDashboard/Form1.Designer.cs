namespace DevDashboard
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private bool darkMode = true;

        public bool DarkMode
        {
            get => darkMode;
            set
            {
                if (darkMode == value) return;
                darkMode = value;
                ApplyTheme();
            }
        }

        private Color Darkcolor = Color.FromArgb(18, 18, 18);

        private Color Lightcolor = Color.FromArgb(240, 240, 240);

        private Panel sidebarPanel;
        private Panel contentPanel;
        private Label lblLogo;

        private Button btnDashboard;
        private Button btnTimers;
        private Button btnClipboard;
        private Button btnLauncher;
        private Button btnGitHub;
        private Button btnSettings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            sidebarPanel = new Panel();
            contentPanel = new Panel();
            lblLogo = new Label();

            btnDashboard = new Button();
            btnTimers = new Button();
            btnClipboard = new Button();
            btnLauncher = new Button();
            btnGitHub = new Button();
            btnSettings = new Button();

            SuspendLayout();

            // =========================================================
            // FORM
            // =========================================================

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = DarkMode ? Darkcolor : Lightcolor;
            ClientSize = new Size(1100, 700);
            MinimumSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DevDashboard";

            // =========================================================
            // SIDEBAR
            // =========================================================

            sidebarPanel.BackColor = DarkMode ? Color.FromArgb(24, 24, 24) : Color.FromArgb(234, 234, 234);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Padding = new Padding(15);
            sidebarPanel.Size = new Size(210, 700);

            // Logo
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold);

            lblLogo.ForeColor = DarkMode ? Color.White : Color.Black;
            lblLogo.Location = new Point(5, 25);
            lblLogo.Text = "⚡ DevDashboard";

            sidebarPanel.Controls.Add(lblLogo);

            // Dashboard
            ConfigureMenuButton(
                btnDashboard,
                "⌂  Dashboard",
                75);

            btnDashboard.Click += btnDashboard_Click;

            sidebarPanel.Controls.Add(btnDashboard);

            // Pomodoro
            ConfigureMenuButton(
                btnTimers,
                "◷  Times",
                125);

            btnTimers.Click += btnTimers_Click;

            sidebarPanel.Controls.Add(btnTimers);

            // Clipboard
            ConfigureMenuButton(
                btnClipboard,
                "▣  Clipboard",
                175);

            btnClipboard.Click += btnClipboard_Click;

            sidebarPanel.Controls.Add(btnClipboard);

            // Launcher
            ConfigureMenuButton(
                btnLauncher,
                "🚀  Launcher",
                225);

            btnLauncher.Click += btnLauncher_Click;

            sidebarPanel.Controls.Add(btnLauncher);

            // GitHub
            ConfigureMenuButton(
                btnGitHub,
                "◉  GitHub",
                275);

            btnGitHub.Click += btnGitHub_Click;

            sidebarPanel.Controls.Add(btnGitHub);

            // Settings
            ConfigureMenuButton(
                btnSettings,
                "⚙  Settings",
                325);

            btnSettings.Click += btnSettings_Click;

            sidebarPanel.Controls.Add(btnSettings);

            // =========================================================
            // CONTENT PANEL
            // =========================================================

            contentPanel.BackColor =
                DarkMode ? Darkcolor : Lightcolor;

            contentPanel.Dock =
                DockStyle.Fill;

            contentPanel.Padding =
                new Padding(25);

            // =========================================================
            // ADD TO FORM
            // =========================================================

            Controls.Add(contentPanel);
            Controls.Add(sidebarPanel);

            ResumeLayout(false);
        }

        // =============================================================
        // HELPER METHODS
        // =============================================================

        private void ConfigureMenuButton(
            Button button,
            string text,
            int top)
        {
            button.FlatStyle = FlatStyle.Flat;

            button.FlatAppearance.BorderSize = 0;

            button.BackColor =
                DarkMode ? Color.FromArgb(24, 24, 24) : Color.FromArgb(234, 234, 234); ;

            button.ForeColor =
                DarkMode ? Color.Gainsboro : Color.Black;

            button.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);

            button.Location =
                new Point(15, top);

            button.Size =
                new Size(180, 40);

            button.Text = text;

            button.TextAlign =
                ContentAlignment.MiddleLeft;

            button.Cursor =
                Cursors.Hand;
        }

        private void ApplyTheme()
        {
            Color bg = DarkMode ? Darkcolor : Lightcolor;

            try { BackColor = bg; } catch { }

            if (sidebarPanel != null)
                sidebarPanel.BackColor = DarkMode ? Color.FromArgb(24, 24, 24) : Color.FromArgb(234, 234, 234); ;

            if (contentPanel != null)
                contentPanel.BackColor = bg;

            if (lblLogo != null)
                lblLogo.ForeColor = DarkMode ? Color.White : Color.Black;

            if (btnDashboard != null)
            {
                btnDashboard.BackColor = DarkMode ? Color.FromArgb(45, 45, 48) : Lightcolor;
                btnDashboard.ForeColor = DarkMode ? Color.Gainsboro : Color.Black;
            }

            if (btnTimers != null)
            {
                btnTimers.BackColor = DarkMode ? Color.FromArgb(24,24,24) : Lightcolor;
                btnTimers.ForeColor = DarkMode ? Color.Gainsboro : Color.Black;
            }

            if (btnClipboard != null)
            {
                btnClipboard.BackColor = DarkMode ? Color.FromArgb(24,24,24) : Lightcolor;
                btnClipboard.ForeColor = DarkMode ? Color.Gainsboro : Color.Black;
            }

            if (btnLauncher != null)
            {
                btnLauncher.BackColor = DarkMode ? Color.FromArgb(24,24,24) : Lightcolor;
                btnLauncher.ForeColor = DarkMode ? Color.Gainsboro : Color.Black;
            }

            if (btnGitHub != null)
            {
                btnGitHub.BackColor = DarkMode ? Color.FromArgb(24,24,24) : Lightcolor;
                btnGitHub.ForeColor = DarkMode ? Color.Gainsboro : Color.Black;
            }

            if (btnSettings != null)
            {
                btnSettings.BackColor = DarkMode ? Color.FromArgb(24,24,24) : Lightcolor;
                btnSettings.ForeColor = DarkMode ? Color.Gainsboro : Color.Black;
            }
        }

        #endregion
    }
}