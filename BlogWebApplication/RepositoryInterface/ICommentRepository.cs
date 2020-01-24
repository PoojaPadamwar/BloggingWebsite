using BlogWebApplication.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.RepositoryInterface
{
	public interface ICommentRepository
	{
		Task<IEnumerable<CommentDBEntities>> GetAllComments();
		
		Task<long> SaveComment(CommentDBEntities comment);

		Task<long> UpdateComment(CommentDBEntities comment);
	}
}
