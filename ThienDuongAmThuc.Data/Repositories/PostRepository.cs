using System;
using System.Collections.Generic;
using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Model.Models;
using System.Linq;

namespace ThienDuongAmThuc.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        // hien thi danh sach bai viet ma no co cai tag, khi kich vao cai link tag no ra danh sach, giup cho viec SEO
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status==true
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;

        }
    }
}