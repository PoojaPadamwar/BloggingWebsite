using AutoMapper;
using BlogWebApplication.ServiceInterface;
using Microsoft.Extensions.DependencyInjection;

namespace BlogWebApplication.Service
{
	public static class ServiceConfiguration
	{
		public static IServiceCollection AddDependentServices(this IServiceCollection services)
		{
			services.AddAutoMapper(typeof(Startup));
			services.AddScoped<IUserService, UserService>();

			services.AddScoped(typeof(IBlogService), typeof(BlogService));
			services.AddScoped(typeof(ICommentService), typeof(CommentService));

			return services;
		}
	}
}
