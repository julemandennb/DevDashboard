using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debugger.Break();
            throw new NotSupportedException(
                "Get() must be implemented by a specific system monitor.");
        }

        public virtual List<string> SystemInfos()
        {
            Debugger.Break();
            throw new NotSupportedException(
                "SystemInfos() must be implemented by a specific system monitor.");
        }

        public async Task<List<ISystemMonitors>> GetAll()
        {
            return await Task.Run(() =>
            {
                return new List<ISystemMonitors>
                {
                    new CpuMonitor(),
                    new RamMonitor()
                };
            });
        }
    }
}
