using System;
using System.Collections.Generic;
using System.Text;

namespace SystemMonitor.Dto
{
    public class DtoSystemInfo
    {
        public string SystemMonitor {  get; private set; }

        public DtoSystemInfo(string systemMonitor)
        {
            SystemMonitor = systemMonitor;
        }
    }
}
