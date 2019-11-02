using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCoreFlixWEBUI.Business.Abstract;
using NetCoreFlixWEBUI.Business.Concrete;
using NetCoreFlixWEBUI.DataAccess.Abstract;
using NetCoreFlixWEBUI.DataAccess.Concrete;
using NetCoreFlixWEBUI.Middlewares;
using NetCoreFlixWEBUI.Services;
using NetCoreFlixWEBUI.UserEntities;

namespace NetCoreFlixWEBUI
{
    public class Startup
    {

        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMovieDal, MovieDal>();
            services.AddScoped<ICategoryDal, CategoryDal>();
            services.AddScoped<IMovieService, MovieManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddSingleton<IFavListSessionService, FavListSessionService>();
            services.AddSingleton<IFavMovieService, FavMovieService>();
            services.AddDbContext<CustomIdentityDbContext>
                (options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=NetFCoreIdentity;Trusted_Connection=true"));
            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options => options.LoginPath = "/Admin/LogIn");

            services.AddMvc();
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDistributedMemoryCache();
            

            //services.AddDbContext<NetCoreFlixContext>(options =>
            //{
            //    options.UseSqlServer(_configuration.GetConnectionString("DataConnection"));
            //    options.EnableSensitiveDataLogging(true);
            //});
            
        }

        //Mideware yapılandırması
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            //app.UseIdentity();
            app.UseAuthentication();
            app.UseSession();
            app.UseMvc(ConfigureRoutes);
          



        }
        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            //Home/Index
            routeBuilder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }


    }

}
