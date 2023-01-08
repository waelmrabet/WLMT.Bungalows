using BLL.Services.Commands;
using BLL.Services.Queries;
using Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserCommandServices _userCommandService;
        private readonly IUserReadService _userReadService;

        public UserController(IUserCommandServices userCommandService, IUserReadService userReadService)
        {
            _userCommandService = userCommandService;
            _userReadService = userReadService;
        }

        [HttpGet]
        [Route("[action]")]
        public List<User> GetAll()
        {
            var users = _userReadService.GetAll();
            return users;
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public User GetById(int id)
        {
            var user = _userReadService.GetById(id);
            return user;
        }

        [HttpPost]
        [Route("[action]")]
        public User AddUser(User user)
        {
            _userCommandService.Insert(user);
            return user;
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public User UpdateUser(User user, int id)
        {
            _userCommandService.Update(user);
            return user;
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public void DeleteUser(int id)
        {
            var user = _userReadService.GetById(id);
            _userCommandService.Delete(user);            
        }



    }
}
