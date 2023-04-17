using Core.Models;
using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IReservationRepository {

        Reservation Insert(Reservation reservation);
        Reservation Update(Reservation reservation);
        void Delete(Reservation reservation);
        List<Reservation> GetAll();
        Reservation GetById(int tenantInfoId, int bungalowId, DateTime startDate, DateTime endDate);
        List<Reservation> GetReservationByDates(DateTime startDate, DateTime endDate);
        List<Reservation> GetAllReservationByBungalowId(int bungalowId);

    }
}
