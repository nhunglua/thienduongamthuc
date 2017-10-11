using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Model.Models;

namespace ThienDuongAmThuc.Data.Repositories
{
    public interface ISystemConfigRepository : IRepository<SystemConfig> { }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}