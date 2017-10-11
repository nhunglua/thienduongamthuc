using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Model.Models;

namespace ThienDuongAmThuc.Data.Repositories
{
    public interface ITagRepository:IRepository<Tag>
    {

    }
   public class TagReponsitory : RepositoryBase<Tag>, ITagRepository

    {
        public TagReponsitory (IDbFactory dbFactory) : base(dbFactory) { }
    }
}
