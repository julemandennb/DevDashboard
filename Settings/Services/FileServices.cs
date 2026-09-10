using Settings.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Settings.Services
{
    internal static class FileServices
    {
        public static bool CheckFile(DtoPathServices path, string name)
        {
            string filePath = Path.Combine(path.Path, name);
            return File.Exists(filePath);
        }

        public static bool AddFile(string sourceFile, DtoPathServices path, string name)
        {
            try
            {
                string destination = Path.Combine(
                        path.Path,
                    name);

                File.Copy(sourceFile, destination, true);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool AddFileFromString(string content, DtoPathServices path, string name)
        {
            try
            {
                string filePath = Path.Combine(path.Path, name);
                File.WriteAllText(filePath, content, Encoding.UTF8);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteFile(DtoPathServices path, string name)
        {
            try
            {
                string filePath = Path.Combine(path.Path, name);
                File.Delete(filePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool RenameFile(DtoPathServices path, string oldName, string newName)
        {
            try
            {
                string oldFilePath = Path.Combine(path.Path, oldName);
                string newFilePath = Path.Combine(path.Path, newName);
                File.Move(oldFilePath, newFilePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<string> GetFiles(DtoPathServices path)
        {
            try
            {
                return Directory.GetFiles(path.Path).Select(Path.GetFileName).ToList();
            }
            catch
            {
                return new List<string>();
            }
        }

        public static string GetFilePath(DtoPathServices path, string name)
        {
            return Path.Combine(path.Path, name);
        }

    }
}
