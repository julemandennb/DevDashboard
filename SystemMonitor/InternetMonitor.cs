using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using SystemMonitor.Dto;
using SystemMonitor.Interface;

namespace SystemMonitor
{
    /// <summary>
    /// Monitors network connections and provides information about
    /// network adapters and internet connectivity.
    /// </summary>
    public class InternetMonitor : SystemMonitors, IInternetMonitor
    {
        public InternetMonitor()
        {
        }

        /// <summary> 
        /// Checks the current internet connection and measures the network latency. 
        /// </summary> 
        /// <returns> 
        /// A formatted string indicating whether the internet is connected 
        /// and, when available, the round-trip latency in milliseconds. 
        /// </returns>
        public override string Get()
        {
            try
            {
                using Ping ping = new Ping();

                PingReply reply = ping.Send(
                    "8.8.8.8",
                    3000);

                if (reply.Status == IPStatus.Success)
                {
                    return $"Internet: Connected - {reply.RoundtripTime} ms";
                }

                return "Internet: Disconnected";
            }
            catch
            {
                return "Internet: Disconnected";
            }
        }

        /// <summary> 
        /// Gets detailed information about the active network adapters. 
        /// </summary> 
        /// <returns> 
        /// A list containing information about the available network adapters, 
        /// including their name, type, description, speed, and connection status. 
        /// </returns>
        public override List<DtoSystemInfo> SystemInfos()
        {
            NetworkInterface[] networks =
                NetworkInterface.GetAllNetworkInterfaces();

            List<DtoSystemInfo> infos =
                new List<DtoSystemInfo>();

            foreach (NetworkInterface network in networks)
            {
                try
                {
                    if (network.OperationalStatus != OperationalStatus.Up)
                        continue;

                    string speed = FormatSpeed(network.Speed);
                    bool connected =
                        network.OperationalStatus == OperationalStatus.Up;

                    DtoSystemInfoInternet dto =
                        new DtoSystemInfoInternet(
                            network.Name,
                            network.NetworkInterfaceType.ToString(),
                            network.Description,
                            speed,
                            connected
                        );

                    infos.Add(dto);
                }
                catch
                {
                }
            }

            return infos;
        }

        private string FormatSpeed(long speed)
        {
            if (speed <= 0)
                return "Unknown";

            if (speed >= 1_000_000_000)
                return $"{speed / 1_000_000_000} Gbps";

            return $"{speed / 1_000_000} Mbps";
        }
    }
}

