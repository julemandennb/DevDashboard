using System.Threading.Tasks;
using SystemMonitor;
using SystemMonitor.Dto;
using SystemMonitor.Interface;

namespace DevDashboard
{
    public partial class Form1 : Form
    {
        private List<ISystemMonitors> _systems;

        public Form1()
        {
            InitializeComponent();
            systemMonitorsAdd();
        }

        private void systemMonitorsAdd()
        {
            SystemMonitors systemMonitors = new SystemMonitors();
            _ = Task.Run(async () =>
            {
                _systems = await systemMonitors.GetAll();

                this.SetMonitorInfo();

                
                this.BeginInvoke(new Action(() =>
                {
                    systemInfoTimer.Enabled = true;
                }));

            });
        }

        private async void systemInfoTimer_Tick(object sender, EventArgs e)
        {
            systemInfoTimer.Enabled = false;
            _ = Task.Run(async () =>
            {
                this.SetMonitorInfo();
                this.BeginInvoke(new Action(() =>
                {
                    systemInfoTimer.Enabled = true;
                }));
            });
            string ff = "ff";
        }

        private void SetMonitorInfo()
        {
            foreach (var systemMonitor in _systems)
            {
                try
                {
                    if (systemMonitor is ICpuMonitor cpu)
                    {
                        var percentage = cpu.GetVal();

                        string percentageText = Math.Round(percentage[0], 0) + "%";

                        this.BeginInvoke(new Action(() =>
                        {
                            lblCpuValue.Text = percentageText;
                        }));

                    }
                    else if (systemMonitor is IRamMonitor ram)
                    {
                        var percentage = ram.GetVal();
                        string percentageText = Math.Round(percentage[0], 0) + "%";
                        this.BeginInvoke(new Action(() =>
                        {
                            lblRamValue.Text = percentageText;
                        }));
                    }
                    else if (systemMonitor is DiskDriveMonitor diskDrive)
                    {
                        List<decimal> percentage = diskDrive.GetVal();

                        string percentageText = "";
                        foreach (var item in percentage)
                        {
                            if (item == percentage.Last())
                            {
                                percentageText += Math.Round(item, 0) + "%";
                                break;
                            }
                            else
                                percentageText += Math.Round(item, 0) + "% ,";

                        }
                        this.BeginInvoke(new Action(() =>
                        {
                            lblDiskValue.Text = percentageText;
                        }));
                    }
                    else if (systemMonitor is InternetMonitor internet)
                    {
                        List<decimal> percentage = internet.GetVal();

                        string percentageText = Math.Round(percentage[0], 0) + "ms";

                        this.BeginInvoke(new Action(() =>
                        {
                            lblNetworkValue.Text = percentageText;
                        }));
                    }


                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
