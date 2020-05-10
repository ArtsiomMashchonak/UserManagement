using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UserManagement.WebApi.Interfaces;
using UserManagement.WebApi.Repositories;

namespace UserManagement.WebApi
{
    public class Startup
    {
        private readonly string _allowLocalhostPolicyName = "AllowLocalhost";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(corsOpts =>
                corsOpts.AddPolicy(_allowLocalhostPolicyName, 
                    policyBuilder => policyBuilder.WithOrigins("http://127.0.0.1:5500")));

            services.AddControllers();
            services.AddScoped<IUsersRepository, UsersRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(_allowLocalhostPolicyName);
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
