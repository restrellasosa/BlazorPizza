using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingPizza.Server.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BlazingPizza.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var Host = BuildWebHost(args);
            var ScopeFactory =
    Host.Services.GetRequiredService<IServiceScopeFactory>();
            using (var Scope = ScopeFactory.CreateScope())
            {
                var Context = Scope.ServiceProvider
                    .GetRequiredService<PizzaStoreContext>();
                if (Context.Specials.Count() == 0)
                {
                    SeedData.Initialize(Context);
                }
            }
            Host.Run();
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
