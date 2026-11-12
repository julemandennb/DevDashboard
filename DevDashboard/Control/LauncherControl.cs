using DevDashboard.Help;
using LauncherProgram.Enum;
using LauncherProgram.Interface;
using LauncherProgram.Manager;
using LauncherProgram.Model;
using LauncherProgram.Windows.Manager;
using Settings.Dto;
using Settings.Models;
using System;
using System.Windows.Forms;
using SystemMonitor.Setting;

namespace DevDashboard.Control
{
    public partial class LauncherControl : UserControl
    {
        private readonly IGlobalHotkeyManager _hotkeyManager;
        private readonly LauncherManager _launcherManager;
        private List<HotkeyProgram> _hotkeys = new();

        private HotkeySetting _hotkeySetting = null;

        public LauncherControl(bool darkModeOn)
        {
            darkMode = darkModeOn;
            InitializeComponent();
            ApplyTheme();

            _hotkeyManager = new WindowsHotkeyManager();
            _launcherManager = new LauncherManager();

            _hotkeyManager.HotkeyPressed += OnHotkeyPressed;
            OpdateSetting();
        }


        public void OpdateSetting()
        {
            _hotkeyManager.UnregisterAll();
            _hotkeys.Clear();

            _hotkeySetting =
                SettingLibHelp.GetSettingsFile<HotkeySetting>().Load();

            if (_hotkeySetting?.Hotkeys == null)
                return;

            LoadHotkeys(_hotkeySetting.Hotkeys);

            foreach (HotkeyProgramDto item in _hotkeySetting.Hotkeys)
            {
                if (!Enum.TryParse<LauncherSystem>(
                    item.Launcher,
                    out var launcher))
                {
                    continue;
                }

                HotkeyProgram hotkey = new HotkeyProgram(
                    item.Commands,
                    launcher,
                    item.Key,
                    item.Modifiers
                );

                _hotkeys.Add(hotkey);

                if (!_hotkeyManager.Register(hotkey))
                {
                    // Registration failed.
                }
            }
        }

        private void OnHotkeyPressed(HotkeyProgram hotkey)
        {
            _launcherManager.Execute(hotkey);
        }

        private void LoadHotkeys(IEnumerable<HotkeyProgramDto> hotkeys)
        {
            hotkeyListView.Items.Clear();

            foreach (HotkeyProgramDto hotkey in hotkeys)
            {
                string shortcut =
                    GetShortcutText.Get(
                        hotkey.Key,
                        hotkey.Modifiers);

                ListViewItem item =
                    new ListViewItem(hotkey.Commands);

                item.SubItems.Add(hotkey.Launcher);
                item.SubItems.Add(shortcut);

                hotkeyListView.Items.Add(item);
            }
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_hotkeyManager != null)
                {
                    _hotkeyManager.HotkeyPressed -= OnHotkeyPressed;
                    _hotkeyManager.Dispose();
                }

                components?.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}