using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Management;
using System.Text;
using SystemMonitor.Dto;
using SystemMonitor.Interface;

namespace SystemMonitor
{
    public class RamMonitor: SystemMonitors, IRamMonitor
    {
        private readonly PerformanceCounter _ram;


        public RamMonitor()
        {
            _ram = new PerformanceCounter("Memory", "Available MBytes");

         
        }

        public override string Get()
        {

            return $"RAM: {_ram.NextValue():F0} MB available";
        }

        public override List<DtoSystemInfo> SystemInfos()
        {
            ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher(
               "SELECT * FROM Win32_PhysicalMemory");


            var memories = objectSearcher
               .Get()
               .Cast<ManagementObject>();

            var infos = new List<DtoSystemInfo>();

 
            foreach (var ram in memories)
            {
                try
                {

                    DtoSystemInfoRam systemInfoRam = new DtoSystemInfoRam(
                        ram["Manufacturer"].ToString(),
                        $"{Convert.ToUInt64(ram["Capacity"]) / 1024 / 1024 / 1024} GB",
                        $"{ram["Speed"]} MHz",
                        ram["PartNumber"].ToString(),
                        ram["DeviceLocator"].ToString(),
                        ram["MemoryType"].ToString()
                     );
                        

                    infos.Add(systemInfoRam);
                }
                catch
                {
                }
            }



            return infos;
        }
    }
}
