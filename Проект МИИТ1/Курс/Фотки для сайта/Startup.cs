using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WebCourse.Data.Interfaces;
using WebCourse.Data.mocks;

namespace WebCourse
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllAbillities, mockAbillities>();
            services.AddTransient<IInformationCategory, mockCategory>();
            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();


		    if (env.IsDevelopment())
				{
					app.UseDeveloperExceptionPage();
				}
			if (env.IsProduction())
			{
				app.Run(async (context) =>
				{
					await context.Response.WriteAsync("Production! ACY CC");

				});
			}

		}
    }
}
