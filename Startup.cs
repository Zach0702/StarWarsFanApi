using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Identity.Dapper;
using Identity.Dapper.Entities;
using Identity.Dapper.Models;
using Identity.Dapper.SqlServer.Connections;
using Identity.Dapper.SqlServer.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StarWarsFan.DAL;
using StarWarsFan.Services;

namespace StarWarsFan
{
    public class Startup
    {
        //public Startup(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);


            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDapperConnectionProvider<SqlServerConnectionProvider>(
                Configuration.GetSection("ConnectionStrings"))
                .ConfigureDapperIdentityCryptography(Configuration.GetSection("DapperIdentityCryptography"))
                .ConfigureDapperIdentityOptions(new DapperIdentityOptions { UseTransactionalBehavior = false }); //Change to True to use Transactions in all operations

            services.AddIdentity<DapperIdentityUser, DapperIdentityRole>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 1;
                x.Password.RequireLowercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireUppercase = false;
            })
                   //.AddDapperIdentityFor<PostgreSqlConfiguration>()
                   .AddDapperIdentityFor<SqlServerConfiguration>()
                   //.AddDapperIdentityFor<MySqlConfiguration>()
                   .AddDefaultTokenProviders();

            //services.AddMvc();

            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", false, true)
               .Build();

            var appConfig = new StarWarsConfig();
            config.Bind("StarWarsConfig", appConfig);
            services.AddSingleton(appConfig);
            services.AddSingleton<IFanStore, FanStore>();
            services.AddSingleton<IFanService, FanService>();
            services.AddSingleton<IPlanetService, PlanetService>();
            services.AddSingleton<IMapPlanet, MapPlanet>();
            services.AddTransient<IEmailSender, AuthMessageSender>();
            services.AddTransient<ISmsSender, AuthMessageSender>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
