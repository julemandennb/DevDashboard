using Settings;
using Settings.Models;
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

        private List<Setting> _settings = new List<Setting>();

        public SettingsControl()
        {
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

            DashboardSetting dashboardSetting = AddToList<DashboardSetting>(GetSettingsFile<DashboardSetting>().Load());

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
            AddToList<TimesSetting>(GetSettingsFile<TimesSetting>().Load());
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
            // Save settings here
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset settings to default here
        }

        private void chkDarkMode_CheckedChanged(
            object sender,
            EventArgs e)
        {
            // Apply global theme here
        }


        private SettingsFile<T> GetSettingsFile<T>()
        where T : Setting, new()
        {
            return new SettingsFile<T>();
        }

        private T AddToList<T>(T setting) where T : Setting
        {
            Setting? existing = _settings.Find(x => x.GetType() == typeof(T));

            if (existing != null)
            {
                return (T)existing;
            }

            _settings.Add(setting);
            return setting;
        }

        private T? GetSetting<T>() where T : Setting
        {
            return _settings.OfType<T>().FirstOrDefault();
        }

        private void SaveSetting<T>(T setting)
            where T : Setting, new()
        {
            GetSettingsFile<T>().Save(setting);
        }
    }
}
