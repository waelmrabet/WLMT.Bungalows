using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Owner : User
    {
        #region properties
        public string Name { get; set; }
        public string LastName { get; set; }

        #endregion

        #region navigation properties
        public virtual ICollection<Bungalow> Bungalows { get; set; }

        #endregion
    }
}
