using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Models
{
    public class DashboardSetting: Setting
    {
        public bool CpuMonitor { get; set; } = true;

        public bool RamMonitor { get; set; } = true;

        public bool DiskMonitor { get; set; } = true;

        public bool InternetMonitor { get; set; } = true;

        public bool EventLogMonitor { get; set; } = true;

        public DashboardSetting() : base("Dashboard.json")
        {
        }
    }
}
