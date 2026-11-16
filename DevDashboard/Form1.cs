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
        private GeneralSetting _generalSetting;


        private DashboardControl _DashboardControl;
        private TimesControl _TimesControl;
        private ClipboardControl _ClipboardControl;
        private LauncherControl _LauncherControl;
        private SettingsControl _SettingsControl;


        public Form1()
        {
            _appearanceSetting = SettingLibHelp.GetSettingsFile<AppearanceSetting>().Load();
            DarkMode = _appearanceSetting.DarkModel;

            _generalSetting = SettingLibHelp.GetSettingsFile<GeneralSetting>().Load();

            _DashboardControl = new DashboardControl(DarkMode);
            _TimesControl = new TimesControl(DarkMode);
            _ClipboardControl = new ClipboardControl(DarkMode);
            _LauncherControl = new LauncherControl(DarkMode);

            _SettingsControl = new SettingsControl(DarkMode);
            _SettingsControl.DarkModeChanged += SettingsControl_DarkModeChanged;
            _SettingsControl.OpdateSetting += OpdateSetting;

            InitializeComponent();
            ShowPage(_DashboardControl);

            this.WindowState = _generalSetting.MinimizedOnStart ? FormWindowState.Minimized : FormWindowState.Normal;
        }

        private void OpdateSetting()
        {
            _DashboardControl.OpdateSetting();
            _TimesControl.OpdateSetting();
            _ClipboardControl.OpdateSetting();
            _LauncherControl.OpdateSetting();
        }

        private void SettingsControl_DarkModeChanged(bool value)
        {
            DarkMode = value;

            _DashboardControl.DarkMode = value;
            _TimesControl.DarkMode = value;
            _ClipboardControl.DarkMode = value;
            _LauncherControl.DarkMode = value;
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

        private void btnSettings_Click(object sender, EventArgs e) 
        { 
            ShowPage(_SettingsControl);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _DashboardControl?.Dispose();
                _TimesControl?.Dispose();
                _ClipboardControl?.Dispose();
                _LauncherControl?.Dispose();
                _SettingsControl?.Dispose();

                components?.Dispose();
            }

            base.Dispose(disposing);
        }

    }
}
