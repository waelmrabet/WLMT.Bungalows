using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Infrastructure.GenericServices
{
    public interface IReadService<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
    }
}
