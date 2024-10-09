using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using WebApi.Helpers;
using WebApi.Interfaces;
using WebApi.Persistences;
using WebApi.Repository;

namespace WebApi
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
            services.AddControllers();
            services.AddDbContext<DbApiContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SQLServerConnection")));
          
            services.AddHttpContextAccessor();
            services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            #region // service repository  //-----
            services.AddScoped<IUtilisateur, UtilisateurService>();
                services.AddScoped<IUnitOfWork, UnitOfWork>();              
                services.AddScoped<IEmploye, EmployeService>();  
                services.AddScoped<IBody_card, Body_cardService>();
            #endregion

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

            services.AddControllers().AddNewtonsoftJson(options =>
            {                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });

            services.AddCors(options => {
                options.AddDefaultPolicy(
                       builder => {
                           builder.WithOrigins("http://localhost:5200/","https://localhost:5200/")
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowAnyHeader()
                          .SetIsOriginAllowed(origin => true)
                          .AllowCredentials();

                       });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseDefaultFiles(); 
            app.UseStaticFiles();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
