
using System.Drawing;
using System.Windows.Forms;

namespace DevDashboard.Control
{
    partial class LauncherControl
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
        private Label launcherTitle;
        private Label launcherDescription;
        private ListView hotkeyListView;

        private ColumnHeader colCommands;
        private ColumnHeader colLauncher;
        private ColumnHeader colShortcut;

        #region Windows UserControl Designer generated code

        // =============================================================
        // INITIALIZE COMPONENT
        // =============================================================

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            headerPanel = new Panel();
            launcherTitle = new Label();
            launcherDescription = new Label();
            hotkeyListView = new ListView();

            colCommands = new ColumnHeader();
            colLauncher = new ColumnHeader();
            colShortcut = new ColumnHeader();

            SuspendLayout();

            // =========================================================
            // LAUNCHER CONTROL
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
                100;

            headerPanel.Margin =
                new Padding(0);

            headerPanel.Padding =
                new Padding(10);

            // =========================================================
            // LAUNCHER TITLE
            // =========================================================

            launcherTitle.Text =
                "My Hotkeys";

            launcherTitle.AutoSize =
                true;

            launcherTitle.Dock =
                DockStyle.Top;

            launcherTitle.Font =
                new Font(
                    "Segoe UI",
                    20F,
                    FontStyle.Regular);

            launcherTitle.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            launcherTitle.Margin =
                new Padding(0);

            // =========================================================
            // LAUNCHER DESCRIPTION
            // =========================================================

            launcherDescription.Text =
                "View your configured global hotkeys.";

            launcherDescription.AutoSize =
                true;

            launcherDescription.Dock =
                DockStyle.Top;

            launcherDescription.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Regular);

            launcherDescription.ForeColor =
                DarkMode
                    ? Color.Silver
                    : Color.DimGray;

            launcherDescription.Margin =
                new Padding(0, 5, 0, 0);

            // =========================================================
            // HOTKEY LIST VIEW
            // =========================================================

            hotkeyListView.BackColor =
                DarkMode
                    ? Darkcolor
                    : Lightcolor;

            hotkeyListView.ForeColor =
                DarkMode
                    ? Color.Gainsboro
                    : Color.Black;

            hotkeyListView.BorderStyle =
                BorderStyle.None;

            hotkeyListView.Dock =
                DockStyle.Fill;

            hotkeyListView.View =
                View.Details;

            hotkeyListView.FullRowSelect =
                true;

            hotkeyListView.GridLines =
                false;

            hotkeyListView.MultiSelect =
                false;

            hotkeyListView.HideSelection =
                false;

            hotkeyListView.HeaderStyle =
                ColumnHeaderStyle.Nonclickable;

            hotkeyListView.Columns.AddRange(
                new ColumnHeader[]
                {
                    colCommands,
                    colLauncher,
                    colShortcut
                });

            // =========================================================
            // LIST COLUMNS
            // =========================================================

            colCommands.Text =
                "Target";

            colCommands.Width =
                300;

            colLauncher.Text =
                "Type";

            colLauncher.Width =
                120;

            colShortcut.Text =
                "Shortcut";

            colShortcut.Width =
                150;

            // =========================================================
            // ADD CONTROLS TO HEADER
            // =========================================================

            headerPanel.Controls.Add(
                launcherDescription);

            headerPanel.Controls.Add(
                launcherTitle);

            // =========================================================
            // ADD CONTROLS
            // =========================================================

            Controls.Add(
                hotkeyListView);

            Controls.Add(
                headerPanel);

            // =========================================================
            // USER CONTROL
            // =========================================================

            Name =
                "LauncherControl";

            Size =
                new Size(600, 600);

            ResumeLayout(false);
            PerformLayout();
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

            Color secondaryColor =
                DarkMode
                    ? Color.Silver
                    : Color.DimGray;

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

            if (launcherTitle != null)
            {
                launcherTitle.ForeColor =
                    foregroundColor;
            }

            // ---------------------------------------------------------
            // DESCRIPTION
            // ---------------------------------------------------------

            if (launcherDescription != null)
            {
                launcherDescription.ForeColor =
                    secondaryColor;
            }

            // ---------------------------------------------------------
            // HOTKEY LIST
            // ---------------------------------------------------------

            if (hotkeyListView != null)
            {
                hotkeyListView.BackColor =
                    backgroundColor;

                hotkeyListView.ForeColor =
                    foregroundColor;
            }
        }

        #endregion
    }
}
