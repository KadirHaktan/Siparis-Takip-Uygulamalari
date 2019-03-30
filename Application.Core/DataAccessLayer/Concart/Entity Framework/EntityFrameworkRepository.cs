using Application.Core.DataAccessLayer.Abstract;
using Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Application.Core.DataAccessLayer.Concart.Entity_Framework
{
    public class EntityFrameworkRepository<TEntity, TContext> : IRepository<TEntity> where TEntity : class, IEntity, new()
       where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using(var context=new TContext())
            {
                var adress_entity = context.Entry(entity);
                adress_entity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public TEntity Delete(TEntity entity)
        {
            using(var context=new TContext())
            {
                var adress_entity = context.Entry(entity);
                adress_entity.State = EntityState.Deleted;
                context.SaveChanges();
                return entity;
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using(var context=new TContext())
            {
                return filter != null ? context.Set<TEntity>().Where(filter).ToList() : context.Set<TEntity>().ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var adress_entity = context.Entry(entity);
                adress_entity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }
    }
}
