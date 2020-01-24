using BlogWebApplication.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.RepositoryInterface
{
	public interface IBlogRepository
	{
		Task<IEnumerable<BlogDBEntity>> GetAllBlogs();		

		Task<long> SaveBlog(BlogDBEntity post);

		Task<long> UpdateBlog(BlogDBEntity post);

	}
}
