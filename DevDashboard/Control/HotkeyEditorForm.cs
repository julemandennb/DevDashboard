
using Settings.Dto;
using LauncherProgram.Enum;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DevDashboard.Control
{
    public partial class HotkeyEditorForm : Form
    {
        public HotkeyProgramDto hotkey;

        private bool darkMode;

        private const uint MOD_ALT = 0x0001;
        private const uint MOD_CONTROL = 0x0002;
        private const uint MOD_SHIFT = 0x0004;

        public HotkeyEditorForm(bool darkModeOn)
            : this(darkModeOn, null)
        {
        }

        public HotkeyEditorForm(
            bool darkModeOn,
            HotkeyProgramDto existingHotkey)
        {
            InitializeComponent();

            darkMode = darkModeOn;

            hotkey = existingHotkey == null
                ? new HotkeyProgramDto()
                : new HotkeyProgramDto
                {
                    Commands = existingHotkey.Commands,
                    Launcher = existingHotkey.Launcher,
                    Key = existingHotkey.Key,
                    Modifiers = existingHotkey.Modifiers
                };

            InitializeEditor();
            ApplyTheme();
        }

        private void InitializeEditor()
        {
            cmbLauncherType.DataSource =
                Enum.GetValues(typeof(LauncherSystem));

            // Restore launcher type when editing.
            if (Enum.TryParse(
                hotkey.Launcher,
                true,
                out LauncherSystem launcherType))
            {
                cmbLauncherType.SelectedItem = launcherType;
            }
            else
            {
                cmbLauncherType.SelectedItem = LauncherSystem.Program;
            }

            // Commands contains the actual launcher target.
            txtCommands.Text = hotkey.Commands;

            UpdateShortcutText();
            UpdateLauncherControls();

            bool editing =
                !string.IsNullOrWhiteSpace(hotkey.Commands);

            Text = editing ? "Edit Hotkey" : "Add Hotkey";
            lblTitle.Text = Text;

            lblDescription.Text = editing
                ? "Edit your keyboard shortcut and launcher."
                : "Configure a keyboard shortcut and its launcher.";
        }

        private void cmbLauncherType_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdateLauncherControls();
        }

        private void UpdateLauncherControls()
        {
            if (cmbLauncherType.SelectedItem == null)
                return;

            LauncherSystem type =
                (LauncherSystem)cmbLauncherType.SelectedItem;

            switch (type)
            {
                case LauncherSystem.Program:
                    lblCommands.Text = "Program Path";
                    btnBrowse.Enabled = true;
                    btnBrowse.Text = "Browse...";
                    break;

                case LauncherSystem.Website:
                    lblCommands.Text = "Website URL";
                    btnBrowse.Enabled = false;
                    break;

                case LauncherSystem.Folder:
                    lblCommands.Text = "Folder Path";
                    btnBrowse.Enabled = true;
                    btnBrowse.Text = "Browse...";
                    break;

                case LauncherSystem.Command:
                    lblCommands.Text = "Command";
                    btnBrowse.Enabled = false;
                    break;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (cmbLauncherType.SelectedItem == null)
                return;

            LauncherSystem type =
                (LauncherSystem)cmbLauncherType.SelectedItem;

            if (type == LauncherSystem.Program)
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Title = "Select Program";
                    dialog.Filter =
                        "Programs (*.exe)|*.exe|All files (*.*)|*.*";

                    if (File.Exists(txtCommands.Text))
                    {
                        dialog.InitialDirectory =
                            Path.GetDirectoryName(txtCommands.Text);
                    }

                    if (dialog.ShowDialog(this) == DialogResult.OK)
                        txtCommands.Text = dialog.FileName;
                }
            }
            else if (type == LauncherSystem.Folder)
            {
                using (FolderBrowserDialog dialog =
                    new FolderBrowserDialog())
                {
                    dialog.Description = "Select Folder";

                    if (Directory.Exists(txtCommands.Text))
                        dialog.SelectedPath = txtCommands.Text;

                    if (dialog.ShowDialog(this) == DialogResult.OK)
                        txtCommands.Text = dialog.SelectedPath;
                }
            }
        }

        private void txtShortcut_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;

            // Ignore modifier-only key presses.
            if (e.KeyCode == Keys.ControlKey ||
                e.KeyCode == Keys.ShiftKey ||
                e.KeyCode == Keys.Menu)
            {
                return;
            }

            uint modifiers = 0;

            if (e.Control)
                modifiers |= MOD_CONTROL;

            if (e.Alt)
                modifiers |= MOD_ALT;

            if (e.Shift)
                modifiers |= MOD_SHIFT;

            hotkey.Key = (uint)e.KeyCode;
            hotkey.Modifiers = modifiers;

            UpdateShortcutText();
        }

        private void UpdateShortcutText()
        {
            if (hotkey.Key == 0)
            {
                txtShortcut.Text =
                    "Click here and press a shortcut";

                return;
            }

            string shortcut = "";

            if ((hotkey.Modifiers & MOD_CONTROL) != 0)
                shortcut += "Ctrl + ";

            if ((hotkey.Modifiers & MOD_ALT) != 0)
                shortcut += "Alt + ";

            if ((hotkey.Modifiers & MOD_SHIFT) != 0)
                shortcut += "Shift + ";

            shortcut += ((Keys)hotkey.Key).ToString();

            txtShortcut.Text = shortcut;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string commands = txtCommands.Text.Trim();

            if (string.IsNullOrWhiteSpace(commands))
            {
                MessageBox.Show(
                    this,
                    "Please enter a launcher value.",
                    "Missing Launcher",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCommands.Focus();
                return;
            }

            if (cmbLauncherType.SelectedItem == null)
                return;

            if (hotkey.Key == 0)
            {
                MessageBox.Show(
                    this,
                    "Please assign a keyboard shortcut.",
                    "Missing Shortcut",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtShortcut.Focus();
                return;
            }

            LauncherSystem type =
                (LauncherSystem)cmbLauncherType.SelectedItem;

            if (type == LauncherSystem.Program &&
                !File.Exists(commands))
            {
                MessageBox.Show(
                    this,
                    "The selected program does not exist.",
                    "Invalid Program",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCommands.Focus();
                return;
            }

            if (type == LauncherSystem.Folder &&
                !Directory.Exists(commands))
            {
                MessageBox.Show(
                    this,
                    "The selected folder does not exist.",
                    "Invalid Folder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCommands.Focus();
                return;
            }

            if (type == LauncherSystem.Website)
            {
                if (!Uri.TryCreate(
                    commands,
                    UriKind.Absolute,
                    out Uri uri) ||
                    (uri.Scheme != Uri.UriSchemeHttp &&
                     uri.Scheme != Uri.UriSchemeHttps))
                {
                    MessageBox.Show(
                        this,
                        "Please enter a valid HTTP or HTTPS URL.",
                        "Invalid Website",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtCommands.Focus();
                    return;
                }
            }

            // Save using your original DTO structure.
            hotkey.Commands = commands;
            hotkey.Launcher = type.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
