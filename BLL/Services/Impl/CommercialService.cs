using BLL.Infrastructure;
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
    public class CommercialService: ServicePattern<Commercial>, ICommercialService
    {
        public CommercialService(IUnitOfWork unitOfWork, ICommercialRepository commercialRepository) : base(unitOfWork, commercialRepository) {}
    }
}
