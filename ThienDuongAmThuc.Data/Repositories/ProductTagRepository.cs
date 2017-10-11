using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Model.Models;

namespace ThienDuongAmThuc.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag> { }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IPostTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}