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
	public class UserRepository : IUserRepository
	{
		private readonly BlogContext _context;
		private DbSet<UserDBEntities> _entities;

		private DbSet<UserDBEntities> Entities
		{
			get
			{
				if (_entities == null)
				{
					_entities = _context.Set<UserDBEntities>();
				}
				return _entities;
			}
		}
		public UserRepository(BlogContext context)
		{
			_context = context;
		}

		public async Task<bool> IsUserValidAsync(string username, string password)
		{
			var users = await GetAllUsersAsync();
			var result = false;
			var user = await Task.Run(() => users.SingleOrDefault(x => x.UserName == username && x.Password == password));

			if (user != null)
			{
				result = true;
			}
			return result;
		}

		public async Task<IList<UserDBEntities>> GetAllUsersAsync()
		{
			return await this.Entities.ToListAsync();
		}
	}
}
