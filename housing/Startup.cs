using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using housing.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace housing
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
            //services.AddDbContext<dataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddDbContextPool<dataContext>(options =>
            {
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                string connStr;

                // Depending on if in development or production, use either Heroku-provided
                // connection string, or development connection string from env var.
                if (env == "Development")
                {
                    connStr = Configuration.GetConnectionString("DefaultConnection");
                    options.UseSqlServer(connStr);

                }
                else
                {
                    // Use connection string provided at runtime by Heroku.
                    var connUrl = Environment.GetEnvironmentVariable("DATABASE_URL");

                    // Parse connection URL to connection string for Npgsql
                    connUrl = connUrl.Replace("postgres://", string.Empty);//fexbzfszhmuqrr: 3dc3d8829e35498a511b8e0fb7fa953243004c96bc5481acdbf5218350063826@ec2-54-228-170-125.eu-west-1.compute.amazonaws.com:5432/d3c3ldsf29mr0c
                    var pgUserPass = connUrl.Split("@")[0]; //fexbzfszhmuqrr: 3dc3d8829e35498a511b8e0fb7fa953243004c96bc5481acdbf5218350063826
                      var pgHostPortDb = connUrl.Split("@")[1];//ec2-54-228-170-125.eu-west-1.compute.amazonaws.com:5432/d3c3ldsf29mr0c
                    var pgHostPort = pgHostPortDb.Split("/")[0];//ec2-54-228-170-125.eu-west-1.compute.amazonaws.com:5432
                    var pgDb = pgHostPortDb.Split("/")[1];//d3c3ldsf29mr0c
                    var pgUser = pgUserPass.Split(":")[0];//fexbzfszhmuqrr
                    var pgPass = pgUserPass.Split(":")[1];// 3dc3d8829e35498a511b8e0fb7fa953243004c96bc5481acdbf5218350063826
                    var pgHost = pgHostPort.Split(":")[0];//ec2-54-228-170-125.eu-west-1.compute.amazonaws.com
                    var pgPort = pgHostPort.Split(":")[1];//5432

                    connStr = $"Server={pgHost};Port={pgPort};User Id={pgUser};Password={pgPass};Database={pgDb}";
                    options.UseNpgsql(connStr);
                }

                // Whether the connection string came from the local development configuration file
                // or from the environment variable from Heroku, use it to set up your DbContext.
                //options.UseNpgsql(connStr);
                //options.UseSqlServer(connStr);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
        }
    }
}
