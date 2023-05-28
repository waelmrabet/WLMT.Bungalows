using AutoMapper;
using BL.Services;
using BLL.Services;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.Dtos;
using WebApi.Helpers;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IStringCryptorDecryptor _stringCryptorDecryptor;
        private readonly IMapper _mapper;
        private IUserService _userService;
        private IRoleService _roleService;
        

        public UserController(IMapper mapper, IUserService userService, IStringCryptorDecryptor stringCryptorDecryptor, IRoleService roleService)
        {
            _mapper = mapper;
            _userService = userService;
            _roleService = roleService;
            _stringCryptorDecryptor = stringCryptorDecryptor;
            
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
        public UserReadDto AddUser(UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);

            userModel.CryptedPassword = _stringCryptorDecryptor.EncryptString(userCreateDto.Password);

            _userService.Insert(userModel);
           
            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return userReadDto;
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
