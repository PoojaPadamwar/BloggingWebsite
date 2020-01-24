using AutoMapper;
using BlogWebApplication.DBEntities;
using BlogWebApplication.Model;
using BlogWebApplication.RepositoryInterface;
using BlogWebApplication.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.Service
{
	public class BlogService : IBlogService
	{
		private IBlogRepository _repository;
		private IMapper _mapper;
		public BlogService(IBlogRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}
		public async Task<IEnumerable<Blog>> GetAllBlogs()
		{
			var blog = await _repository.GetAllBlogs();
			return _mapper.Map<List<Blog>>(blog);
		}

		public async Task<long> SaveBlog(Blog post)
		{
			post.CreatedOn =DateTime.UtcNow;
			post.ModifiedOn= DateTime.UtcNow;

			return await _repository.SaveBlog(_mapper.Map<BlogDBEntity>(post));
		}

		public async Task<long> UpdateBlog(Blog post)
		{
			post.ModifiedOn = DateTime.UtcNow;
			return await _repository.UpdateBlog(_mapper.Map<BlogDBEntity>(post));
		}
	}
}
