using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HotFolderPrinterFoxitPdf
{
    class HFP
    {
        public static void SetConfig(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        public static string GetConfig(string key)
        {
            #pragma warning disable CS8603 // Possible null reference return.
            return ConfigurationManager.AppSettings[key];
            #pragma warning restore CS8603 // Possible null reference return.
        }

        public static void LogWriteLine(string logMessage)
        {
            File.AppendAllText(HFP.GetConfig("logFile"), String.Concat(DateTime.Now.ToString("O"), ";", logMessage, Environment.NewLine));
        }
    }
}
