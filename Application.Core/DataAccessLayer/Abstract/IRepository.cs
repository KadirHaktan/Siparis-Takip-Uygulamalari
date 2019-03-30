using Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.DataAccessLayer.Abstract
{
    public interface IRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Add(T entity);
        T Delete(T entity);
        T Update(T entity);
    }
}
