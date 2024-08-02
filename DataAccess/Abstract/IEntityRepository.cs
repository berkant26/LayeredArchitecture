using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    // 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    { // T nin alabilecegi degerleri sinirlandirkdik referans tip ve IEntity'i implement eden siniflar olacak, Ientity de olmayacak
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
