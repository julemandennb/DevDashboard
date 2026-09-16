using Settings;
using Settings.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevDashboard.Help
{
   internal static class SettingLibHelp
   {
        private static List<Setting> _settings = new List<Setting>();

        internal static SettingsFile<T> GetSettingsFile<T>()
        where T : Setting, new()
        {
            return new SettingsFile<T>();
        }

        internal static T AddToList<T>(T setting) where T : Setting
        {
            Setting? existing = _settings.Find(x => x.GetType() == typeof(T));

            if (existing != null)
            {
                return (T)existing;
            }

            _settings.Add(setting);
            return setting;
        }

        internal static T? GetSetting<T>() where T : Setting
        {
            return _settings.OfType<T>().FirstOrDefault();
        }

        internal static void SaveSetting<T>(T setting)
            where T : Setting, new()
        {
            GetSettingsFile<T>().Save(setting);
        }

    }
}
