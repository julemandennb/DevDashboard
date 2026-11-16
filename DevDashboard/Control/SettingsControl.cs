using DevDashboard.Help;
using Settings;
using Settings.Dto;
using Settings.Models;
using Settings.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DevDashboard.Control
{
    public partial class SettingsControl : UserControl
    {
        public event Action<bool>? DarkModeChanged;

        public event Action? OpdateSetting;

        private Setting isOn = null;

        private List<HotkeyProgramDto> _Hotkeys { get; set; } = new();

        public SettingsControl(bool darkModeOn)
        {
            darkMode = darkModeOn;
            InitializeComponent();

            btnGeneral_Click(null, null);

        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            GeneralSetting generalSetting = SettingLibHelp.AddToList<GeneralSetting>(SettingLibHelp.GetSettingsFile<GeneralSetting>().Load());
            isOn = generalSetting;
            chkStartWithWindows.Checked = generalSetting.StartWithPc;
            chkStartMinimized.Checked = generalSetting.MinimizedOnStart;

            ShowPage(generalPage);
            SetSelectedTab(btnGeneral);
        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {
            AppearanceSetting appearanceSetting = SettingLibHelp.AddToList<AppearanceSetting>(SettingLibHelp.GetSettingsFile<AppearanceSetting>().Load());
            isOn = appearanceSetting;
            chkDarkMode.Checked = appearanceSetting.DarkModel;

            ShowPage(appearancePage);
            SetSelectedTab(btnAppearance);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

            DashboardSetting dashboardSetting = SettingLibHelp.AddToList<DashboardSetting>(SettingLibHelp.GetSettingsFile<DashboardSetting>().Load());
            isOn = dashboardSetting;
            numRefreshInterval.Value = dashboardSetting.UpdateInterval;
            chkSystemCpu.Checked = dashboardSetting.CpuMonitor;
            chkSystemRam.Checked = dashboardSetting.RamMonitor;
            chkSystemDiskUsage.Checked = dashboardSetting.DiskMonitor;
            chkSystemNetwork.Checked = dashboardSetting.InternetMonitor;
            chkSystemNotifications.Checked = dashboardSetting.EventLogMonitor;


            ShowPage(dashboardPage);
            SetSelectedTab(btnDashboard);
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            isOn = SettingLibHelp.AddToList<TimesSetting>(SettingLibHelp.GetSettingsFile<TimesSetting>().Load());
            ShowPage(timePage);
            SetSelectedTab(btnTimes);
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            ClipboardSetting clipboardSetting = SettingLibHelp.AddToList<ClipboardSetting>(SettingLibHelp.GetSettingsFile<ClipboardSetting>().Load());
            isOn = clipboardSetting;
            chkClipboardEnabled.Checked = clipboardSetting.Ison;
            numClipboardHistory.Value = clipboardSetting.Max;


            ShowPage(clipboardPage);
            SetSelectedTab(btnClipboard);
        }

        private void btnLauncher_Click(object sender, EventArgs e)
        {
            HotkeySetting hotkeySetting = SettingLibHelp.AddToList<HotkeySetting>(SettingLibHelp.GetSettingsFile<HotkeySetting>().Load());
            isOn = hotkeySetting;

            _Hotkeys = hotkeySetting.Hotkeys;

            RefreshHotkeyList();

            ShowPage(launcherPage);
            SetSelectedTab(btnLauncher);
        }

        private void ShowPage(Panel page)
        {
            generalPage.Visible = false;
            appearancePage.Visible = false;
            dashboardPage.Visible = false;
            timePage.Visible = false;
            clipboardPage.Visible = false;
            launcherPage.Visible = false;

            page.Visible = true;
            page.BringToFront();
        }

        private void SetSelectedTab(Button selected)
        {
            Button[] buttons =
            {
                btnGeneral,
                btnAppearance,
                btnDashboard,
                btnTimes,
                btnClipboard,
                btnLauncher
            };

            foreach (Button button in buttons)
            {
                button.BackColor =
                    Color.FromArgb(18, 18, 18);

                button.ForeColor =
                    Color.Gainsboro;
            }

            selected.BackColor =
                Color.FromArgb(45, 45, 48);

            selected.ForeColor =
                Color.White;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            switch (isOn)
            {
                case GeneralSetting generalSetting:
                    SaveGeneralSetting(generalSetting);
                    break;
                case DashboardSetting dashboardSetting:
                    saveDashboardSetting(dashboardSetting);
                    break;

                case TimesSetting timesSetting:
                    SaveTimesSetting(timesSetting);
                    break;
                case AppearanceSetting appearanceSetting:
                    SaveAppearanceSetting(appearanceSetting);
                    break;
                case ClipboardSetting clipboardSetting:
                    SaveClipboardSetting(clipboardSetting);
                    break;
                case HotkeySetting hotkeySetting:
                    SaveLauncher(hotkeySetting);
                    break;
                default:
                    break;
            }

            OpdateSetting?.Invoke();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            switch (isOn)
            {
                case GeneralSetting generalSetting:
                    GeneralSetting restgeneralSetting = new GeneralSetting();
                    SettingLibHelp.SaveSetting(restgeneralSetting);
                    StartupManager.SetStartWithPC(generalSetting.StartWithPc);
                    break;
                case DashboardSetting dashboardSetting:
                    DashboardSetting restDashboardSetting = new DashboardSetting();
                    SettingLibHelp.SaveSetting(restDashboardSetting);
                    break;

                case TimesSetting timesSetting:
                    FilePathServices.DeleteSoundsFile("PomodoroSound.wav");
                    FilePathServices.DeleteSoundsFile("AlarmSound.wav");
                    TimesSetting restTimesSetting = new TimesSetting();
                    SettingLibHelp.SaveSetting(restTimesSetting);
                    break;
                case AppearanceSetting appearanceSetting:
                    AppearanceSetting restAppearanceSetting = new AppearanceSetting();
                    SettingLibHelp.SaveSetting(restAppearanceSetting);
                    break;
                case ClipboardSetting clipboardSetting:
                    ClipboardSetting restClipboardSetting = new ClipboardSetting();
                    SettingLibHelp.SaveSetting(restClipboardSetting);
                    break;
                case HotkeySetting hotkeySetting:
                    HotkeySetting resthotkeySetting = new HotkeySetting();
                    SettingLibHelp.SaveSetting(resthotkeySetting);
                    _Hotkeys.Clear();
                    RefreshHotkeyList();
                    break;
                default:
                    break;
            }

            OpdateSetting?.Invoke();
        }

        private void SaveGeneralSetting(GeneralSetting generalSetting)
        {
            generalSetting.StartWithPc = chkStartWithWindows.Checked;
            generalSetting.MinimizedOnStart = chkStartMinimized.Checked;

            SettingLibHelp.SaveSetting(generalSetting);

            StartupManager.SetStartWithPC(generalSetting.StartWithPc);
        }

        private void saveDashboardSetting(DashboardSetting dashboardSetting)
        {
            dashboardSetting.UpdateInterval = Convert.ToInt32(numRefreshInterval.Value);
            dashboardSetting.CpuMonitor = chkSystemCpu.Checked;
            dashboardSetting.RamMonitor = chkSystemRam.Checked;
            dashboardSetting.DiskMonitor = chkSystemDiskUsage.Checked;
            dashboardSetting.InternetMonitor = chkSystemNetwork.Checked;
            dashboardSetting.EventLogMonitor = chkSystemNotifications.Checked;

            SettingLibHelp.SaveSetting(dashboardSetting);
        }

        private void SaveTimesSetting(TimesSetting timesSetting)
        {
           
                if (!string.IsNullOrEmpty(txtPomodoroSoundPath.Text))
                {
                   FilePathServices.SaveSoundsFilePath(txtPomodoroSoundPath.Text, "PomodoroSound.wav");

                    timesSetting.PomodoroSoundName = "PomodoroSound.wav";
                }
                if (!string.IsNullOrEmpty(txtAlarmSoundPath.Text))
                {

                    FilePathServices.SaveSoundsFilePath(txtAlarmSoundPath.Text, "AlarmSound.wav");

                    timesSetting.AlarmSoundName = "AlarmSound.wav";
                }

                SettingLibHelp.SaveSetting(timesSetting);
        }
    
        private void SaveAppearanceSetting(AppearanceSetting appearanceSetting)
        {
            appearanceSetting.DarkModel = chkDarkMode.Checked;
            DarkModeChanged?.Invoke(appearanceSetting.DarkModel);
            SettingLibHelp.SaveSetting(appearanceSetting);
        }

        private void SaveClipboardSetting(ClipboardSetting clipboardSetting)
        {
            clipboardSetting.Ison = chkClipboardEnabled.Checked;
            clipboardSetting.Max = Convert.ToInt32(numClipboardHistory.Value);
            SettingLibHelp.SaveSetting(clipboardSetting);
        }

        private void SaveLauncher(HotkeySetting hotkeySetting)
        {
            hotkeySetting.Hotkeys = _Hotkeys;
            SettingLibHelp.SaveSetting(hotkeySetting);
        }

        //to hotkey

        private void btnAddHotkey_Click(object sender, EventArgs e)
        {
            using (HotkeyEditorForm dialog = new HotkeyEditorForm(DarkMode))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    HotkeyProgramDto hotkey = dialog.hotkey;

                    _Hotkeys.Add(hotkey);

                    RefreshHotkeyList();
                }
            }
        }

        private void btnDeleteHotkey_Click(object sender, EventArgs e)
        {
           int index = lstHotkeys.SelectedIndices[0];
           _Hotkeys.RemoveAt(index);
           RefreshHotkeyList();
        }

        private void RefreshHotkeyList()
        {
            lstHotkeys.Items.Clear();

            foreach (HotkeyProgramDto hotkey in _Hotkeys)
            {
                string shortcut = GetShortcutText.Get(
                    hotkey.Key,
                    hotkey.Modifiers);

                ListViewItem item = new ListViewItem(hotkey.Commands);

                item.SubItems.Add(hotkey.Launcher);
                item.SubItems.Add(shortcut);

                lstHotkeys.Items.Add(item);
            }
        }
        
        //hotkey end
    }
}
