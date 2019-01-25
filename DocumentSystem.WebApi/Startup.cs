using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DocumentSystem.WebApi.Infrastructure.Context;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using DocumentSystem.WebApi.IoC;

namespace DocumentSystem.WebApi
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
            var connection = @"data source=DESKTOP-CEO4LR9;initial catalog=DocumentSystem;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            services.AddDbContext<DocumentDbContext>(
              options => options.UseSqlServer(connection, x => x.MigrationsAssembly("DocumentSystem.WebApi")
             ));

            services.AddDbContext();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", p =>
                {
                    p.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseExceptionHandler(
              builder =>
              {
                  builder.Run(
                            async context =>
                            {
                                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                                context.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                                var error = context.Features.Get<IExceptionHandlerFeature>();
                                //if (error != null)
                                //{
                                //    context.Response.AddApplicationError(error.Error.Message);
                                //    await context.Response.WriteAsync(error.Error.Message).ConfigureAwait(false);
                                //}
                            });
              });

            app.UseAuthentication();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCors("AllowAll");
            app.UseMvc();
        }
    }
}
