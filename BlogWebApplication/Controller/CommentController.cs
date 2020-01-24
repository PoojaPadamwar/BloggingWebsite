using BlogWebApplication.Model;
using BlogWebApplication.ServiceInterface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogWebApplication.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommentController
	{
		private readonly ICommentService _commentService;
		public CommentController(ICommentService commentService)
		{
			_commentService = commentService;
		}
		[HttpGet]
		public async Task<IEnumerable<Comment>> GetAllBlogs()
		{
			return await _commentService.GetAllComments();
		}
		[HttpPost]
		[Route("SaveComment")]
		public async Task<long> SaveBlog(Comment obj)
		{
			return await _commentService.SaveComment(obj);
		}

		[HttpPut]
		[Route("updateComment")]
		public async Task<long> UpdateBlog(Comment obj)
		{
			return await _commentService.UpdateComment(obj);
		}
	}
}
