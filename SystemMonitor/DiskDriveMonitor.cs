using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Management;
using System.Text;
using SystemMonitor.Dto;
using SystemMonitor.Interface;

namespace SystemMonitor
{
    /// <summary>
    /// Monitors disk drives and provides information about
    /// available storage and connected drives.
    /// </summary>
    public class DiskDriveMonitor :SystemMonitors, IDiskDriveMonitor
    {
        private readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        public DiskDriveMonitor()
        {
        }

        /// <summary> 
        /// Gets the available free space for all accessible disk drives. 
        /// </summary> 
        /// <returns> 
        /// A formatted string containing the available free space 
        /// for each accessible disk drive. 
        /// </returns>
        public override string Get()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            string result = "Disk: ";

            foreach (DriveInfo drive in drives)
            {
                try
                {
                    if (!drive.IsReady)
                        continue;

                    double used =
                        100.0 -
                        ((double)drive.AvailableFreeSpace /
                        drive.TotalSize * 100.0);

                    result +=
                        $"{drive.Name} {used:F1}% used | ";

                }
                catch
                {
                }
            }

            return result.TrimEnd(' ', '|');
        }

        /// <summary> 
        /// Gets detailed information about the available disk drives. 
        /// </summary> 
        /// <returns> 
        /// A list containing information about each disk drive, 
        /// including its name, format, type, available space, 
        /// and total capacity. 
        /// </returns>
        public override List<DtoSystemInfo> SystemInfos()
        {

            DriveInfo[] drives = DriveInfo.GetDrives();

            List<DtoSystemInfo> infos = new List<DtoSystemInfo>();

            foreach (DriveInfo drive in drives)
            {
                try
                {

                    DtoSystemInfoDiskDrive dtoSystemInfoDiskDrive = new DtoSystemInfoDiskDrive(
                        drive.Name,
                        (drive.IsReady ? drive.DriveFormat : "?"),
                        drive.DriveType.ToString(),
                        (drive.IsReady ? this.SizeSuffix(drive.AvailableFreeSpace) : "0"),
                        (drive.IsReady ? this.SizeSuffix(drive.TotalSize) : "0")
                    );

                    infos.Add(dtoSystemInfoDiskDrive);

                } catch { }
            }

            return infos;
        }


        private string SizeSuffix(Int64 value, int decimalPlaces = 2)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }
    }
}
