// <copyright file="Startup.cs" company="Aptiture">
// Copyright (c) Aptiture. All rights reserved.
// </copyright>

namespace FuturityCalculator.API
{
    using FuturityCalculator.WebAPI;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using Microsoft.OpenApi.Models;

    /// <summary>
    /// ASP.NET Core Startup class.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">An IConfiguration object.</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the Configuration object.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configures the registration of application services to the container.
        /// </summary>
        /// <param name="services">A service collection.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMemoryCache();

            services.AddCors(options =>
            {
                options.AddPolicy(CorsPolicy.WebUI, builder =>
                {
                    var allowedOrigins = this.Configuration["AllowedCorsOrigins"]?.Split(",");
                    if (allowedOrigins != null)
                    {
                        builder.WithOrigins(allowedOrigins);
                        builder.AllowAnyHeader();
                        builder.AllowAnyMethod();
                    }
                });
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FuturityCalculator.WebAPI", Version = "v1" });
            });
        }

        /// <summary>
        /// Configures the HTTP request pipeline.
        /// </summary>
        /// <param name="app">The application builder object.</param>
        /// <param name="env">The webhost environment object.</param>
        /// <param name="loggerFactory">The logger factory object.</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs/log-{Date}.txt");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FuturityCalculator.API v1"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(CorsPolicy.WebUI);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
