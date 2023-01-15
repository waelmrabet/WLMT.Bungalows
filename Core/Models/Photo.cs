using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Photo : BaseEntity
    {
        #region properties
        public string PhotoName { get; set; }
        public string Description { get; set; }

        #endregion

    }
}
