using Core.Models;
using Data.Infrastructure;
using Data.Infrastructure.GenericRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure.GenericServices.Impl
{
    public class CommandService<T> : ICommandService<T> where T : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICommandRepository<T> _commandRepository;

        public CommandService(IUnitOfWork unitOfWork, ICommandRepository<T> commandRepository)
        {
            _unitOfWork = unitOfWork;
            _commandRepository = commandRepository;
        }
        public void Insert(T t)
        {
            if(t != null)
            {
                _commandRepository.Insert(t);
                _unitOfWork.Commit();
            }
        }
        public void Insert(List<T> ts)
        {
            if (ts != null)
            {
                _commandRepository.Insert(ts);
                _unitOfWork.Commit();
            }
        }
        public void Update(T t)
        {
            if (t != null)
            {
                _commandRepository.Update(t);
                _unitOfWork.Commit();
            }
        }
        public void Update(List<T> ts)
        {
            if (ts != null)
            {
                _commandRepository.Update(ts);
                _unitOfWork.Commit();
            }
        }
        public void Delete(T t)
        {
            if (t != null)
            {
                _commandRepository.Remove(t);
                _unitOfWork.Commit();
            }
        }
        public void Delete(List<T> ts)
        {
            if (ts != null)
            {
                _commandRepository.Remove(ts);
                _unitOfWork.Commit();
            }
        }       
    }
}
