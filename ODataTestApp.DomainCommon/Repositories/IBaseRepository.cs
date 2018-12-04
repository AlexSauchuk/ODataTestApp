using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using ODataTestApp.DomainCommon.Models;

namespace ODataTestApp.DomainCommon.Repositories
{
    public interface IBaseRepository<T>
        where T: BaseModel
    {
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");
        IEnumerable<T> GetRange(int index, int count, Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        T GetById(int id);
        T Update(T model);
        T Delete(int id);
        T Delete(T model);
        T Insert(T model);
        T Attach(T model);
    }
}