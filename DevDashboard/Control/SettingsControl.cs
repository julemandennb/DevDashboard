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
            ShowPage(dashboardPage);
            SetSelectedTab(btnDashboard);
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
            chkDarkMode.Checked = true;
            chkStartWithWindows.Checked = false;
            chkStartMinimized.Checked = false;
            chkSystemNotifications.Checked = true;
            chkClipboardEnabled.Checked = true;
            numRefreshInterval.Value = 2500;
        }

        private void chkDarkMode_CheckedChanged(
            object sender,
            EventArgs e)
        {
            // Apply global theme here
        }
    }
}
