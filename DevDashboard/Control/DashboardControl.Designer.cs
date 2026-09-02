namespace DevDashboard.Control
{
    partial class DashboardControl
    {
        private System.ComponentModel.IContainer components = null;

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

            systemNotificationPanel =
                new Panel();

            systemNotificationTitle =
                new Label();

            systemNotificationList =
                new ListBox();

            systemCardsPanel =
                new TableLayoutPanel();

            systemCardsPanel2 =
                new TableLayoutPanel();

            cpuCard =
                new Panel();

            ramCard =
                new Panel();

            diskCard =
                new Panel();

            networkCard =
                new Panel();

            lblCpuTitle =
                new Label();

            lblCpuValue =
                new Label();

            lblRamTitle =
                new Label();

            lblRamValue =
                new Label();

            lblDiskTitle =
                new Label();

            lblDiskValue =
                new Label();

            lblNetworkTitle =
                new Label();

            lblNetworkValue =
                new Label();

            systemInfoTimer =
                new System.Windows.Forms.Timer(components);

            SuspendLayout();

            // =========================================================
            // DASHBOARD CONTROL
            // =========================================================

            BackColor =
                Color.FromArgb(18, 18, 18);

            Dock =
                DockStyle.Fill;

            // =========================================================
            // SYSTEM NOTIFICATION
            // =========================================================

            systemNotificationPanel.BackColor =
                Color.FromArgb(18, 18, 18);

            systemNotificationPanel.Dock =
                DockStyle.Fill;

            systemNotificationPanel.Padding =
                new Padding(0);

            // Title
            systemNotificationTitle.Text =
                "System Notification";

            systemNotificationTitle.AutoSize =
                true;

            systemNotificationTitle.Dock =
                DockStyle.Top;

            systemNotificationTitle.Font =
                new Font(
                    "Segoe UI",
                    24F,
                    FontStyle.Regular);

            systemNotificationTitle.ForeColor =
                Color.Gainsboro;

            systemNotificationTitle.Margin =
                new Padding(0);

            // List
            systemNotificationList.BackColor =
                Color.FromArgb(18, 18, 18);

            systemNotificationList.Dock =
                DockStyle.Fill;

            systemNotificationList.ForeColor =
                Color.Gainsboro;

            systemNotificationList.Padding =
                new Padding(0);

            systemNotificationList.HorizontalScrollbar = true;

            systemNotificationPanel.Controls.Add(
                systemNotificationList);

            systemNotificationPanel.Controls.Add(
                systemNotificationTitle);

            // =========================================================
            // SYSTEM CARDS
            // =========================================================

            ConfigureSystemCardsPanel(
                systemCardsPanel);

            ConfigureSystemCardsPanel(
                systemCardsPanel2);

            systemCardsPanel.Padding =
                new Padding(0, 10, 0, 0);

            systemCardsPanel2.Padding =
                new Padding(0, 0, 0, 10);

            // =========================================================
            // CPU CARD
            // =========================================================

            ConfigureCard(cpuCard);

            lblCpuTitle.Text =
                "🖥 CPU Usage";

            ConfigureCardTitle(
                lblCpuTitle);

            lblCpuValue.Text =
                "0%";

            ConfigureCardValue(
                lblCpuValue);

            cpuCard.Controls.Add(
                lblCpuTitle);

            cpuCard.Controls.Add(
                lblCpuValue);

            systemCardsPanel.Controls.Add(
                cpuCard,
                0,
                0);

            // =========================================================
            // RAM CARD
            // =========================================================

            ConfigureCard(ramCard);

            lblRamTitle.Text =
                "\U0001f9e0 RAM Usage";

            ConfigureCardTitle(
                lblRamTitle);

            lblRamValue.Text =
                "0%";

            ConfigureCardValue(
                lblRamValue);

            ramCard.Controls.Add(
                lblRamTitle);

            ramCard.Controls.Add(
                lblRamValue);

            systemCardsPanel.Controls.Add(
                ramCard,
                1,
                0);

            // =========================================================
            // DISK CARD
            // =========================================================

            ConfigureCard(diskCard);

            lblDiskTitle.Text =
                "💾 Disk Usage";

            ConfigureCardTitle(
                lblDiskTitle);

            lblDiskValue.Text =
                "0%";

            ConfigureCardValue(
                lblDiskValue);

            diskCard.Controls.Add(
                lblDiskTitle);

            diskCard.Controls.Add(
                lblDiskValue);

            systemCardsPanel2.Controls.Add(
                diskCard,
                0,
                0);

            // =========================================================
            // NETWORK CARD
            // =========================================================

            ConfigureCard(networkCard);

            lblNetworkTitle.Text =
                "🖧 Network";

            ConfigureCardTitle(
                lblNetworkTitle);

            lblNetworkValue.Text =
                "None";

            ConfigureCardValue(
                lblNetworkValue);

            networkCard.Controls.Add(
                lblNetworkTitle);

            networkCard.Controls.Add(
                lblNetworkValue);

            systemCardsPanel2.Controls.Add(
                networkCard,
                1,
                0);

            // =========================================================
            // ADD CONTROLS
            // =========================================================

            Controls.Add(
                systemNotificationPanel);

            Controls.Add(
                systemCardsPanel2);

            Controls.Add(
                systemCardsPanel);

            // =========================================================
            // TIMER
            // =========================================================

            systemInfoTimer.Interval =
                2500;

            systemInfoTimer.Enabled =
                false;

            systemInfoTimer.Tick +=
                systemInfoTimer_Tick;

            ResumeLayout(false);
        }

        // =============================================================
        // HELPERS
        // =============================================================

        private void ConfigureCard(
            Panel card)
        {
            card.BackColor =
                Color.FromArgb(28, 28, 30);

            card.Dock =
                DockStyle.Fill;

            card.Margin =
                new Padding(5);

            card.Padding =
                new Padding(20);
        }

        private void ConfigureCardTitle(
            Label label)
        {
            label.AutoSize = true;

            label.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Regular);

            label.ForeColor =
                Color.Gainsboro;

            label.Location =
                new Point(20, 20);
        }

        private void ConfigureCardValue(
            Label label)
        {
            label.AutoSize = true;

            label.Font =
                new Font(
                    "Segoe UI",
                    28F,
                    FontStyle.Bold);

            label.ForeColor =
                Color.White;

            label.Location =
                new Point(20, 55);
        }

        private void ConfigureSystemCardsPanel(
            TableLayoutPanel panel)
        {
            panel.ColumnCount = 2;
            panel.RowCount = 1;

            panel.Dock =
                DockStyle.Top;

            panel.Height = 150;

            panel.Padding =
                new Padding(0, 10, 0, 0);

            panel.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            panel.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent,
                    50F));

            panel.RowStyles.Add(
                new RowStyle(
                    SizeType.Percent,
                    100F));
        }

        #endregion
    }
}