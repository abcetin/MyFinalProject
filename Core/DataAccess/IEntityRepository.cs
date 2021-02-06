using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess //isim uzayı classlar interface i belli bir isim uzayının içine bırakıyoruz ki kolay erişebilelim diye
{
    //**Core katamanı hiç bir sınıfa bağımlı olmaz 
    //Generic constraint = generic kısıt <T>
    // class : referans tip
    //where T :class, IEntity t referans tip olmalı ve IEntity ya da IEntity den implemnt edilmiş olmalı
    //new() eklendiği zaman yani new lenebilir olmalı demek IEntity new lenemez ondan implement olanlar newlenebilir
    public interface IEntityRepository<T> where T :class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
