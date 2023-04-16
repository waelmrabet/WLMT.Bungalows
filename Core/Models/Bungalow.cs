using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Bungalow : BaseEntity
    {
        #region properties
        public string Description { get; set; }
        public int NumberOfRooms { get; set; }
        public float PricePerNight { get; set; }        

        [ForeignKey(nameof(Owner))]
        public int OwnerId { get; set; }

        [ForeignKey(nameof(Commercial))]
        public int CommercialId { get; set; }

        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }

        #endregion

        #region navigation properties
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<Convenience> Conveniences { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual Owner Owner { get; set; }
        public virtual Commercial Commercial { get; set; }
        public virtual Address Address { get; set; }

        #endregion

    }
}
