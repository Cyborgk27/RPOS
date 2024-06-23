using RPOS.Domain.Entities;
using RPOS.Infrastructure.Commons.Bases.Request;
using RPOS.Infrastructure.Commons.Bases.Response;

namespace RPOS.Infrastructure.Persistences.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<BaseEntityResponse<Category>> ListCategories(BaseFiltersRequest filters);
    }
}
