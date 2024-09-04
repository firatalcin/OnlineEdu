using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEduApp.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> GetList();
        T GetByFilter(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        int Count();
        int FilteredCount(Expression<Func<T, bool>> predicate);
        List<T> GetFilteredList(Expression<Func<T, bool>> predicate);
    }
}
