using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Services
{
    public class FilePathServices
    {
        public static string GetSoundsFilePath(string name)
        {
            return FileServices.GetFilePath(
                PathServices.Sounds,
                name);
        }
    }
}
