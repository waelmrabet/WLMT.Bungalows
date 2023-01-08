using Core.Models;
using Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure.GenericServices.Impl
{
    public class ReadService<T> : IReadService<T> where T : BaseEntity
    {
        private readonly IReadRepository<T> _readRepository;

        public ReadService(IReadRepository<T> readRepository)
        {
            _readRepository = readRepository;
        }
        public List<T> GetAll()
        {
            return _readRepository.GetAll().ToList();
        }
        public T GetById(int id)
        {
            return _readRepository.GetById(id);
        }
    }
}
