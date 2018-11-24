using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiiProyect.Settings
{
    class Settings
    {
        private static ISettings AppSettings =>
            CrossSettings.Current;

        public static string nocont
        {
            get => AppSettings.GetValueOrDefault(nameof(nocont), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(nocont), value);
        }
        public static String token
        {
            get => AppSettings.GetValueOrDefault(nameof(token), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(token), value);
        }
        public static String password
        {
            get => AppSettings.GetValueOrDefault(nameof(password), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(password), value);
        }
    }
}
