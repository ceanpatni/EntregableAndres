using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EntregableAndres.Data;
using EntregableAndres.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace EntregableAndres
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
            services.AddDbContext<EcommerceDbContext>(options =>
                options.UseMySql(Configuration.GetConnectionString("EcommerceDatabase")));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddControllersWithViews();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Ecommerce Platform",
                    Version = "v1",
                    Description = "API para gestionar productos y órdenes en la plataforma Ecommerce",
                    Contact = new OpenApiContact
                    {
                        Name = "Soporte de Ecommerce",
                        Email = "cesarpatinon@hotmail.com"
                    }
                });

                // Puedes usar la ruta XML para mejorar la documentación de los métodos con comentarios
                var xmlFile = Path.Combine(AppContext.BaseDirectory, "EntregableAndres.xml");
                c.IncludeXmlComments(xmlFile);
            });

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ecommerce Platform v1");
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(); // Agregar soporte para archivos estáticos

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}",
                       defaults: new { controller = "Product" });
                endpoints.MapControllerRoute(
                  name: "OrderItems",
                  pattern: "orders/{orderId}/items/{action=Index}/{id?}",
                  defaults: new { controller = "OrderItem" });
                endpoints.MapControllerRoute(
           name: "Order",
            pattern: "{controller=Order}/{action=Index}/{id?}",
             defaults: new { controller = "Order" });

              
            });


        }
    }
}
