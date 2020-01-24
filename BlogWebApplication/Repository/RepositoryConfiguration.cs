using BlogWebApplication.RepositoryInterface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.Repository
{
	public static class RepositoryConfiguration
	{		
		public static IServiceCollection AddDependenRepository(this IServiceCollection services, string connectionString)
		{
			services.AddScoped<BlogContext>(s => new BlogContext(connectionString));

			services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
			services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));
			services.AddScoped(typeof(IUserRepository), typeof(UserRepository));

			return services;
		}
	}
}
