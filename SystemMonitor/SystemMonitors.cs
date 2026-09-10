using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SystemMonitor.Dto;
using SystemMonitor.Interface;
using SystemMonitor.Setting;

namespace SystemMonitor
{
    /// <summary> 
    /// Base class for all system monitor implementations. 
    /// Provides common functionality and defines the standard 
    /// operations that each monitor must implement. 
    /// </summary>
    public class SystemMonitors: ISystemMonitors
    {
        /// <summary>
        /// The settings for the system monitor, which can be used to configure
        /// </summary>
        private SystemMonitorOptions _systemMonitorSetting;

        public SystemMonitors(
            SystemMonitorOptions systemMonitorSetting = null
            ) {
            _systemMonitorSetting = systemMonitorSetting ?? new SystemMonitorOptions();
        }

        /// <summary> 
        /// Gets a human-readable summary of the current system information. 
        /// </summary> 
        /// <returns> 
        /// A string containing the current status or value provided by the 
        /// specific system monitor. 
        /// </returns> 
        /// <exception cref="NotSupportedException"> 
        /// Thrown when the method is not implemented by a derived system monitor. 
        /// </exception>
        public virtual string Get()
        {
            throw new NotSupportedException(
                   $"{GetType().Name} does not implement Get().");
        }

        /// <summary> 
        /// Gets the current monitored value as a list of decimal values. 
        /// Derived system monitors should override this method to provide 
        /// their monitored numeric value. 
        /// </summary> 
        /// <returns> 
        /// A list containing the current monitored value or values as 
        /// <see cref="decimal"/> values. 
        /// </returns> 
        /// <exception cref="NotSupportedException"> 
        /// Thrown when the method is not implemented by a derived system monitor. 
        /// </exception>
        public virtual List<decimal> GetVal()
        {
            throw new NotSupportedException(
                 $"{GetType().Name} does not implement GetVal().");
        }

        /// <summary> 
        /// Gets detailed system information collected by the specific system monitor. 
        /// </summary> 
        /// <returns> 
        /// A list of <see cref="DtoSystemInfo"/> objects containing detailed 
        /// information about the monitored system component. 
        /// </returns> 
        /// <exception cref="NotSupportedException"> 
        /// Thrown when the method is not implemented by a derived system monitor. 
        /// </exception>
        public virtual List<DtoSystemInfo> SystemInfos()
        {
            throw new NotSupportedException(
                 $"{GetType().Name} does not implement SystemInfos().");
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
