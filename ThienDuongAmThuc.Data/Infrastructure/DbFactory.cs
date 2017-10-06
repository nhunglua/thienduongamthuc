using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThienDuongAmThuc.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
       private ThienDuongAmThucDbContext dbContext;
        public ThienDuongAmThucDbContext Init()
        {
            return dbContext ?? (dbContext = new ThienDuongAmThucDbContext());
        }

        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }

    }
}
