using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure
{
    public interface IServicePattern<T> where T : BaseEntity
    {
        void Insert(T t);
        void Insert(List<T> ts);
        void Update(T t);
        void Update(List<T> ts);
        void Delete(T t);
        void Delete(List<T> ts);
        List<T> GetAll();
        T GetById(int id);
    }
}
