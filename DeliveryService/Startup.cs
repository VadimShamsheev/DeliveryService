using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using DeliveryService.Models.Interfaces;

namespace DeliveryService
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(o => o.UseNpgsql(
                "Host=localhost;Port=5432;Database=DelivaryService;Username=postgres;Password=root"));
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddTransient<ICategoriesRepository, EFCategoryRepository>();
            services.AddTransient<ICartRepository, EFCartRepository>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => options.LoginPath = new PathString("/Account/Login"));
            services.AddMvc(o => o.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseMvc(route =>
            {
                /*route.MapRoute(
                    name: "ProductDetails",
                    template: "{controller=Home}/{action}/");*/
                route.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
