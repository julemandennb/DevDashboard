
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace DevDashboard.Control
{
    partial class HotkeyEditorForm
    {
        private IContainer components = null;

        private Label lblTitle;
        private Label lblDescription;

        private Label lblLauncherType;
        private ComboBox cmbLauncherType;

        private Label lblCommands;
        private TextBox txtCommands;
        private Button btnBrowse;

        private Label lblShortcut;
        private TextBox txtShortcut;

        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();

            lblTitle = new Label();
            lblDescription = new Label();

            lblLauncherType = new Label();
            cmbLauncherType = new ComboBox();

            lblCommands = new Label();
            txtCommands = new TextBox();
            btnBrowse = new Button();

            lblShortcut = new Label();
            txtShortcut = new TextBox();

            btnSave = new Button();
            btnCancel = new Button();

            SuspendLayout();

            // FORM
            AutoScaleMode =
                AutoScaleMode.Font;

            ClientSize =
                new Size(500, 350);

            FormBorderStyle =
                FormBorderStyle.FixedDialog;

            MaximizeBox = false;
            MinimizeBox = false;

            StartPosition =
                FormStartPosition.CenterParent;

            Text = "Add Hotkey";

            Font = new Font(
                "Segoe UI", 9F);

            // TITLE
            lblTitle.AutoSize = true;
            lblTitle.Text = "Add Hotkey";

            lblTitle.Font = new Font(
                "Segoe UI",
                18F,
                FontStyle.Bold);

            lblTitle.Location =
                new Point(20, 18);

            // DESCRIPTION
            lblDescription.AutoSize = true;

            lblDescription.Text =
                "Configure a keyboard shortcut and its launcher.";

            lblDescription.Location =
                new Point(22, 55);


            // LAUNCHER TYPE
            lblLauncherType.AutoSize = true;
            lblLauncherType.Text = "Launcher Type";

            lblLauncherType.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            lblLauncherType.Location =
                new Point(22, 85);

            cmbLauncherType.Location =
                new Point(22, 110);

            cmbLauncherType.Size =
                new Size(450, 28);

            cmbLauncherType.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // LAUNCHER
            lblCommands.AutoSize = true;
            lblCommands.Text = "Launcher";

            lblCommands.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            lblCommands.Location =
                new Point(22, 150);

            txtCommands.Location =
                new Point(22, 175);

            txtCommands.Size =
                new Size(340, 27);

            txtCommands.BorderStyle =
                BorderStyle.FixedSingle;

            btnBrowse.Location =
                new Point(372, 170);

            btnBrowse.Size =
                new Size(100, 30);

            btnBrowse.Text = "Browse...";

            btnBrowse.FlatStyle =
                FlatStyle.Flat;

            btnBrowse.FlatAppearance.BorderSize = 0;

            btnBrowse.Cursor =
                Cursors.Hand;

            btnBrowse.UseVisualStyleBackColor = false;

            // SHORTCUT
            lblShortcut.AutoSize = true;
            lblShortcut.Text = "Keyboard Shortcut";

            lblShortcut.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            lblShortcut.Location =
                new Point(22, 220);

            txtShortcut.Location =
                new Point(22, 245);

            txtShortcut.Size =
                new Size(450, 30);

            txtShortcut.ReadOnly = true;

            txtShortcut.Text =
                "Click here and press a shortcut";

            txtShortcut.TextAlign =
                HorizontalAlignment.Center;

            txtShortcut.BorderStyle =
                BorderStyle.FixedSingle;

            txtShortcut.TabStop = true;

            // SAVE BUTTON
            btnSave.Location =
                new Point(262, 295);

            btnSave.Size =
                new Size(100, 35);

            btnSave.Text = "Save";

            btnSave.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold);

            btnSave.FlatStyle =
                FlatStyle.Flat;

            btnSave.FlatAppearance.BorderSize = 0;

            btnSave.Cursor =
                Cursors.Hand;

            btnSave.UseVisualStyleBackColor = false;

            // CANCEL BUTTON
            btnCancel.Location =
                new Point(372, 295);

            btnCancel.Size =
                new Size(100, 35);

            btnCancel.Text = "Cancel";

            btnCancel.FlatStyle =
                FlatStyle.Flat;

            btnCancel.FlatAppearance.BorderSize = 0;

            btnCancel.Cursor =
                Cursors.Hand;

            btnCancel.DialogResult =
                DialogResult.Cancel;

            btnCancel.UseVisualStyleBackColor = false;

            // ADD CONTROLS
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);

            Controls.Add(lblLauncherType);
            Controls.Add(cmbLauncherType);

            Controls.Add(lblCommands);
            Controls.Add(txtCommands);
            Controls.Add(btnBrowse);

            Controls.Add(lblShortcut);
            Controls.Add(txtShortcut);

            Controls.Add(btnSave);
            Controls.Add(btnCancel);

            // EVENTS
            cmbLauncherType.SelectedIndexChanged +=
                cmbLauncherType_SelectedIndexChanged;

            btnBrowse.Click +=
                btnBrowse_Click;

            txtShortcut.KeyDown +=
                txtShortcut_KeyDown;

            btnSave.Click +=
                btnSave_Click;

            btnCancel.Click +=
                btnCancel_Click;

            AcceptButton = btnSave;
            CancelButton = btnCancel;

            ResumeLayout(false);
            PerformLayout();
        }

        // THEME
        private void ApplyTheme()
        {
            Color background = darkMode
                ? Color.FromArgb(30, 30, 30)
                : Color.FromArgb(245, 245, 245);

            Color foreground = darkMode
                ? Color.White
                : Color.FromArgb(35, 35, 35);

            Color inputBackground = darkMode
                ? Color.FromArgb(45, 45, 45)
                : Color.White;

            Color buttonBackground = darkMode
                ? Color.FromArgb(55, 55, 55)
                : Color.FromArgb(225, 225, 225);

            BackColor = background;
            ForeColor = foreground;

            foreach (dynamic control in Controls)
            {
                control.ForeColor = foreground;

                if (control is Label)
                {
                    control.BackColor = background;
                }
                else if (control is TextBox textBox)
                {
                    textBox.BackColor = inputBackground;
                    textBox.ForeColor = foreground;
                    textBox.BorderStyle =
                        BorderStyle.FixedSingle;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.BackColor = inputBackground;
                    comboBox.ForeColor = foreground;
                }
                else if (control is Button button)
                {
                    button.FlatStyle =
                        FlatStyle.Flat;

                    button.FlatAppearance.BorderSize = 0;

                    if (button == btnSave)
                    {
                        button.BackColor = darkMode
                            ? Color.FromArgb(0, 120, 215)
                            : Color.FromArgb(0, 102, 204);

                        button.ForeColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = buttonBackground;
                        button.ForeColor = foreground;
                    }
                }
            }
        }
    }
}
