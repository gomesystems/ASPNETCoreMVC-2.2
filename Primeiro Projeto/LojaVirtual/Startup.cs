using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Database;
using LojaVirtual.Reposytories;
using LojaVirtual.Reposytories.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LojaVirtual
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
            // Importando a interface para usar injeção de dependencia (PADRÃO REPOSITORY)
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<INewsLetterRepository, NewsLetterRepository>();


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //session - configuração
            services.AddMemoryCache();
            services.AddSession(options => { 
           
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            // string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaVirtual;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            // services.AddDbContext<LojaVirtualContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<LojaVirtualContext>(options => options.UseSqlServer(Configuration.GetConnectionString("connection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            /* 
              nesta ordem correta abaixo
            */

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();            
            app.UseCookiePolicy();
            app.UseSession();
                       

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
