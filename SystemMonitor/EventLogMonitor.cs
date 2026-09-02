using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using SystemMonitor.Dto;
using SystemMonitor.Interface;

namespace SystemMonitor
{
    /// <summary>
    /// Monitors Windows System Event Log and provides information about
    /// Critical, Error, Warning, and Information events.
    /// </summary>
    public class EventLogMonitor : SystemMonitors, IEventLogMonitor
    {
        /// <summary>
        /// Gets a summary of the latest Windows System events.
        /// </summary>
        /// <returns>
        /// A formatted string containing the number of Critical, Error,
        /// Warning, and Information events.
        /// </returns>
        public override string Get()
        {
            try
            {
                List<WindowsEventInfo> events = GetEvents();

                int critical = events.Count(e => e.Level == "Critical");
                int error = events.Count(e => e.Level == "Error");
                int warning = events.Count(e => e.Level == "Warning");
                int information = events.Count(e => e.Level == "Information");

                return $"Events: Critical {critical}, " +
                       $"Error {error}, " +
                       $"Warning {warning}, " +
                       $"Information {information}";
            }
            catch
            {
                return "Events: Unknown";
            }
        }

        /// <summary>
        /// Gets the number of Critical, Error, Warning,
        /// and Information events.
        /// </summary>
        /// <returns>
        /// A list containing the event counts in the following order:
        /// Critical, Error, Warning, Information.
        /// </returns>
        public override List<decimal> GetVal()
        {
            try
            {
                List<WindowsEventInfo> events = GetEvents();

                int critical = events.Count(e => e.Level == "Critical");
                int error = events.Count(e => e.Level == "Error");
                int warning = events.Count(e => e.Level == "Warning");
                int information = events.Count(e => e.Level == "Information");

                return new List<decimal>
                {
                    critical,
                    error,
                    warning,
                    information
                };
            }
            catch
            {
                return new List<decimal>
                {
                    0,
                    0,
                    0,
                    0
                };
            }
        }

        /// <summary>
        /// Gets detailed information about Windows System Events.
        /// </summary>
        /// <returns>
        /// A list containing Critical, Error, Warning, and Information
        /// events from the Windows System Event Log.
        /// </returns>
        public override List<DtoSystemInfo> SystemInfos()
        {
            List<DtoSystemInfo> infos =
                new List<DtoSystemInfo>();

            try
            {
                List<WindowsEventInfo> events = GetEvents();

                foreach (WindowsEventInfo item in events)
                {
                    try
                    {
                        DtoSystemInfoEvent systemInfo =
                            new DtoSystemInfoEvent(
                                item.Id,
                                item.Level,
                                item.Provider,
                                item.TimeCreated,
                                item.Message
                            );

                        infos.Add(systemInfo);
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }

            return infos;
        }

        /// <summary>
        /// Reads events from the Windows System Event Log.
        /// </summary>
        private List<WindowsEventInfo> GetEvents()
        {
            List<WindowsEventInfo> events =
                new List<WindowsEventInfo>();

            string query = @"
        *[
            System[
                Level = 1 or
                Level = 2 or
                Level = 3 or
                Level = 4
            ]
        ]";

            EventLogQuery eventQuery =
                new EventLogQuery(
                    "System",
                    PathType.LogName,
                    query)
                {
                    ReverseDirection = true
                };

            using EventLogReader reader =
                new EventLogReader(eventQuery);

            const int maxEvents = 100;

            for (int i = 0; i < maxEvents; i++)
            {
                using EventRecord record = reader.ReadEvent();

                if (record == null)
                    break;

                events.Add(
                    new WindowsEventInfo
                    {
                        Id = record.Id,
                        Level = record.LevelDisplayName ?? "Unknown",
                        Provider = record.ProviderName ?? "Unknown",
                        TimeCreated = record.TimeCreated,
                        Message = record.FormatDescription() ?? ""
                    });
            }

            return events;
        }
    }

    /// <summary>
    /// Internal representation of a Windows Event Log event.
    /// </summary>
    internal class WindowsEventInfo
    {
        public int Id { get; set; }

        public string Level { get; set; } = "";

        public string Provider { get; set; } = "";

        public DateTime? TimeCreated { get; set; }

        public string Message { get; set; } = "";
    }
}