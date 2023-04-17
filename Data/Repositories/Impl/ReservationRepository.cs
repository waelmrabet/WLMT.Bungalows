using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Impl
{
    public class ReservationRepository: IReservationRepository
    {
        private readonly MyDataBaseContext _context;

        public ReservationRepository(MyDataBaseContext context)
        {
            _context = context;
        }

        public void Delete(Reservation reservation)
        {
            _context.Remove(reservation);
        }

        public List<Reservation> GetAll()
        {
            return _context.Reservations.ToList();
        }

        public List<Reservation> GetAllReservationByBungalowId(int bungalowId)
        {
            return _context.Reservations
                .Where(x => x.BungalowId == bungalowId)
                .ToList();
        }

        public Reservation GetById(int tenantInfoId, int bungalowId, DateTime startDate, DateTime endDate)
        {
            return _context.Reservations.Find(tenantInfoId, bungalowId, startDate, endDate);
        }

        public List<Reservation> GetReservationByDates(DateTime startDate, DateTime endDate)
        {
            return _context.Reservations
                .Where(x => x.StartDate >= startDate && x.EndDate <= endDate)
                .ToList();
        }

        public Reservation Insert(Reservation reservation)
        {
            _context.Add(reservation);
            return reservation;
        }

        public Reservation Update(Reservation reservation)
        {
            _context.Update(reservation);
            return reservation;
        }
    }
}
