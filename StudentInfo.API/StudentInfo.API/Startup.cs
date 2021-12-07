
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentInfo.API.Contexts;
using StudentInfo.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo.API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;//field

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
               .AddMvcOptions(o => //The .AddMvcOptions method allows us to configure the supported formatters for our API like XML or JSON, Default it is JSON
                 {
                     o.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
                     //InputFormatters signifies the list of Input formatters
                     //OutputFormatters signifies the list of output formatters
                 });

            //var connectionString = @"Server=(localdb)\mssqllocaldb;Database=StudentInfoDB; Integrated Security=True ;";  //Trusted_Connections=True is not used, instead Integrated Security=True is used.
            var connectionString = _configuration["connectionStrings:studentInfoDBConnectionString"];
            services.AddDbContext<StudentInfoContext>(o =>
            {

                o.UseSqlServer(connectionString);
            });

            services.AddScoped<IStudentInfoRepository, StudentInfoRepository>();//scoped Lifetime services are created once for each request.
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());// AutoMapper services are registered on on the container.
            //This method allows us to input the set of assemblies. its these assembelies that automatically get scanned for "Profiles" that contained mapping configuration.  
            //"Profile" is neat way to nicely organize our mapping configurations. 
            //AppDomain.CurrentDomain.GetAssemblies() get all the assemblies related to the current app domain. In other word CityInfo.API assembly will also be included and searched for profile.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)//This method is called after ConfigureServices method, becauses it uses services that are registered and configured in the ConfigureServices Method.
        {                                                                      //the configure methode is used to specify that how ASP.NET core app will respond to individual requests. 
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();//this statement configures a http request pipeline by adding the DeveloperExceptionPage middleware to it.
                                                    // so when exception is thrown, this piece of middleware will handle it.   
                }
                app.UseStatusCodePages(); //MiddleWare. If we add this to request Pipeline, a simple text based handle for common status codes is added.   
                app.UseMvc();//MVC middleware will handle http requests
                app.UseHttpsRedirection();
                app.UseStaticFiles();
            }
        }
    }
}
