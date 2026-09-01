using System;
using System.Collections.Generic;
using System.Text;
using SystemMonitor.Dto;

namespace SystemMonitor.Interface
{
    public interface ISystemMonitors
    {
        string Get();

        List<Decimal> GetVal();

        List<DtoSystemInfo> SystemInfos();
    }
}
