using DevDashboard.Control;
using DevDashboard.Help;
using Settings.Models;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using SystemMonitor;
using SystemMonitor.Dto;
using SystemMonitor.Interface;

namespace DevDashboard
{
    public partial class Form1 : Form
    {
        private AppearanceSetting _appearanceSetting;


        private DashboardControl _DashboardControl;
        private TimesControl _TimesControl;
        private ClipboardControl _ClipboardControl;
        private LauncherControl _LauncherControl;
        private GitHubControl _GitHubControl;
        private SettingsControl _SettingsControl;


        public Form1()
        {
            _appearanceSetting = SettingLibHelp.GetSettingsFile<AppearanceSetting>().Load();
            DarkMode = _appearanceSetting.DarkModel;

            _DashboardControl = new DashboardControl(DarkMode);
            _TimesControl = new TimesControl(DarkMode);
            _ClipboardControl = new ClipboardControl(DarkMode);
            _LauncherControl = new LauncherControl(DarkMode);
            _GitHubControl = new GitHubControl(DarkMode);
            _SettingsControl = new SettingsControl(DarkMode);
            _SettingsControl.DarkModeChanged += SettingsControl_DarkModeChanged;

            InitializeComponent();
            ShowPage(_DashboardControl);
        }

        private void SettingsControl_DarkModeChanged(bool value)
        {
            DarkMode = value;

            _DashboardControl.DarkMode = value;
            _TimesControl.DarkMode = value;
            /*_ClipboardControl.DarkMode = value;
            _LauncherControl.DarkMode = value;
            _GitHubControl.DarkMode = value;*/
            _SettingsControl.DarkMode = value;
        }

        private void ShowPage(UserControl page) { 

            contentPanel.Controls.Clear(); 
            page.Dock = DockStyle.Fill; 
            contentPanel.Controls.Add(page);
        }

        private void btnDashboard_Click(object sender, EventArgs e) 
        { 
            ShowPage(_DashboardControl);
        }

        private void btnTimers_Click(object sender, EventArgs e) 
        { 
            ShowPage(_TimesControl);
        }

        private void btnClipboard_Click(object sender, EventArgs e) 
        { 
            ShowPage(_ClipboardControl);
        }

        private void btnLauncher_Click(object sender, EventArgs e)
        { 
            ShowPage(_LauncherControl);
        }

        private void btnGitHub_Click(object sender, EventArgs e) 
        { 
            ShowPage(_GitHubControl);
        }

        private void btnSettings_Click(object sender, EventArgs e) 
        { 
            ShowPage(_SettingsControl);
        }

    }
}
