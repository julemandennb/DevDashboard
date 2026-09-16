using DevDashboard.Help;
using Settings;
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

        private Setting isOn = null;

        public SettingsControl(bool darkModeOn)
        {
            darkMode = darkModeOn;
            InitializeComponent();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            ShowPage(generalPage);
            SetSelectedTab(btnGeneral);
        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {
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
            ShowPage(clipboardPage);
            SetSelectedTab(btnClipboard);
        }

        private void ShowPage(Panel page)
        {
            generalPage.Visible = false;
            appearancePage.Visible = false;
            dashboardPage.Visible = false;
            timePage.Visible = false;
            clipboardPage.Visible = false;

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
                btnClipboard
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
                case DashboardSetting dashboardSetting:
                    saveDashboardSetting(dashboardSetting);
                    break;

                case TimesSetting timesSetting:
                    SaveTimesSetting(timesSetting);
                    break;
                default:
                    break;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            switch (isOn)
            {
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
                default:
                    break;
            }
        }

        private void chkDarkMode_CheckedChanged(
            object sender,
            EventArgs e)
        {
            // Apply global theme here
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
    }
}
