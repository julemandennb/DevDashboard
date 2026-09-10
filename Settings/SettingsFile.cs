using Settings.Dto;
using Settings.Models;
using Settings.Services;
using System.Text.Json;

namespace Settings
{
    public class SettingsFile<T> where T : Setting, new()
    {
        private readonly T _settings;

        public string FileName => _settings.fileName;

        private DtoPathServices _settingsFilePath;

        public SettingsFile()
        {
            _settings = new T();
            _settingsFilePath = PathServices.Settings;

        }

        public T Load()
        {
            if(FileServices.CheckFile(_settingsFilePath, FileName))
            {
                string filePath = FileServices.GetFilePath(_settingsFilePath, FileName);
                string json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(json) ?? new T();
            }
            else
            {
                return new T();
            }

        }

        public T Save(T settings)
        {
            string json = JsonSerializer.Serialize(settings);
            FileServices.AddFileFromString(json, _settingsFilePath, FileName);
            return settings;
        }
    }
}
