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
    public class ReservationDayService: ServicePattern<ResevationDay>, IReservationDayService
    {
        public ReservationDayService(IUnitOfWork unitOfWork, IResevationDayRepository photoRepository): base(unitOfWork, photoRepository)
        {
                
        }
    }
}
