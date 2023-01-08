﻿using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure.GenericRepositories
{
    public interface ICommandRepository<T> where T : BaseEntity
    {
        void Insert(T t);
        void Insert(List<T> ts);
        void Update(T t);
        void Update(List<T> ts);
        void Remove(T t);
        void Remove(List<T> ts);

    }
}
