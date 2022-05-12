using Northwind.Entity.Base;
using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IGenericService<T, TDto> where T : IEntityBase where TDto : IDtoBase
    {
        // ---- Ortak Bulunan Metotlar----
        //Listeleme
        IResponse<List<TDto>> GetAll();

        //Filtreli listeleme
        IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression);
        //Getirme işlemi (Bulma)

        IResponse<TDto> Find(int id);
        //Kaydetme

        IResponse<TDto> Add(TDto item, bool saveChanges = true);
        //Async(Asenkron) Kaydetme
        Task<IResponse<TDto>> AddASync(TDto item, bool saveChanges = true);
        //Güncelleme
        IResponse<TDto> Update(TDto item, bool saveChanges = true);
        //Async Güncelleme
        Task<IResponse<TDto>> UpdateASync(TDto item, bool saveChanges = true);
        //Silme
        IResponse<bool> DeleteById(int id, bool saveChanges = true);
        //Async Silme
        Task<IResponse<bool>> DeleteByIdAsync(int id, bool saveChanges = true);

        //IQueryable Listele
        IResponse<IQueryable<TDto>> GetQueryable();
        void Save();
    }
}
