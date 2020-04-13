using System.IO;
using Microsoft.Extensions.Configuration;

namespace Trello.Helpers.Configuration
{
    public static class ConfigurationProvider
    {
        public static IConfiguration TestsConfiguration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();
    }
}
