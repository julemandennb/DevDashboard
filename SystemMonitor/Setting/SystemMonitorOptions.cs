using System;
using System.Collections.Generic;
using System.Text;

namespace SystemMonitor.Setting
{
    public class SystemMonitorOptions
    {
        public bool CpuMonitor { get; set; } = true;

        public bool RamMonitor { get; set; } = true;

        public bool DiskMonitor { get; set; } = true;

        public bool InternetMonitor { get; set; } = true;

        public bool EventLogMonitor { get; set; } = true;
    }
}
