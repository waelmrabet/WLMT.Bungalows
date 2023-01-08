using Core.Models;
using Data.Infrastructure.GenericRepositories.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Queries.Impl
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(MyDataBaseContext context) : base(context) { }
    }
}
