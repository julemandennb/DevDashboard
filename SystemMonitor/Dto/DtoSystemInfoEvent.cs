using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SystemMonitor.Dto
{
    public class DtoSystemInfoEvent : DtoSystemInfo
    {
        public int EventId { get; private set; }

        public string Level { get; private set; }

        public string Provider { get; private set; }

        public DateTime? TimeCreated { get; private set; }

        public string Message { get; private set; }

        public DtoSystemInfoEvent(
             int eventId,
            string level,
            string provider,
            DateTime? timeCreated,
            string message
        ) : base("EventLog")
        {
            EventId = eventId;
            Level = level;
            Provider = provider;
            TimeCreated = timeCreated;
            Message = message;
        }
    }
}
