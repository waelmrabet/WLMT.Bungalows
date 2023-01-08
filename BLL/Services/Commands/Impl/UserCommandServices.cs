using BLL.Infrastructure.GenericServices.Impl;
using Core.Models;
using Data.Infrastructure;
using Data.Repositories.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Commands.Impl
{
    public class UserCommandServices : CommandService<User>, IUserCommandServices
    {
        public UserCommandServices(IUnitOfWork unitOfWork, IUserCommandRepository userCommandRepository)
            : base(unitOfWork, userCommandRepository) { }
    }
}
