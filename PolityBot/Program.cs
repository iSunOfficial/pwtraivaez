using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace PolityBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger.ManagerLogger("bot enabled");
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
