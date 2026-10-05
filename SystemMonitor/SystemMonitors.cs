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
    public abstract class SystemMonitors: ISystemMonitors
    {
      
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
        public abstract string Get();

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
        public abstract List<decimal> GetVal();

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
        public abstract List<DtoSystemInfo> SystemInfos();

        
    }
}
