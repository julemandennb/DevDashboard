using Settings.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Services
{
    internal static class PathServices
    {
        public static DtoPathServices Root
        {
            get
            {
                string path = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.ApplicationData),
                    "DevDashboard");

                Directory.CreateDirectory(path);

                return new DtoPathServices(path);
            }
        }

        public static DtoPathServices Sounds
        {
            get
            {
                string path = Path.Combine(Root.Path, "Sounds");

                Directory.CreateDirectory(path);

                return new DtoPathServices(path);
            }
        }

        public static DtoPathServices Settings
        {
            get
            {
                string path = Path.Combine(Root.Path, "Settings");
                Directory.CreateDirectory(path);
                return new DtoPathServices(path);
            }
        }
    }
}
