using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Domain.Common;

namespace Application.Contracts.Repository
{
    public interface IEntityRepository<T> where T:EntityBase
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
    }
}

