using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Management;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using SystemMonitor.Dto;
using SystemMonitor.Interface;


namespace SystemMonitor
{
    /// <summary>
    /// Monitors the CPU and provides information about
    /// processor usage and hardware details.
    /// </summary>
    public class CpuMonitor : SystemMonitors, ICpuMonitor
    {

        private readonly PerformanceCounter _cpu;

        public CpuMonitor()
        {
           
            _cpu = new PerformanceCounter(
                "Processor",
                "% Processor Time",
                "_Total");

            _cpu.NextValue(); // Initialize counter

           
        }

        /// <summary> 
        /// Gets the current CPU usage. 
        /// </summary> 
        /// <returns> 
        /// A formatted string containing the current CPU usage percentage. 
        /// </returns>
        public override string Get()
        {
            Thread.Sleep(500);

            float usage = _cpu.NextValue();

            return $"CPU: {usage:F1}%";
        }

        /// <summary>
        /// Gets the current CPU usage in list Decimal. 
        /// </summary>
        /// <returns>List<Decimal></returns>
        public override List<Decimal> GetVal()
        {
            Thread.Sleep(500);
            float usage = _cpu.NextValue();
            return new List<Decimal> { (decimal)usage };
        }

        /// <summary> 
        /// Gets the current total CPU usage as a decimal value. 
        /// </summary> 
        /// <returns> 
        /// A list containing the current CPU usage percentage as a 
        /// <see cref="decimal"/> value. 
        /// </returns>
        public override List<DtoSystemInfo> SystemInfos()
        {
            try
            {
                ManagementObjectSearcher objectSearcher = new ManagementObjectSearcher(
                "SELECT * FROM Win32_Processor");


                var cpu = objectSearcher
                .Get()
                .Cast<ManagementObject>()
                .FirstOrDefault();

                if (cpu == null) 
                    return new List<DtoSystemInfo>();


                DtoSystemInfoCpu dtoSystemInfoCpu = new DtoSystemInfoCpu(
                    cpu["Name"].ToString(),
                    cpu["Manufacturer"].ToString(),
                    cpu["Description"].ToString(),
                    cpu["NumberOfCores"].ToString(),
                    cpu["NumberOfLogicalProcessors"].ToString(),
                    $"{cpu["MaxClockSpeed"]} MHz",
                    $"{cpu["CurrentClockSpeed"]} MHz",
                    $"{cpu["L2CacheSize"]} KB",
                    $"{cpu["L3CacheSize"]} KB",
                    cpu["ProcessorId"].ToString()
                );

                return new List<DtoSystemInfo>
                {
                    dtoSystemInfoCpu
                };
            }
            catch (Exception ex)
            {
                return new List<DtoSystemInfo>();
            }
        }

    }
}
