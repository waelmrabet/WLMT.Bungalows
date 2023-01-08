using Core.Models;
using Data.Infrastructure.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Commands
{
    public interface IUserCommandRepository : ICommandRepository<User>
    {
    }
}
