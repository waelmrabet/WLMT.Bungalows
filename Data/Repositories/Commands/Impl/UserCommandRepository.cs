using Core.Models;
using Data.Infrastructure.GenericRepositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Commands.Impl
{
    public class UserCommandRepository : CommandRepository<User>, IUserCommandRepository
    {
        public UserCommandRepository(MyDataBaseContext context): base(context)  {}
    }
}
