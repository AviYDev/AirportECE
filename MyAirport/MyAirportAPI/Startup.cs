using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using IA.MyAirport.EF;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.IO;

namespace MyAirportAPI
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
            services.AddDbContext<MyAirportContext>(option => option.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyAirport;Trusted_Connection=True;"));
            services.AddControllers();
            /*    object p = services.AddControllers().AddNewtonsoftJson(o =>
                {
                    o.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });*/

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                   Version = "v1",
                   Title = "MyAirportApi",
                   Description ="Gestionnaire d'aeroport super top",
                   TermsOfService = new Uri("https://example.com/terms"),
                   Contact = new OpenApiContact
                   {
                       Name = "Avinash Yoganandan",
                       Email = string.Empty,
                       Url = new Uri("https://twitter.com/AvinashYogan"),
                   },
                   License = new OpenApiLicense
                   {
                       Name = "Use under LICX",
                       Url = new Uri("http://example.com/license"),
                   }
                });


                // Set the comments path for the Swagger JSON and UI.
             /*   var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
                var referencedAssemblies = Assembly.GetAssembly(typeof(Startup)).GetReferencedAssemblies();
                referencedAssemblies.ToList().ForEach(assembly =>
                {
                    var path = Path.Combine(AppContext.BaseDirectory, $"{assembly.Name}");
                    if (File.Exists(path))
                    {
                        c.IncludeXmlComments(path);
                    }
                });*/
            });
         

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyAirportApi V1");
            });
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
            });
        }
    }
}
