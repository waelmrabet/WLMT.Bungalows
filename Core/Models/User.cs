using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }

        public int RoleId { get; set; }
        public int ClientId { get; set; }
        public string CryptedPassword { get; set; }
        public bool Activated { get; set; }

       


    }
}
