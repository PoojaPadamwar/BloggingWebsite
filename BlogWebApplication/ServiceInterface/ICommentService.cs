using BlogWebApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.ServiceInterface
{
	public interface ICommentService
	{
		Task<IEnumerable<Comment>> GetAllComments();

		Task<long> SaveComment(Comment comment);

		Task<long> UpdateComment(Comment comment);
	}
}
