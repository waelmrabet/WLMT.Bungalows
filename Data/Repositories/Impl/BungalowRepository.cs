using Core.Models;
using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Impl
{
    public class BungalowRepository : Repository<Bungalow>, IBungalowRepository
    {
        public BungalowRepository(MyDataBaseContext context) : base(context) { }

    }
}
