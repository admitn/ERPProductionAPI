using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

using ERPProductionAPI.Models;

namespace ERPProductionAPI.ERPProduction
{
    public class request_database
    {
        private async Task<AppSettings> LoadSettingSql()
        {
            try
            {
                string appDirectory = AppContext.BaseDirectory;
                string configPath = Path.Combine("Database", "SqlServer", "appsettings.json");

                var configuration = new ConfigurationBuilder().SetBasePath(appDirectory)
                    .AddJsonFile(configPath).Build();

                AppSettings settings = new AppSettings();
                configuration.Bind(settings);
                return settings;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading config: {ex.Message}");
                return new AppSettings();
            }
        }
        public async Task<string> GetRequestSql()
        {
            var res = await LoadSettingSql();
            return res.Host;
        }
    }
}
