using System;
using System.Collections.Generic;
using System.Text;

namespace SystemMonitor.Dto
{
    public class DtoSystemInfoRam : DtoSystemInfo
    {
        public string Manufacturer { get; private set; }
        public string Capacity { get; private set; }
        public string Speed { get; private set; }
        public string PartNumber { get; private set; }
        public string DeviceLocator { get; private set; }
        public string MemoryType { get; private set; }

        public DtoSystemInfoRam(
            string manufacturer,
        string capacity,
        string speed,
        string partNumber,
        string deviceLocator,
        string memoryType):base("Ram")
        {
            Manufacturer = manufacturer;
            Capacity = capacity;
            Speed = speed;
            PartNumber = partNumber;
            DeviceLocator = deviceLocator;
            MemoryType = memoryType;
        }
    }
}
