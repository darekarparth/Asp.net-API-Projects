using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StateInfo.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLogBuilder
                 .ConfigureNLog("nlog.config")
                 .GetCurrentClassLogger();
            try
            {

                logger.Info("Initializing application...");
                CreateWebHostBuilder(args).Build().Run();
                //var host = CreateWebHostBuilder(args).Build();//.Run();//Build build the web host, and run start running it.

                //using (var scope = host.Services.CreateScope())
                //{
                //    try
                //    {
                //        var context = scope.ServiceProvider.GetService<CityInfoContext>();

                //        // for demo purposes, delete the database & migrate on startup so 
                //        // we can start with a clean slate
                //        context.Database.EnsureDeleted();
                //        context.Database.Migrate();
                //    }
                //    catch (Exception ex)
                //    {
                //        logger.Error(ex, "An error occurred while migrating the database.");
                //    }
                //}

                //// run the web app
                //host.Run();

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Application stopped because of exception.");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseNLog();
    }
}
