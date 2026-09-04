using System;
using System.Collections.Generic;
using System.Text;

namespace DevDashboard.Services
{
    public static class UserDataService
    {
        public static string Root
        {
            get
            {
                string path = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.ApplicationData),
                    "DevDashboard");

                Directory.CreateDirectory(path);

                return path;
            }
        }

        public static string Sounds
        {
            get
            {
                string path = Path.Combine(Root, "Sounds");

                Directory.CreateDirectory(path);

                return path;
            }
        }
    }
}
