using Core.Models;
using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure
{
    public class ServicePattern<T> : IServicePattern<T> where T : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<T> _repository;

        public ServicePattern(IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public virtual void Insert(T t)
        {
            if (t != null)
            {
                _repository.Insert(t);
                _unitOfWork.Commit();
            }
        }
        public virtual void Insert(List<T> ts)
        {
            if (ts != null)
            {
                _repository.Insert(ts);
                _unitOfWork.Commit();
            }
        }
        public virtual void Update(T t)
        {
            if (t != null)
            {
                _repository.Update(t);
                _unitOfWork.Commit();
            }
        }
        public virtual void Update(List<T> ts)
        {
            if (ts != null)
            {
                _repository.Update(ts);
                _unitOfWork.Commit();
            }
        }
        public virtual void Delete(T t)
        {
            if (t != null)
            {
                _repository.Remove(t);
                _unitOfWork.Commit();
            }
        }
        public virtual void Delete(List<T> ts)
        {
            if (ts != null)
            {
                _repository.Remove(ts);
                _unitOfWork.Commit();
            }
        }

        public virtual List<T> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public virtual T GetById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
