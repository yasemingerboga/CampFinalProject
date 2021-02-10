using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint (generic kisit)
    //class : referans tip
    //IEntity veya IEntity implement eden bir nesne olabilir
    //new() : new() 'lenebilir oldugu anlamına gelir. Interface oldugu icin IEntity kabul edilmez.
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter= null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
