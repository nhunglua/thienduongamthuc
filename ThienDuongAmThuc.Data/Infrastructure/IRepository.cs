using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ThienDuongAmThuc.Data.Infrastructure
{
   public interface IRepository<T> where T:class
    {
        //Marks an entity as new
        T Add(T entity);

        //Marks an entity as modified
        void Update(T entity);

        //Marks an entity to be removed
        T Delete(T entity);

        T Delete(int id);
        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        // Get an entity by int id
        T GetSingleByID(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IEnumerable<T> GetAll(string[] includes = null);

        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IEnumerable<T> GetMuiltiPaging(Expression<Func<T, bool>> filter, out int total, int idex = 0, int size = 0, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}
