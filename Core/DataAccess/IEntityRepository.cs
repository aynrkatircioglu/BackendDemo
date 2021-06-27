using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;


namespace Core.DataAccess
{
    //generic constraint
    //class:referans tip olabilir
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // IEntitydediğimde bir classa veritabanım gibi davranıyor demek 
    //new(): new'lenebilir olmalı

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
