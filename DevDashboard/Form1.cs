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
        private DashboardControl _DashboardControl;
        private TimesControl _TimesControl;
        private ClipboardControl _ClipboardControl;
        private LauncherControl _LauncherControl;
        private GitHubControl _GitHubControl;
        private SettingsControl _SettingsControl;


        public Form1()
        {

            darkMode = true;
            _DashboardControl = new DashboardControl(darkMode);
            _TimesControl = new TimesControl(darkMode);
            _ClipboardControl = new ClipboardControl(darkMode);
            _LauncherControl = new LauncherControl(darkMode);
            _GitHubControl = new GitHubControl(darkMode);
            _SettingsControl = new SettingsControl(darkMode);

            InitializeComponent();
            ShowPage(_DashboardControl);
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
