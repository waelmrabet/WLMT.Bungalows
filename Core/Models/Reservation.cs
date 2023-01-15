using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Reservation
    {
        #region properties

        [ForeignKey(nameof(TenantInfo))]
        public int TenantInfoId { get; set; }

        [ForeignKey(nameof(Bungalow))]
        public int BungalowId { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        [ForeignKey(nameof(ReservationState))]
        public int ReservationStateId { get; set; }

        public float NumberOfNights { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float TotalPrice { get; set; }
        public string Comment { get; set; }

       

        #endregion

        #region navigation properties
        public virtual TenantInfo TenantInfo { get; set; }
        public Bungalow Bungalow { get; set; }
        public User User { get; set; }
        public ReservationState ReservationState { get; set; }

        #endregion

    }
}
