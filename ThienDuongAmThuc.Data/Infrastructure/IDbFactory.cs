using System;

namespace ThienDuongAmThuc.Data.Infrastructure
{
    //Mot giao tiep de khoi tao cac doi tuong entity(khong khoi tao truc tiep ma thong qua mau design patten)
    public interface IDbFactory : IDisposable
    {
        ThienDuongAmThucDbContext Init();
    }
}