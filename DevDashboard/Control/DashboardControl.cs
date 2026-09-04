using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemMonitor;
using SystemMonitor.Dto;
using SystemMonitor.Interface;


namespace DevDashboard.Control
{
    public partial class DashboardControl : UserControl
    {
        private List<ISystemMonitors> _systems = new List<ISystemMonitors>();

        public DashboardControl()
        {
            InitializeComponent();
            SystemMonitorsAdd();
        }

        private void SystemMonitorsAdd()
        {
            SystemMonitors systemmonitors = new SystemMonitors();
            _ = Task.Run(async () =>
            {
                _systems = await systemmonitors.GetAll();

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
        }

        private void SetMonitorInfo()
        {
            foreach (var systemmonitor in _systems)
            {
                try
                {
                    if (systemmonitor is ICpuMonitor cpu)
                    {
                        var percentage = cpu.GetVal();

                        string percentagetext = Math.Round(percentage[0], 0) + "%";

                        this.BeginInvoke(new Action(() =>
                        {
                            lblCpuValue.Text = percentagetext;
                        }));

                    }
                    else if (systemmonitor is IRamMonitor ram)
                    {
                        var percentage = ram.GetVal();
                        string percentagetext = Math.Round(percentage[0], 0) + "%";
                        this.BeginInvoke(new Action(() =>
                        {
                            lblRamValue.Text = percentagetext;
                        }));
                    }
                    else if (systemmonitor is IDiskDriveMonitor diskdrive)
                    {
                        List<decimal> percentage = diskdrive.GetVal();

                        string percentagetext = "";
                        foreach (var item in percentage)
                        {
                            if (item == percentage.Last())
                            {
                                percentagetext += Math.Round(item, 0) + "%";
                                break;
                            }
                            else
                                percentagetext += Math.Round(item, 0) + "% ,";

                        }
                        this.BeginInvoke(new Action(() =>
                        {
                            lblDiskValue.Text = percentagetext;
                        }));
                    }
                    else if (systemmonitor is IInternetMonitor internet)
                    {
                        List<decimal> percentage = internet.GetVal();

                        string percentagetext = Math.Round(percentage[0], 0) + "ms";

                        this.BeginInvoke(new Action(() =>
                        {
                            lblNetworkValue.Text = percentagetext;
                        }));
                    }
                    else if (systemmonitor is IEventLogMonitor eventLog)
                    {
                        var infos = eventLog.SystemInfos();

                        var eventTexts = infos
                            .OfType<DtoSystemInfoEvent>()
                            .Reverse()
                            .Select(item =>
                                $"{item.EventId} - {item.Level} - {item.Provider} - " +
                                $"{item.TimeCreated} - {item.Message}")
                            .ToList();

                        BeginInvoke(new Action(() =>
                        {
                            foreach (string text in eventTexts)
                            {
                                if (!systemNotificationList.Items.Contains(text))
                                {
                                    systemNotificationList.Items.Insert(0, text);
                                }
                            }
                        }));
                    }


                }
                catch (Exception ex)
                {
                    Debugger.Break();
                }
            }
        }
    }
}
