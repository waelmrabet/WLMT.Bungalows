using Core.Models;
using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public interface IRoleRepository: IRepository<Role>
    {
        public Role GetRoleUserWithMenus(int roleId);
    }
}
