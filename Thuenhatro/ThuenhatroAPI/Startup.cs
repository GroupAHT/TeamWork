using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ThuenhatroAPI.Models;
using ThuenhatroAPI.Services;
using Microsoft.EntityFrameworkCore;
using ThuenhatroAPI.Service;

namespace ThuenhatroAPI
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
            string str = "server=.;database=ThuenhatroDB ;uid=sa;pwd=123";
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IWard, Warssds>();
            services.AddScoped<IProvider, Providerssd>();
            services.AddScoped<IIProperty, Properyty>();
            services.AddScoped<IDistrick, Districk>();
            services.AddScoped<IPic, Picturess>();
            services.AddDbContext<Context>(options => options.UseSqlServer(str));
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
