using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Model.Models;

namespace ThienDuongAmThuc.Data.Repositories
{
    public interface IOrderDetailReposity : IRepository<OrderDetail> { }

    public class OrderDetailReposity : RepositoryBase<OrderDetail>, IOrderDetailReposity
    {
        public OrderDetailReposity(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}