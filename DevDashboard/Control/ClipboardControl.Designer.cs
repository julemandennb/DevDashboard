namespace DevDashboard.Control
{
    partial class ClipboardControl
    {
        // =============================================================
        // THEME
        // =============================================================

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

        private readonly Color Darkcolor =
            Color.FromArgb(18, 18, 18);

        private readonly Color Lightcolor =
            Color.FromArgb(240, 240, 240);

        // =============================================================
        // COMPONENTS
        // =============================================================

        private System.ComponentModel.IContainer components = null;

        // =============================================================
        // CONTROLS
        // =============================================================

        private Panel headerPanel;
        private Label clipboardTitle;
        private FlowLayoutPanel clipboardHistoryPanel;

        // =============================================================
        // DISPOSE
        // =============================================================

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows UserControl Designer generated code

        // =============================================================
        // INITIALIZE COMPONENT
        // =============================================================

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            headerPanel =
                new Panel();

            clipboardTitle =
                new Label();

            clipboardHistoryPanel =
                new FlowLayoutPanel();

            SuspendLayout();

            // =========================================================
            // CLIPBOARD CONTROL
            // =========================================================

            BackColor =
                DarkMode
                    ? Darkcolor
                    : Lightcolor;

            Dock =
                DockStyle.Fill;

            Margin =
                new Padding(0);

            Padding =
                new Padding(0);

            // =========================================================
            // HEADER PANEL
            // =========================================================

            headerPanel.BackColor =
                DarkMode
                    ? Darkcolor
                    : Lightcolor;

            headerPanel.Dock =
                DockStyle.Top;

            headerPanel.Height =
                60;

            headerPanel.Margin =
                new Padding(0);

            headerPanel.Padding =
                new Padding(10);

            // =========================================================
            // CLIPBOARD TITLE
            // =========================================================

            clipboardTitle.Text =
                "Clipboard";

            clipboardTitle.AutoSize =
                true;

            clipboardTitle.Dock =
                DockStyle.Left;

            clipboardTitle.Font =
                new Font(
                    "Segoe UI",
                    20F,
                    FontStyle.Regular);

            clipboardTitle.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            clipboardTitle.Margin =
                new Padding(0);

            clipboardTitle.Padding =
                new Padding(0);

            // =========================================================
            // HISTORY PANEL
            // =========================================================

            clipboardHistoryPanel.BackColor =
                DarkMode
                    ? Darkcolor
                    : Lightcolor;

            clipboardHistoryPanel.Dock =
                DockStyle.Fill;

            clipboardHistoryPanel.FlowDirection =
                FlowDirection.TopDown;

            clipboardHistoryPanel.WrapContents =
                false;

            clipboardHistoryPanel.AutoScroll =
                true;

            clipboardHistoryPanel.Margin =
                new Padding(0);

            clipboardHistoryPanel.Padding =
                new Padding(10);

            // =========================================================
            // ADD TITLE TO HEADER
            // =========================================================

            headerPanel.Controls.Add(
                clipboardTitle);

            // =========================================================
            // ADD CONTROLS
            // =========================================================

            Controls.Add(
                clipboardHistoryPanel);

            Controls.Add(
                headerPanel);

            // =========================================================
            // USER CONTROL
            // =========================================================

            Name =
                "ClipboardControl";

            Size =
                new Size(600, 600);

            ResumeLayout(false);
        }

        // =============================================================
        // THEME
        // =============================================================

        private void ApplyTheme()
        {
            Color backgroundColor =
                DarkMode
                    ? Darkcolor
                    : Lightcolor;

            Color foregroundColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            // ---------------------------------------------------------
            // MAIN CONTROL
            // ---------------------------------------------------------

            try
            {
                BackColor =
                    backgroundColor;
            }
            catch
            {
            }

            // ---------------------------------------------------------
            // HEADER
            // ---------------------------------------------------------

            if (headerPanel != null)
            {
                headerPanel.BackColor =
                    backgroundColor;
            }

            // ---------------------------------------------------------
            // TITLE
            // ---------------------------------------------------------

            if (clipboardTitle != null)
            {
                clipboardTitle.ForeColor =
                    foregroundColor;
            }

            // ---------------------------------------------------------
            // HISTORY
            // ---------------------------------------------------------

            if (clipboardHistoryPanel != null)
            {
                clipboardHistoryPanel.BackColor =
                    backgroundColor;
            }
        }

        #endregion
    }
}