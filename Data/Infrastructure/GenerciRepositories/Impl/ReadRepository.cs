using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure.GenericRepositories.Impl
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly MyDataBaseContext _context;

        private readonly DbSet<T> _entities;
        public DbSet<T> entities
        {
            get
            {
                return _entities;
            }
        }

        public ReadRepository(MyDataBaseContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
        public T GetById(int id)
        {
            return _entities.Find(id);
        }
    }
}
