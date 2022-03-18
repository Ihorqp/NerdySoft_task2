using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NerdySoft_task2.Service;
using Microsoft.Extensions.Configuration;
using NerdySoft_task2.Domain.Repositories.Abstract;
using NerdySoft_task2.Domain.Repositories.EntityFramework;
using NerdySoft_task2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using NerdySoft_task2.Controllers;

namespace NerdySoft_task2
{

        public class Startup
        {
            public IConfiguration Configuration { get; }
            public Startup(IConfiguration configuration) => Configuration = configuration;

            public void ConfigureServices(IServiceCollection services)
            {
                Configuration.Bind("Project", new Config());

                services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
                services.AddTransient<DataManager>();
                services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

              

            services.AddControllersWithViews();
            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
         
                if (env.IsDevelopment())
                    app.UseDeveloperExceptionPage();

                app.UseStaticFiles();

                app.UseRouting();


                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                });
            }
        }

    
}
