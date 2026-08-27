using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Text;
using SystemMonitor.Interface;

namespace SystemMonitor
{
    public class RamMonitor: SystemMonitors, IRamMonitor
    {
        private readonly PerformanceCounter _ram;
        private readonly ManagementObjectSearcher _objectSearcher;


        public RamMonitor()
        {
            _ram = new PerformanceCounter("Memory", "Available MBytes");

            _objectSearcher = new ManagementObjectSearcher(
               "SELECT * FROM Win32_PhysicalMemory");

        }

        public override string Get()
        {
            return $"RAM: {_ram.NextValue():F0} MB available";
        }

        public override List<string> SystemInfos()
        {
            var memories = _objectSearcher
               .Get()
               .Cast<ManagementObject>();

            var infos = new List<string>();

            foreach (var ram in memories)
            {
                infos.Add($"Manufacturer: {ram["Manufacturer"]}");
                infos.Add($"Capacity: {Convert.ToUInt64(ram["Capacity"]) / 1024 / 1024 / 1024} GB");
                infos.Add($"Speed: {ram["Speed"]} MHz");
                infos.Add($"Part Number: {ram["PartNumber"]}");
                infos.Add($"Device Locator: {ram["DeviceLocator"]}");
                infos.Add($"Memory Type: {ram["MemoryType"]}");
            }

            return infos;
        }
    }
}
