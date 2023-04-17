using Core.Models;
using Data.Infrastructure;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Impl
{
    public class TenantService: Infrastructure.ServicePattern<Tenant>, ITenantService
    {
        public TenantService(IUnitOfWork unitOfWork, ITenantRepository tenantRepository): base(unitOfWork, tenantRepository) { }
    }
}
