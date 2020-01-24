using BlogWebApplication.Model;
using BlogWebApplication.ServiceInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogWebApplication.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserLoginController
	{
		private readonly IUserService _userServices;

		public UserLoginController(IUserService userServices)
		{
			_userServices = userServices;
		}

		[Route("/login")]
		[AllowAnonymous]
		[Microsoft.AspNetCore.Mvc.HttpGet]
		public async Task<bool> IsUserValid(User user)
		{
			return await _userServices.Authenticate(user.UserName, user.Password);			
		}

		[HttpGet]
		public async Task<IEnumerable<User>> GetAllUsers()
		{
			return await _userServices.GetAllUsers();
		}

	}
}
