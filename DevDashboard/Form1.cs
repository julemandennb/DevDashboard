using DevDashboard.Control;
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
            //_DashboardControl = new DashboardControl();
            _TimesControl = new TimesControl();
            _ClipboardControl = new ClipboardControl();
            _LauncherControl = new LauncherControl();
            _GitHubControl = new GitHubControl();
            _SettingsControl = new SettingsControl();

            InitializeComponent();
            ShowPage(_TimesControl);
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
