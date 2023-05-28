using Core.Models;
using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Impl
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(MyDataBaseContext context): base(context) {}

        public User GetUserByUserName(string login)
        {
            var user = Entities.Where(x => x.UserName == login).SingleOrDefault();

            return user;
        }
    }
}
