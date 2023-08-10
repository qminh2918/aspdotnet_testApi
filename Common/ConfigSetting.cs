using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Reflection;
using TestApi.Common.Config;

namespace TestApi.Common
{
    public class ConfigSetting
    {
        private ConfigSetting()
        {
        }

        public IConfigurationRoot Configuration { get; private set; }
        public AppSettingModel AppSetting { get; private set; }

        public static ConfigSetting Config(params string[] pathJson)
        {
            var environmentName = ApplicationMode.EnvironmentName;
            var exeFolder = Path.GetDirectoryName(Assembly.GetEntryAssembly().CodeBase);
            exeFolder = exeFolder.Replace(@"file:\", "");
            exeFolder = exeFolder.Replace(@"file:", "");
            //https://stackoverflow.com/a/56547116/2563051 - kiendt change reload file to false for container .net core linux
            var builder = new ConfigurationBuilder()
                    .SetBasePath(exeFolder)
                    .AddJsonFile($"Config/appConfig.json", true, false)
                    .AddJsonFile($"Config/appConfig{environmentName}.json", true, false)
                    .AddJsonFile($"Config/portConfig.json", true, false)
                    .AddJsonFile($"appsettings.json", true, false)
                ;
            foreach (var item in pathJson)
            {
                builder.AddJsonFile(item);
            }
            var config = builder.Build();

            var result = new ConfigSetting();
            result.Configuration = config;
            result.AppSetting = new AppSettingModel();
            config.Bind(result.AppSetting);

            return result;
        }
    }
}
