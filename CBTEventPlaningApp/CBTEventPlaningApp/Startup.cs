using CBTEventPlaningApp.Services.Interface;
using CBTEventPlaningApp.Services.Interfaces;
using CBTEventPlaningApp.Services.Models;
using CBTEventPlaningApp.Services.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTEventPlaningApp
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		public Startup(IConfiguration configuration) => Configuration = configuration;
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(options => { options.UseSqlServer(Configuration["Data:CBTDataEvents:ConnectionString"]); });

			//services.AddIdentity<IdentityUser, IdentityRole>()
			//  .AddEntityFrameworkStores<AppIdentityDbContext>()
			//  .AddDefaultTokenProviders();

			//services.AddTransient<ICBTEvent, RepositoryCBTEvents>();
			services.AddTransient<IEFRepository, EFRepository>();

			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.UseStatusCodePages();
			app.UseDefaultFiles();
			app.UseStaticFiles();
			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
