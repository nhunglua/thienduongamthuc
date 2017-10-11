using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Model.Models;

namespace ThienDuongAmThuc.Data.Repositories
{
    public interface IMenuGroupRespository :IRepository<MenuGroup>
    {

    }
   public class MenuGroupRespository : RepositoryBase<MenuGroup>, IMenuGroupRespository
    {
        public MenuGroupRespository (IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}
