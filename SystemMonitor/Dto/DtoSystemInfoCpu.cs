using System;
using System.Collections.Generic;
using System.Text;

namespace SystemMonitor.Dto
{
    public class DtoSystemInfoCpu: DtoSystemInfo
    {
        public string Name { get; private set; }
        public string Manufacturer { get; private set; }

        public string Description { get; private set; }

        public string Cores { get; private set; }

        public string LogicalProcessors { get; private set; }

        public string MaxClockSpeed { get; private set; }

        public string CurrentClockSpeed { get; private set; }

        public string L2Cache { get; private set; }

        public string L3Cache { get; private set; }

        public string ProcessorId { get; private set; }

        public DtoSystemInfoCpu (
            string name, 
            string manufacturer,
            string description,
            string cores,
            string logicalProcessors,
            string maxClockSpeed,
            string currentClockSpeed,
            string l2Cache,
            string l3Cache,
            string processorId
        ) :base("Cpu")
        {
            Name = name;
            Manufacturer = manufacturer;
            Description = description;
            Cores = cores;
            LogicalProcessors = logicalProcessors;
            MaxClockSpeed = maxClockSpeed;
            CurrentClockSpeed = currentClockSpeed;
            L2Cache = l2Cache;
            L3Cache = l3Cache;
            ProcessorId = processorId;
        }
    }
}
