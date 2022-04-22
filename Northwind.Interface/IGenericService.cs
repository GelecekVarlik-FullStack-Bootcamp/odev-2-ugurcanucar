using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IGenericService<T,TDto> where T :IEntityBase where TDto :IDtoBase   
    {
        //Listeleme
        IResponse<List<TDto>> GetAll();

        //Filtreli Listeleme
        IResponse<List<TDto>> GetAll(Expression<Func<T,bool>> expression );
        
        //Parametreli Getirme
        IResponse<TDto> Find(int id);
        
        //Kayıt
        IResponse<TDto> Add(TDto item,bool saveChanges=true);
        
        //Async Kayıt
        Task<IResponse<TDto>> AddAsync(TDto item, bool saveChanges = true);

        //Update
        IResponse<TDto> Update(TDto item, bool saveChanges = true);

        //Async Update
        Task<IResponse<TDto>> UpdateAsync(TDto item, bool saveChanges = true);

        //Delete
        IResponse<bool> DeleteById(int id,bool saveChanges=true);

        //Async Delete
        Task<IResponse<bool>> DeleteByIdAsync(int id, bool saveChanges = true);

        //IQuerable Listeleme
        IQueryable<TDto> GetQueryable();

    }
}
