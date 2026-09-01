namespace DevDashboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        private Panel systemNotificationPanel;
        private Label systemNotificationTitle;
        private ListBox systemNotificationList;

        private TableLayoutPanel systemCardsPanel;
        private TableLayoutPanel systemCardsPanel2;

        private Panel cpuCard;
        private Panel ramCard;
        private Panel diskCard;
        private Panel networkCard;

        private Label lblCpuTitle;
        private Label lblCpuValue;

        private Label lblRamTitle;
        private Label lblRamValue;

        private Label lblDiskTitle;
        private Label lblDiskValue;

        private Label lblNetworkTitle;
        private Label lblNetworkValue;

        private System.Windows.Forms.Timer systemInfoTimer;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            systemNotificationPanel = new Panel();
            systemNotificationTitle = new Label();
            systemNotificationList = new ListBox();
            systemCardsPanel = new TableLayoutPanel();
            systemCardsPanel2 = new TableLayoutPanel();
            cpuCard = new Panel();
            ramCard = new Panel();
            diskCard = new Panel();
            networkCard = new Panel();
            lblCpuTitle = new Label();
            lblCpuValue = new Label();
            lblRamTitle = new Label();
            lblRamValue = new Label();
            lblDiskTitle = new Label();
            lblDiskValue = new Label();
            lblNetworkTitle = new Label();
            lblNetworkValue = new Label();

            systemInfoTimer = new System.Windows.Forms.Timer();

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
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(5, 25);
            lblLogo.Text = "⚡ DevDashboard";
            sidebarPanel.Controls.Add(lblLogo);
            // Dashboard button
            ConfigureMenuButton(btnDashboard, "⌂  Dashboard", 75);
            btnDashboard.BackColor = Color.FromArgb(45, 45, 48);
            sidebarPanel.Controls.Add(btnDashboard);
            // Pomodoro
            ConfigureMenuButton(btnPomodoro, "◷  Pomodoro", 125);
            sidebarPanel.Controls.Add(btnPomodoro);
            // Clipboard
            ConfigureMenuButton(btnClipboard, "▣  Clipboard", 175);
            sidebarPanel.Controls.Add(btnClipboard);
            // Launcher
            ConfigureMenuButton(btnLauncher, "🚀  Launcher", 225);
            sidebarPanel.Controls.Add(btnLauncher);
            // GitHub
            ConfigureMenuButton(btnGitHub, "◉  GitHub", 275);
            sidebarPanel.Controls.Add(btnGitHub);
            // Settings
            ConfigureMenuButton(btnSettings, "⚙  Settings", 325);
            sidebarPanel.Controls.Add(btnSettings);
            // =========================================================
            // CONTENT
            // =========================================================
            contentPanel.BackColor = Color.FromArgb(18, 18, 18);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Padding = new Padding(25);
            // =========================================================
            // systemNotification
            // =========================================================
            systemNotificationPanel.BackColor = Color.FromArgb(18, 18, 18);
            systemNotificationPanel.Dock = DockStyle.Fill;
            systemNotificationPanel.Padding = new Padding(0);
            // Title
            systemNotificationTitle.Text = "System Notification";
            systemNotificationTitle.AutoSize = true;
            systemNotificationTitle.Dock = DockStyle.Top;
            systemNotificationTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular);
            systemNotificationTitle.ForeColor = Color.Gainsboro;
            systemNotificationTitle.Margin = new Padding(0, 0, 0, 0);
            // List
            systemNotificationList.BackColor = Color.FromArgb(18, 18, 18);
            systemNotificationList.Dock = DockStyle.Fill;
            systemNotificationList.ForeColor = Color.Gainsboro;
            systemNotificationList.Padding = new Padding(0);


            // Add Fill control first, then Top control.
            systemNotificationPanel.Controls.Add(systemNotificationList);
            systemNotificationPanel.Controls.Add(systemNotificationTitle);
            contentPanel.Controls.Add(systemNotificationPanel);
            // =========================================================
            // SYSTEM CARDS
            // =========================================================
            ConfigureSystemCardsPanel(systemCardsPanel);
            ConfigureSystemCardsPanel(systemCardsPanel2);
            systemCardsPanel.Padding = new Padding(0, 10, 0, 0);
            systemCardsPanel2.Padding = new Padding(0, 0, 0, 10);
            // =========================================================
            // CPU CARD
            // =========================================================
            ConfigureCard(cpuCard);
            lblCpuTitle.Text = "🖥 CPU Usage";
            ConfigureCardTitle(lblCpuTitle);
            lblCpuValue.Text = "0%";
            ConfigureCardValue(lblCpuValue);
            cpuCard.Controls.Add(lblCpuTitle);
            cpuCard.Controls.Add(lblCpuValue);
            systemCardsPanel.Controls.Add(cpuCard, 0, 0);
            // =========================================================
            // RAM CARD
            // =========================================================
            ConfigureCard(ramCard);
            lblRamTitle.Text = "\U0001f9e0 RAM Usage";
            ConfigureCardTitle(lblRamTitle);
            lblRamValue.Text = "0%";
            ConfigureCardValue(lblRamValue);
            ramCard.Controls.Add(lblRamTitle);
            ramCard.Controls.Add(lblRamValue);
            systemCardsPanel.Controls.Add(ramCard, 1, 0);
            // =========================================================
            // DISK CARD
            // =========================================================
            ConfigureCard(diskCard);
            lblDiskTitle.Text = "💾 Disk Usage";
            ConfigureCardTitle(lblDiskTitle);
            lblDiskValue.Text = "0%";
            ConfigureCardValue(lblDiskValue);
            diskCard.Controls.Add(lblDiskTitle);
            diskCard.Controls.Add(lblDiskValue);
            systemCardsPanel2.Controls.Add(diskCard, 0, 0);
            // =========================================================
            // NETWORK CARD
            // =========================================================
            ConfigureCard(networkCard);
            lblNetworkTitle.Text = "🖧 Network";
            ConfigureCardTitle(lblNetworkTitle);
            lblNetworkValue.Text = "None";
            ConfigureCardValue(lblNetworkValue);
            networkCard.Controls.Add(lblNetworkTitle);
            networkCard.Controls.Add(lblNetworkValue);
            systemCardsPanel2.Controls.Add(networkCard, 1, 0);
            contentPanel.Controls.Add(systemCardsPanel2);
            contentPanel.Controls.Add(systemCardsPanel);
            // =========================================================
            // ADD TO FORM
            // =========================================================


            systemInfoTimer.Interval = 2500; // 0.5 second
            systemInfoTimer.Enabled = false;
            systemInfoTimer.Tick += systemInfoTimer_Tick;


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
            button.BackColor = Color.FromArgb(24, 24, 24);
            button.ForeColor = Color.Gainsboro;

            button.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);

            button.Location = new Point(15, top);
            button.Size = new Size(180, 40);
            button.Text = text;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Cursor = Cursors.Hand;
        }

        private void ConfigureCard(Panel card)
        {
            card.BackColor = Color.FromArgb(28, 28, 30);
            card.Dock = DockStyle.Fill;
            card.Margin = new Padding(5);
            card.Padding = new Padding(20);
        }

        private void ConfigureCardTitle(Label label)
        {
            label.AutoSize = true;
            label.Font = new Font(
                "Segoe UI",
                11F,
                FontStyle.Regular);

            label.ForeColor = Color.Gainsboro;
            label.Location = new Point(20, 20);
        }

        private void ConfigureCardValue(Label label)
        {
            label.AutoSize = true;
            label.Font = new Font(
                "Segoe UI",
                28F,
                FontStyle.Bold);

            label.ForeColor = Color.White;
            label.Location = new Point(20, 55);
        }

        private void ConfigureSystemCardsPanel(TableLayoutPanel systemCardsPanel)
        {
            systemCardsPanel.ColumnCount = 2;
            systemCardsPanel.RowCount = 1;
            systemCardsPanel.Dock = DockStyle.Top;
            systemCardsPanel.Height = 150;
            systemCardsPanel.Padding = new Padding(0, 10, 0, 0);
            systemCardsPanel.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 50F));
            systemCardsPanel.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 50F));
            systemCardsPanel.RowStyles.Add(
                new RowStyle(SizeType.Percent, 50F));
        }
        #endregion
    }
}
