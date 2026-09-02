using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SystemMonitor.Dto;
using SystemMonitor.Interface;

namespace SystemMonitor
{
    /// <summary> 
    /// Base class for all system monitor implementations. 
    /// Provides common functionality and defines the standard 
    /// operations that each monitor must implement. 
    /// </summary>
    public class SystemMonitors: ISystemMonitors
    {
        public SystemMonitors() {

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
            Debugger.Break();
            throw new NotSupportedException(
                "Get() must be implemented by a specific system monitor.");
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
        public virtual List<Decimal> GetVal()
        {
            Debugger.Break();
            throw new NotSupportedException(
                "GetVal() must be implemented by a specific system monitor.");
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
            Debugger.Break();
            throw new NotSupportedException(
                "SystemInfos() must be implemented by a specific system monitor.");
        }

        /// <summary> 
        /// Creates and returns all available system monitors. 
        /// </summary> 
        /// <returns> 
        /// A task containing a list of system monitors, including CPU, RAM, 
        /// disk drive, and internet monitors. 
        /// </returns>
        public async Task<List<ISystemMonitors>> GetAll()
        {
            return await Task.Run(() =>
            {
                return new List<ISystemMonitors>
                {
                    new CpuMonitor(),
                    new RamMonitor(),
                    new DiskDriveMonitor(),
                    new InternetMonitor(),
                    new EventLogMonitor(),
                };
            });
        }
    }
}
