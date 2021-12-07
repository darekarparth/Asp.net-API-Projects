using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StateInfo.API.Contexts;
using StateInfo.API.Services;
//using StateInfo.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateInfo.API
{
    public class Startup
    {
      
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMvc().AddMvcOptions(o => //The .AddMvcOptions method allows us to configure the supported formatters for our API like XML or JSON, Default it is JSON
            {
                o.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                //InputFormatters signifies the list of Input formatters
                //OutputFormatters signifies the list of output formatters
            });

            //#if DEBUG
            //            services.AddTransient<IMailServices, LocalMailServices>();// from this moment the instance of this object can be created 
            //#else
            //            services.AddTransient<IMailService, CloudMailService>();
            //#endif



            //var connectionString = _configuration["connectionStrings:StateInfoDBConnectionString"];
            //var connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=StateInfoDB; Integrated Security=True;";

            //services.AddDbContext<CityInfoContext>(options =>
            //{
            // options.UseSqlServer(connectionString);
            //});

            services.AddDbContext<CityInfoContext>(Options =>
            {
                Options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<ICityInfoRepository, CityInfoRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            // AutoMapper services are registered on on the container.
            //This method allows us to input the set of assemblies. its these assembelies that automatically get scanned for "Profiles" that contained mapping configuration.  
            //"Profile" is neat way to nicely organize our mapping configurations. 
            //AppDomain.CurrentDomain.GetAssemblies() get all the assemblies related to the current app domain. In other word CityInfo.API assembly will also be included and searched for profile
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStatusCodePages();
            app.UseMvc();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}
