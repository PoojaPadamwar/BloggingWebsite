using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlogWebApplication.Mapper;
using BlogWebApplication.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BlogWebApplication
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var services = new ServiceCollection();
			services.AddDependentServices();

			CreateHostBuilder(args).Build().Run();
			var mappingConfig = new MapperConfiguration(mc =>
			{
				mc.AddProfile(new MapperProfile());
			});
			IMapper mapper = mappingConfig.CreateMapper();
			services.AddSingleton(mapper);
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
				Host.CreateDefaultBuilder(args)
						.ConfigureWebHostDefaults(webBuilder =>
						{
							webBuilder.UseStartup<Startup>();
						});
	}
}
