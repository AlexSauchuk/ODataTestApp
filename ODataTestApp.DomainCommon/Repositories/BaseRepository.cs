using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ODataTestApp.DomainCommon.Models;

namespace ODataTestApp.DomainCommon.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T>
        where T : BaseModel
    {
        public T Attach(T model)
        {
            throw new NotImplementedException();
        }

        public T Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Delete(T model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetRange(int index, int count, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public T Insert(T model)
        {
            throw new NotImplementedException();
        }

        public T Update(T model)
        {
            throw new NotImplementedException();
        }
    }
}
