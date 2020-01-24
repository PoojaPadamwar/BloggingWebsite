using BlogWebApplication.Model;
using BlogWebApplication.ServiceInterface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogWebApplication.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogController : ControllerBase
	{
		private readonly IBlogService _blogService;
		public BlogController(IBlogService blogService)
		{
			_blogService = blogService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			//Test controller action
			return new string[] { "value1", "value2" };
		}

		[HttpGet]
		[Route("GetAllBlogs")]
		public async Task<IEnumerable<Blog>> GetAllBlogs()
		{			
			return await _blogService.GetAllBlogs();
		}
		[HttpPost]
		[Route("SaveBlog")]
		public async Task<long> SaveBlog(Blog obj)
		{
			return await _blogService.SaveBlog(obj);
		}

		[HttpPut]
		[Route("UpdateBlog")]
		public async Task<long> UpdateBlog(Blog obj)
		{
			return await _blogService.UpdateBlog(obj);
		}
	}
}
