using BSU_Teachers.DataAccessLayer.Contexts;
using BSU_Teachers.DataAccessLayer.Repositories.Implementations;
using BSU_Teachers.DataAccessLayer.Repositories.Interfaces;
using BSU_Teachers.Servises;
using BSU_Teachers.Servises.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BSU_Teachers
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<CommonContext>(optionsBuilder => optionsBuilder
            .UseSqlServer(_configuration.GetConnectionString("Default")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            

            services.AddScoped<IFacultyRepository, FacultyRepository>();

            services.AddScoped<IFacultyService, FacultyService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //else
            //{
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseMvc();
        }
    }
}
