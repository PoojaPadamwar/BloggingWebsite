using BlogWebApplication.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.RepositoryInterface
{
	public interface IUserRepository
	{
		Task<bool> IsUserValidAsync(string username, string password);

		Task<IList<UserDBEntities>> GetAllUsersAsync();

	}
}
