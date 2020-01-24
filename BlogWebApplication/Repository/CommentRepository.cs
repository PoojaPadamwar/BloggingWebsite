using AutoMapper;
using BlogWebApplication.DBEntities;
using BlogWebApplication.RepositoryInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.Repository
{
	public class CommentRepository : ICommentRepository
	{
		private readonly BlogContext _context;	
		private DbSet<CommentDBEntities> _entities;

		public CommentRepository(BlogContext context)
		{
			_context = context;
		}

		private DbSet<CommentDBEntities> Entities
		{
			get
			{
				if (_entities == null)
				{
					_entities = _context.Set<CommentDBEntities>();
				}
				return _entities;
			}
		}
		public async Task<IEnumerable<CommentDBEntities>> GetAllComments()
		{
			return await this.Entities.ToListAsync();
		}

		public async Task<long> SaveComment(CommentDBEntities comment)
		{
			await this.Entities.AddAsync(comment);
			return await _context.SaveChangesAsync();
		}

		public async Task<long> UpdateComment(CommentDBEntities comment)
		{
			_context.Entry(comment).State = EntityState.Modified;

			var result= await _context.SaveChangesAsync();

			return await Task.FromResult(result);
		}
	}
}
