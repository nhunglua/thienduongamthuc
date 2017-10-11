using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Model.Models;

namespace ThienDuongAmThuc.Data.Repositories
{
    public interface ISupportOnlineRepository : IRepository<SupportOnline> { }

    public class SupportOnlineRepository : RepositoryBase<SupportOnline>
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}