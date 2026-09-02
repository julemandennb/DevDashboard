namespace DevDashboard
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Panel sidebarPanel;
        private Panel contentPanel;
        private Label lblLogo;

        private Button btnDashboard;
        private Button btnPomodoro;
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
            btnPomodoro = new Button();
            btnClipboard = new Button();
            btnLauncher = new Button();
            btnGitHub = new Button();
            btnSettings = new Button();

            SuspendLayout();

            // =========================================================
            // FORM
            // =========================================================

            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 18);
            ClientSize = new Size(1100, 700);
            MinimumSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DevDashboard";

            // =========================================================
            // SIDEBAR
            // =========================================================

            sidebarPanel.BackColor = Color.FromArgb(24, 24, 24);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Padding = new Padding(15);
            sidebarPanel.Size = new Size(210, 700);

            // Logo
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font(
                "Segoe UI",
                16F,
                FontStyle.Bold);

            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(5, 25);
            lblLogo.Text = "⚡ DevDashboard";

            sidebarPanel.Controls.Add(lblLogo);

            // Dashboard
            ConfigureMenuButton(
                btnDashboard,
                "⌂  Dashboard",
                75);

            btnDashboard.BackColor =
                Color.FromArgb(45, 45, 48);

            btnDashboard.Click += btnDashboard_Click;

            sidebarPanel.Controls.Add(btnDashboard);

            // Pomodoro
            ConfigureMenuButton(
                btnPomodoro,
                "◷  Pomodoro",
                125);

            btnPomodoro.Click += btnPomodoro_Click;

            sidebarPanel.Controls.Add(btnPomodoro);

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
                Color.FromArgb(18, 18, 18);

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
                Color.FromArgb(24, 24, 24);

            button.ForeColor =
                Color.Gainsboro;

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

        #endregion
    }
}