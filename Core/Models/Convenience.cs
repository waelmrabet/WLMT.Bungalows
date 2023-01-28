﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Convenience : BaseEntity
    {
        #region properties
        public string Libelle { get; set; }
        public string Description { get; set; }

        #endregion

        #region navigation properties
        public virtual  ICollection<Bungalow> Bungalows { get; set; }

        #endregion

    }
}
