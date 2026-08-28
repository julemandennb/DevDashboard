using System;
using System.Collections.Generic;
using System.Text;

namespace SystemMonitor.Dto
{
    public class DtoSystemInfoInternet : DtoSystemInfo
    {
        public string Name { get; private set; }

        public string Type { get; private set; }

        public string Description { get; private set; }

        public string Speed { get; private set; }

        public bool Connected { get; private set; }

        public DtoSystemInfoInternet(
            string name,
            string type,
            string description,
            string speed,
            bool connected
        ) : base("Internet")
        {
            Name = name;
            Type = type;
            Description = description;
            Speed = speed;
            Connected = connected;
        }
    }
}
