using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class TenantInfo: BaseEntity
    {

        #region properties
        public string CIN { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        //[ForeignKey(nameof(Tenant))]
        //public int? TenantId { get; set; }

        #endregion

        #region navigation properties
        //public virtual Tenant Tenant { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        #endregion
    
    }
}
