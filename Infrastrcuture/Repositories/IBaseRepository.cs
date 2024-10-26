﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrcuture.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
         Task<T> Create(T entity);

         Task<T> Delete(T entity);

         Task<T> Update(T entity);

         IQueryable<T> GetAll();

    }
}
