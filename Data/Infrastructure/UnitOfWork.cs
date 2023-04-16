using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyDataBaseContext _context;

        public UnitOfWork(MyDataBaseContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public void RollBack()
        {
            _context.Dispose();
        }
    }
}
