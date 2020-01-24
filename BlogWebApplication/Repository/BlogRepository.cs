using BlogWebApplication.DBEntities;
using BlogWebApplication.RepositoryInterface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogWebApplication.Repository
{
	public class BlogRepository : IBlogRepository
	{
		private readonly BlogContext _context;

		private DbSet<BlogDBEntity> _entities;

		public BlogRepository(BlogContext context)
		{
			_context = context;
		}

		private DbSet<BlogDBEntity> Entities
		{
			get
			{
				if (_entities == null)
				{
					_entities = _context.Set<BlogDBEntity>();
				}
				return _entities;
			}
		}
		public async Task<IEnumerable<BlogDBEntity>> GetAllBlogs()
		{
			return await this.Entities.ToListAsync();
		}

		public async Task<long> SaveBlog(BlogDBEntity post)
		{
			await this.Entities.AddAsync(post);
			return await _context.SaveChangesAsync();
		}

		public async Task<long> UpdateBlog(BlogDBEntity post)
		{
			_context.Entry(post).State = EntityState.Modified;

			var result = await _context.SaveChangesAsync();

			return await Task.FromResult(result);
		}
	}
}
