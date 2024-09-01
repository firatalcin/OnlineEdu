using Microsoft.EntityFrameworkCore;
using OnlineEduApp.DataAccess.Abstract;
using OnlineEduApp.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEduApp.DataAccess.Repositories
{
    public class GenericRepository<T>(AppDbContext context) : IRepository<T> where T : class
    {
        public DbSet<T> Table { get => context.Set<T>(); }

        public int Count()
        {
            return Table.Count();
        }

        public void Create(T entity)
        {
            Table.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var deletedItem = GetById(id);
            Table.Remove(deletedItem);
            context.SaveChanges();
        }

        public int FilteredCount(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).Count();
        }

        public T GetByFilter(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).FirstOrDefault();
        }

        public T GetById(int id)
        {
            return Table.Find(id);
        }

        public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return Table.Where(predicate).ToList();
        }

        public List<T> GetList()
        {
            return Table.ToList();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
            context.SaveChanges();
        }
    }
}
