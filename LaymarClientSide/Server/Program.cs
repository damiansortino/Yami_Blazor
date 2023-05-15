using LaymarClientSide.Server.Context;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LaymarClientSide.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webhost = BuildWebHost(args);
            using (var scope = webhost.Services.CreateScope())
            {

                var services = scope.ServiceProvider;
                var context = services.GetService<ApplicationDbContext>();
                context.Database.Migrate();
            }

            webhost.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(new ConfigurationBuilder()
                    .AddCommandLine(args)
                    .Build())
                .UseStartup<Startup>()
                .Build();
    }
}
