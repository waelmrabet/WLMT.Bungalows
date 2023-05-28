
using BLL.Infrastructure;
using Core.Models;
using Data.Infrastructure;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Services.Impl
{
    public class RoleService : ServicePattern<Role>, IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IUnitOfWork unitOfWork, IRoleRepository repo): base(unitOfWork, repo)
        {
            this._roleRepository = repo;
        }

        public HashSet<Menu> GetMenusByRoleId(int roleId)
        {
            var role = this.GetRoleWithMenusById(roleId);
            var list = new HashSet<Menu>();

            foreach (var item in role.RoleMenus)
                list.Add(item.Menu);

            return list;
        }

        public Role GetRoleWithMenusById(int roleId)
        {
            var role = this._roleRepository.GetRoleUserWithMenus(roleId);
            return role;
        }
    }
}
