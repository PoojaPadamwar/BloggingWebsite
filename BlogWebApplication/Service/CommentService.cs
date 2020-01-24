using AutoMapper;
using BlogWebApplication.Model ;
using BlogWebApplication.DBEntities;
using BlogWebApplication.RepositoryInterface;
using BlogWebApplication.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.Service
{
	public class CommentService : ICommentService
	{
		private readonly ICommentRepository _repository;

		private IMapper _mapper;

		public CommentService(ICommentRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}
		public async Task<IEnumerable<Comment>> GetAllComments()
		{
			var comment = await _repository.GetAllComments();
			return _mapper.Map<List<Comment>>(comment);
		}

		public async Task<long> SaveComment(Comment  comment)
		{
			return await _repository.SaveComment(_mapper.Map<CommentDBEntities>(comment));
			
		}

		public async Task<long> UpdateComment(Comment  comment)
		{
			return await _repository.UpdateComment(_mapper.Map<CommentDBEntities>(comment));			
		}
	}
}
