using OnlineEduApp.Business.Abstract;
using OnlineEduApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEduApp.Business.Concrete
{
    public class GenericManager<T>(IRepository<T> _repository) : IGenericService<T> where T : class
    {
        public int Count()
        {
            return _repository.Count();
        }

        public void Create(T entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public int FilteredCount(Expression<Func<T, bool>> predicate)
        {
            return _repository.FilteredCount(predicate);
        }

        public T GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetByFilter(predicate);
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetFilteredList(predicate);
        }

        public List<T> GetList()
        {
            return _repository.GetList();
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }
    }
}
