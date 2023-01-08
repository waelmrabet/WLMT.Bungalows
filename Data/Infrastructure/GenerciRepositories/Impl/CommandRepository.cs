using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure.GenericRepositories.Impl
{
    public class CommandRepository<T> : ICommandRepository<T> where T : BaseEntity
    {
        private readonly MyDataBaseContext _context;
        private readonly DbSet<T> _entities;
        public DbSet<T> Entities
        {
            get
            {
                return this._entities;
            }
        }

        public CommandRepository(MyDataBaseContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }
        public void Insert(T t)
        {
            if(t != null)
                _entities.Add(t);
        }
        public void Insert(List<T> ts)
        {
            if (ts != null)
                _entities.AddRange(ts);
        }

        public void Remove(T t)
        {
            if (t != null)
                _entities.Remove(t);
        }

        public void Remove(List<T> ts)
        {
            if (ts != null)
                _entities.RemoveRange(ts);
        }

        public void Update(T t)
        {
            if (t != null)
                _entities.Update(t);
        }

        public void Update(List<T> ts)
        {
            if (ts != null)
                _entities.UpdateRange(ts);
        }
    }
}
