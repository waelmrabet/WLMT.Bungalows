using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Tenant : User
    {
        #region  properties
        [ForeignKey(nameof(TenantInfo))]
        public int? TenantInfoId { get; set; }

        #endregion

        #region navigation properties
        public virtual TenantInfo TenantInfo { get; set; }

        #endregion
    }
}
