using System;
using System.Collections.Generic;
using System.Text;
using SystemMonitor.Interface;
using SystemMonitor.Setting;

namespace SystemMonitor
{
    public class SystemMonitorsLoader
    {

        /// <summary>
        /// The settings for the system monitor, which can be used to configure
        /// </summary>
        private SystemMonitorOptions _systemMonitorSetting;

        public SystemMonitorsLoader(
            SystemMonitorOptions systemMonitorSetting = null
            )
        {
            _systemMonitorSetting = systemMonitorSetting ?? new SystemMonitorOptions();
        }

        public void SetSystemMonitorSetting(SystemMonitorOptions systemMonitorSetting)
        {
            _systemMonitorSetting = systemMonitorSetting ?? new SystemMonitorOptions();
        }


        /// <summary> 
        /// Creates and returns all available system monitors. 
        /// </summary> 
        /// <returns> 
        /// A task containing a list of system monitors, including CPU, RAM, 
        /// disk drive, and internet monitors. 
        /// </returns>
        public Task<List<ISystemMonitors>> GetAll()
        {
            var monitors = new List<ISystemMonitors>();

            if (_systemMonitorSetting.CpuMonitor)
            {
                monitors.Add(new CpuMonitor());
            }

            if (_systemMonitorSetting.RamMonitor)
            {
                monitors.Add(new RamMonitor());
            }

            if (_systemMonitorSetting.DiskMonitor)
            {
                monitors.Add(new DiskDriveMonitor());
            }

            if (_systemMonitorSetting.InternetMonitor)
            {
                monitors.Add(new InternetMonitor());
            }

            if (_systemMonitorSetting.EventLogMonitor)
            {
                monitors.Add(new EventLogMonitor());
            }

            return Task.FromResult(monitors);
        }
    }
}
