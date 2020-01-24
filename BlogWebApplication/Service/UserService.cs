using AutoMapper;
using BlogWebApplication.Model;
using BlogWebApplication.RepositoryInterface;
using BlogWebApplication.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogWebApplication.Service
{
	public class UserService : IUserService
	{

		private IUserRepository _repository;
		private IMapper _mapper;

		public UserService(IUserRepository repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}
		public async Task<bool> Authenticate(string username, string password)
		{
			return await _repository.IsUserValidAsync(username, password);
		}

		public async Task<IEnumerable<User>> GetAllUsers()
		{
			var user = await _repository.GetAllUsersAsync();
			return _mapper.Map<List<User>>(user);
		}
	}
}
