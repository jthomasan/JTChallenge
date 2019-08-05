using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using PersonalLoan.Data.Models;
using PersonalLoan.Interfaces;
using PersonalLoan.Repositories;

namespace PersonalLoan
{
    public class Startup
    {
        public readonly IConfigRepository _config;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            //retrieves the connection details and any other details mentioned inside ConfigRepository from configuration object.
            _config = Configuration.Get<ConfigRepository>();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

            var dbContext = services.AddDbContext<PersonalLoanContext>
                (options => options.UseSqlServer(_config.ConnectionString));
            services.TryAddScoped<IPersonalLoanDetailsRepository, PersonalLoadDetailsRepository>();
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
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            //the below block of code resolves the PersonalLoanContext and do a migration with the database.
            //Initial seeding of data is also setup in the migration. Hence setting an appropriate connection string is
            //enough for setting up and running this project.
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<PersonalLoanContext>())
                {
                    context.Database.Migrate();
                }
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
