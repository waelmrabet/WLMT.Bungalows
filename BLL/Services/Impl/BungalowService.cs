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
    public class BungalowService: ServicePattern<Bungalow>, IBungalowService
    {
        public BungalowService(IUnitOfWork unitOfWork, IBungalowRepository bungalowRepository) : base(unitOfWork, bungalowRepository)
        {

        }
    }
}
