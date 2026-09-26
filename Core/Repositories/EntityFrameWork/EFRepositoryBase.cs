using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Repositories.EntityFrameWork
{
    public class EFRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TContext : DbContext, new()
        where TEntity : class,IEntity
    {
        public void Add(TEntity entity)
        {
            var context = new TContext();
            var addEntity = context.Entry(entity);
            addEntity.State= EntityState.Added;
            context.SaveChanges();
        }
    }
}
