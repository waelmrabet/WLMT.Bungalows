using Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ComplexTypes
{
    
    public class Address : BaseEntity
    {
        public string Number { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Qontry { get; set; }
        public string Latitude { get; set; }
        public string IndicationDescription { get; set; }
        public string Longitude { get; set; }

        //[ForeignKey(nameof(Bungalow))]
        //public int BungalowId { get; set; }

        //#region navigation properties
        //public virtual Bungalow Bungalow { get; set; }

        //#endregion

    }
}
