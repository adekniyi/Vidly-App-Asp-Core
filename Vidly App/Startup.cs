using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Vidly_App.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using AutoMapper;
using Vidly_App.Areas;
using Newtonsoft.Json.Serialization;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Authentication;


namespace Vidly_App
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                //options.Password.RequiredLength = 10;
                //options.Password.RequiredUniqueChars = 3;
            }).AddEntityFrameworkStores<ApplicationDbContext>();
              //.AddRoles<IdentityRole>() //Line that can help you\


            services.AddControllersWithViews();
            services.AddRazorPages();

            AutoMapper.Mapper.Initialize(c => c.AddProfile<MappingProfile>());

            services.AddMvc(option => {
                option.EnableEndpointRouting = false;
                var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .Build();
                option.Filters.Add(new AuthorizeFilter(policy));
                //option.Filters.Add(typeof(RequireHttpsInProductionAttribute));
            }).AddXmlSerializerFormatters();

            services.AddAuthentication()
                .AddGoogle(options =>
            {
                options.ClientId = "659448695725-0liodb7sebk3d7mn6uhvbvqulcv2o4np.apps.googleusercontent.com";
                options.ClientSecret = "2g2N3to_cT4cSUIXrLEcYWa2";
            });

            services.AddAuthentication()
               .AddFacebook(options =>
               {
                   options.AppId = "431650278191112";
                   options.AppSecret = "5a10e79ad11db463f4e39e7a454e7651";
               });

            //.AddMvcOptions(options => options.Filters.Add(new AuthorizeFilter()));

            var config = new HttpConfiguration();
            var settings = config.Formatters.JsonFormatter.SerializerSettings;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();

            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //    endpoints.MapRazorPages();
            //});

            app.UseMvc(routes =>
            {
                //routes.MapRoute("Home", "{controller=HomeController}");
                routes.MapRoute("Customer", "{controller=CustomerController}");
                routes.MapRoute("Movie", "{controller=MovieController}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
