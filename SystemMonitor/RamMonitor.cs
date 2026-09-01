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
    /// <summary> 
    /// Monitors system RAM and provides information about 
    /// memory usage and installed physical memory. 
    /// </summary>
    public class RamMonitor: SystemMonitors, IRamMonitor
    {
        private readonly PerformanceCounter _ram;


        public RamMonitor()
        {
            _ram = new PerformanceCounter("Memory", "Available MBytes");

         
        }

        /// <summary> 
        /// Gets the current available RAM. 
        /// </summary> 
        /// <returns> 
        /// A formatted string containing the amount of available memory in megabytes. 
        /// </returns>
        public override string Get()
        {
            try
            {
                using ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(
                        "SELECT TotalVisibleMemorySize, FreePhysicalMemory FROM Win32_OperatingSystem");

                ManagementObject os =
                    searcher.Get()
                        .Cast<ManagementObject>()
                        .First();

                ulong total = Convert.ToUInt64(os["TotalVisibleMemorySize"]);
                ulong free = Convert.ToUInt64(os["FreePhysicalMemory"]);

                ulong used = total - free;

                double totalGb = total / 1024.0 / 1024.0;
                double usedGb = used / 1024.0 / 1024.0;

                double usage = (double)used / total * 100;

                return $"RAM: {usedGb:F1} / {totalGb:F1} GB ({usage:F1}%)";
            }
            catch
            {
                return "RAM: Unknown";
            }
        }

        /// <summary> 
        /// Gets the current percentage of physical RAM in use. 
        /// </summary> 
        /// <returns> 
        /// A list containing the current RAM usage percentage as a 
        /// <see cref="decimal"/> value. 
        /// Returns <c>0</c> if the RAM usage cannot be determined. 
        /// </returns>
        public override List<Decimal> GetVal()
        {
            try
            {
                using ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher(
                        "SELECT TotalVisibleMemorySize, FreePhysicalMemory FROM Win32_OperatingSystem");
                ManagementObject os =
                    searcher.Get()
                        .Cast<ManagementObject>()
                        .First();
                ulong total = Convert.ToUInt64(os["TotalVisibleMemorySize"]);
                ulong free = Convert.ToUInt64(os["FreePhysicalMemory"]);
                ulong used = total - free;
                double usage = (double)used / total * 100;
                return new List<decimal> { (decimal)usage };
            }
            catch
            {
                return new List<decimal> { 0 };
            }
        }

        /// <summary> 
        /// Gets detailed information about the installed physical RAM modules. 
        /// </summary> 
        /// <returns> 
        /// A list containing information about each installed RAM module, 
        /// including the manufacturer, capacity, speed, part number, 
        /// device location, and memory type. 
        /// </returns>
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
