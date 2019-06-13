using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement1
{
	public class Startup
	{
		private IConfiguration _config;


		public Startup(IConfiguration config)
		{
			_config = config;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc().AddXmlDataContractSerializerFormatters();
			services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		//ILogger<Startup> logger
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			//else if (env.IsStaging() || env.IsProduction() || env.IsEnvironment("UAT")) {
			//	app.UseExceptionHandler("/Error");
			//}

			//// layer to add new default filename instead default.
			//DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
			//defaultFilesOptions.DefaultFileNames.Clear();
			//defaultFilesOptions.DefaultFileNames.Add("foo.html");

			//app.UseDefaultFiles(defaultFilesOptions);
			//// can see content into wwwroot folder
			//app.UseStaticFiles();

			// layer to add new default filename using FileServerOptions class.
			//FileServerOptions fileServerOptions = new FileServerOptions();
			//fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
			//fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
			//app.UseFileServer(fileServerOptions);

			//should use document with name default from the wwwroot folder.	
			//app.UseDefaultFiles();



			//app.Use(async (context, next) =>
			//{
			//	logger.LogInformation("MW1: Incoming Request");
			//	await next();
			//	logger.LogInformation("MW1: Outgoing Response");
			//});

			//app.Use(async (context, next) =>
			//{
			//	logger.LogInformation("MW2: Incoming Request");
			//	await next();
			//	logger.LogInformation("MW2: Outgoing Response");
			//});
			//app.UseFileServer();
			app.UseStaticFiles();
			app.UseMvcWithDefaultRoute();

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!");
			});
			

		}
	}
}
