using System;
using System.Collections.Generic;
using System.Text;
using SystemMonitor.Interface;

namespace SystemMonitor
{
    public class SystemMonitors: ISystemMonitors
    {
        public SystemMonitors() {

        }

        public virtual string Get()
        {
            return "SystemMonitors";
        }

        public virtual List<string> SystemInfos()
        {
            return new List<string>();
        }

        public async Task<List<ISystemMonitors>> GetAll()
        {
            List<ISystemMonitors> systems = new List<ISystemMonitors>();
            systems.Add(new CpuMonitor());

            return systems;

        }
    }
}
