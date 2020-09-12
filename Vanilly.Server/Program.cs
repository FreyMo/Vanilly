using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Vanilly.Server
{
    public class Program
    {
        // sudo service ssh start
        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
