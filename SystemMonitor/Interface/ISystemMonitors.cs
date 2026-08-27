using System;
using System.Collections.Generic;
using System.Text;

namespace SystemMonitor.Interface
{
    public interface ISystemMonitors
    {
        string Get();

        List<string> SystemInfos();
    }
}
