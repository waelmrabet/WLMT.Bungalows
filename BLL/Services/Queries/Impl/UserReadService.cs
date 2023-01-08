using BLL.Infrastructure.GenericServices.Impl;
using Core.Models;
using Data.Repositories.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Queries.Impl
{
    public class UserReadService : ReadService<User>, IUserReadService
    {
        public UserReadService(IUserReadRepository userReadRepository): base(userReadRepository) { }
    }
}
