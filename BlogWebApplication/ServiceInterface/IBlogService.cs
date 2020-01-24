using BlogWebApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.ServiceInterface
{
	public interface IBlogService
	{
		Task<IEnumerable<Blog>> GetAllBlogs();

		Task<long> SaveBlog(Blog post);

		Task<long> UpdateBlog(Blog post);
	}
}
