using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using _1_BlogCore.DomainModels.BaseModels;
using Microsoft.EntityFrameworkCore.Query;

namespace _2_BlogApplication.IRepositories.BaseRepos
{
    public interface IBaseRepo<T> where T: IBaseEntity
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>> filter = null);
        Task<IEnumerable<T>> GetAllActiveAsync(Expression<Func<T,bool>> filter = null);
        Task<bool> AnyAsync(Expression<Func<T, bool>> filter);
        Task<TResult> GetFilteredModelAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> join =null);

        Task<IList<TResult>> GetFilteredListModelAsync<TResult>(
            Expression<Func<T, TResult>> select,
            Expression<Func<T, bool>> where = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null);

        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
    }
}