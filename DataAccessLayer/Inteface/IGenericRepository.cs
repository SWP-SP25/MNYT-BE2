using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Inteface
{
    public interface IGenericRepository<TModel> where TModel : BaseEntity
    {
        Task AddAsync(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        Task SoftDeleteAsync(TModel model);
        Task<IEnumerable<TModel>> GetAllAsync();
        Task<TModel> GetAsync(int id);
    }
}
