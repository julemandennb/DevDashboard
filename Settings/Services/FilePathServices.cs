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

            string fileType = Path.GetExtension(sourceFile).ToLower();

            if (fileType == ".wav")
                return FileServices.AddFile(
                sourceFile,
                PathServices.Sounds,
                name);
            else if (fileType == ".mp3")
                return ConvertFile.ConvertMp3ToWavSoundsFile(sourceFile, name);
            else
                return false;
        }

        public static bool DeleteSoundsFile(string name)
        {
           return FileServices.DeleteFile(PathServices.Sounds, name);
        }
    }
}
