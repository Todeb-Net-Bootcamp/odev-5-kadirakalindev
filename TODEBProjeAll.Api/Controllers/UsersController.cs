using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TODEBProjeAll.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController()
        {
            _userService = new UserManager();
        }
        [HttpGet]
        public List<Users> GetUsers()
        {
            return _userService.GetAllUsers();
        }
        [HttpGet("{id}")]
        public Users GetUser(int id)
        {
            return _userService.GetUserById(id);
        }
    }
}
