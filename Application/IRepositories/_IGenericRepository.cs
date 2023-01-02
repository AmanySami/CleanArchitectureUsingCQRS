﻿using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.IRepositories
{
    public interface _IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAll(
             Expression<Func<T, bool>> expression = null,
             Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
             Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
          );
        Task<T> Get(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<T> Insert(T entity);
        Task InsertRange(IEnumerable<T> entities);
        Task Delete(Guid id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);

    }
}
