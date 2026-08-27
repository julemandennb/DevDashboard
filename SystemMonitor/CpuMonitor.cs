using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;
using SystemMonitor.Interface;
using System.Management;


namespace SystemMonitor
{
    public class CpuMonitor : SystemMonitors, ICpuMonitor
    {

        private readonly PerformanceCounter _cpu;
        private readonly ManagementObjectSearcher _objectSearcher;

        public CpuMonitor()
        {
            _objectSearcher = new ManagementObjectSearcher(
           "SELECT * FROM Win32_Processor");

            _cpu = new PerformanceCounter(
                "Processor",
                "% Processor Time",
                "_Total");

            _cpu.NextValue(); // Initialize counter

           
        }

        public override string Get()
        {
            Thread.Sleep(500);

            float usage = _cpu.NextValue();

            return $"CPU: {usage:F1}%";
        }

        public override List<string> SystemInfos()
        {
            var cpu = _objectSearcher
            .Get()
            .Cast<ManagementObject>()
            .FirstOrDefault();

            return new List<string>
            {
                $"Name: {cpu["Name"]}",
                $"Manufacturer: {cpu["Manufacturer"]}",
                $"Description: {cpu["Description"]}",
                $"Cores: {cpu["NumberOfCores"]}",
                $"Logical Processors: {cpu["NumberOfLogicalProcessors"]}",
                $"Max Clock Speed: {cpu["MaxClockSpeed"]} MHz",
                $"Current Clock Speed: {cpu["CurrentClockSpeed"]} MHz",
                $"L2 Cache: {cpu["L2CacheSize"]} KB",
                $"L3 Cache: {cpu["L3CacheSize"]} KB",
                $"Processor ID: {cpu["ProcessorId"]}"
            };
        }

    }
}
