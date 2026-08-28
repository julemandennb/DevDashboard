using System;
using System.Collections.Generic;
using System.Text;

namespace SystemMonitor.Dto
{
    public class DtoSystemInfoDiskDrive: DtoSystemInfo
    {

        public string Name { get; private set; }
        public string DriveFormat { get; private set; }
        public string DriveType { get; private set; }
        public string AvailableFreeSpace { get; private set; }
        public string TotalSize { get; private set; }

        public DtoSystemInfoDiskDrive(
            string name,
            string driveFormat,
            string driveType,
            string availableFreeSpace,
            string totalSize
        ) : base("DiskDrive")
        {
            Name = name;
            DriveFormat = driveFormat;
            DriveType = driveType;
            AvailableFreeSpace = availableFreeSpace;
            TotalSize = totalSize;
        }
    }
}
