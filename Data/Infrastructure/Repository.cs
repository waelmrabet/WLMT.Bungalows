using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure

{
    public class Repository<T> : IRepository<T> where T : BaseEntity
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

        public Repository(MyDataBaseContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public virtual void Insert(T t)
        {
            if (t != null)
                _entities.Add(t);
        }
        public virtual void Insert(List<T> ts)
        {
            if (ts != null)
                _entities.AddRange(ts);
        }

        public virtual void Remove(T t)
        {
            if (t != null)
                _entities.Remove(t);
        }

        public virtual void Remove(List<T> ts)
        {
            if (ts != null)
                _entities.RemoveRange(ts);
        }

        public virtual void Update(T t)
        {
            if (t != null)
                _entities.Update(t);
        }

        public virtual void Update(List<T> ts)
        {
            if (ts != null)
                _entities.UpdateRange(ts);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }
        public virtual T GetById(int id)
        {
            return _entities.Find(id);
        }

    }
}
