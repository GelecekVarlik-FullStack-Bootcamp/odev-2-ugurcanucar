using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Abstract
{
    public interface IGenericRepository<T>where T:IEntityBase
    {
        //Listeleme
        List<T> GetAll();

        //Filtreli Listeleme
        List<T> GetAll(Expression<Func<T, bool>> expression);

        //Parametreli Getirme
        T Find(int id);

        //Kayıt
        T Add(T item);

        //Async Kayıt
        Task<T> AddAsync(T item);

        //Update
        T Update(T item);
         

        //Delete
        bool Delete(int id);

        bool Delete(T item);

        
        //IQuerable Listeleme
        IQueryable<T> GetQueryable();
    }
}
