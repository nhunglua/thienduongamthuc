using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Model.Models;

namespace ThienDuongAmThuc.Data.Repositories
{
    public interface IFooterResipotory : IRepository<Footer>
    {
    }
    public class FooterResipotory : RepositoryBase<Footer> , IFooterResipotory
    {
        public FooterResipotory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}