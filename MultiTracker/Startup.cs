﻿using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Extensions.Repository.Extensions;
using MultiTracker.Data.DataInterfaces;
using MultiTracker.Data.DataRepositories;
using MultiTracker.Services.Interfaces;
using MultiTracker.Services.Services;

namespace MultiTracker
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
            var assembly = typeof(Startup).Assembly;
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddMongoRepositories(Configuration.GetConnectionString("mongo")).FromAssembly(assembly);
            
            services.AddAutoMapper(c => c.AddProfiles(assembly));
            
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ICalendarRepository, CalendarRepository>();
            services.AddTransient<ICalendarService, CalendarService>();
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            
            app.UseMvc();
        }
    }
}