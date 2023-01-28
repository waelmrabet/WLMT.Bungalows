using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ResevationDay: BaseEntity
    {
        #region properties
        public string DayName { get; set; }
        public DateTime Day { get; set; }

        #endregion

        #region navigation properties
        public virtual Reservation Reservation { get; set; }

        #endregion
    }
}
