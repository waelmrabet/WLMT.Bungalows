
using BLL.Infrastructure;
using Core.Models;
using Data.Infrastructure;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services.Impl
{
    public class UserService : ServicePattern<User>, IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork, IUserRepository userRepo) : base(unitOfWork, userRepo)
        {
            _userRepo = userRepo;
            _unitOfWork = unitOfWork;
        }

        public void DesactivateUser(int userId, bool activate)
        {
            var user = GetById(userId);
            user.Activated = activate;
            _unitOfWork.Commit();
        }

        public User GetUserByUserName(string login)
        {
            var user = _userRepo.GetUserByUserName(login);
            return user;
        }
    }
}
