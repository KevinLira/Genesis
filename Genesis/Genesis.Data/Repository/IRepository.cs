using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Genesis.Common.DTO;

namespace Genesis.Data.Repository
{
    public interface IRepository<T> where T : EntityBase
    {

        IEnumerable<T> List();

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(Guid Id);

    }
}
