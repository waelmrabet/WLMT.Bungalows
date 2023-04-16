using AutoMapper;
using BLL.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Dtos;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("[action]")]
        public List<UserReadDto> GetAll()
        {
            var users = _userService.GetAll();
            var result = _mapper.Map<List<UserReadDto>>(users);

            return result;
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public UserReadDto GetById(int id)
        {
            var user = _userService.GetById(id);
            var result = _mapper.Map<UserReadDto>(user);

            return result;
        }

        [HttpPost]
        [Route("[action]")]
        public UserReadDto AddUser(UserCreateDto userCreateDto)
        {
            var user = _mapper.Map<User>(userCreateDto);
            _userService.Insert(user);

            var result = _mapper.Map<UserReadDto>(user);

            return result;
        }

        [HttpPut]
        [Route("[action]/{id}")]
        public UserReadDto UpdateUser(UserUpdateDto userUpdateDto, int id)
        {
            var user = _mapper.Map<User>(userUpdateDto);
            _userService.Update(user);
            var result = _mapper.Map<UserReadDto>(user);

            return result;
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public void DeleteUser(int id)
        {
            var user = _userService.GetById(id);
            _userService.Delete(user);
        }



    }
}
