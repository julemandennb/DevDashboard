using Settings.Dto;
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

        public static bool SaveSoundsFilePath(string sourceFile, string name)
        {
            return FileServices.AddFile(
                sourceFile,
                PathServices.Sounds,
                name);
        }
    }
}
