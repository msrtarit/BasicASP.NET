using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.Run(async contex =>
            {
                await contex.Response.WriteAsync("<center><h1>NAME:MD SHAHRIAR RAHMAN<br>ID=1802009</h1></center>");
            });

            // app.UseEndpoints(endpoints =>
            // {
                // endpoints.MapGet("/", async context =>
                // {
                    // await context.Response.WriteAsync("Hello World!");
                // });
            // });
        }
    }
}
