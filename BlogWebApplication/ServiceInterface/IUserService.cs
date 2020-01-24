using BlogWebApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.ServiceInterface
{
	public interface IUserService
	{
		Task<bool> Authenticate(string username, string password);
		Task<IEnumerable<User>> GetAllUsers();
	}
}
