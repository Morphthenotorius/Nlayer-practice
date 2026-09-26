using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repositories
{
    public interface IRepositoryBase<TEntity>
        where TEntity : class, IEntity
    {
        public void Add(TEntity entity);
    }
}
