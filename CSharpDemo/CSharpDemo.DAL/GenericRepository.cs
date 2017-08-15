using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

using CSharpDemo.DAL.Interface;
using CSharpDemo.Models.Entity.ORM;
using System.Data.Entity;
using System.Runtime.Remoting.Messaging;

namespace CSharpDemo.DAL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected CSharpDemoContext context = null;

        public GenericRepository(CSharpDemoContext _context)
        {
            this.context = _context;
        }

        public T Add(T entity)
        {
            this.context.Entry<T>(entity).State = EntityState.Added;
            this.context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            this.context.Set<T>().Attach(entity);
            this.context.Entry<T>(entity).State = EntityState.Modified;
            this.context.SaveChanges();

            return entity;
        }

        public bool Delete(T entity)
        {
            this.context.Set<T>().Attach(entity);
            this.context.Entry<T>(entity).State = EntityState.Deleted;
            return this.context.SaveChanges() > 0;
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return this.context.Set<T>().Where<T>(predicate).Count<T>();
        }

        public bool Exist(Expression<Func<T, bool>> predicate)
        {
            return this.context.Set<T>().Where<T>(predicate).Any<T>();
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            T entity = this.context.Set<T>().Where<T>(predicate).FirstOrDefault<T>();
            return entity;
        }

        public IQueryable<T> FindList<S>(Expression<Func<T, bool>> whereLamdba, bool isAsc, Expression<Func<T, S>> orderLamdba)
        {
            var list = this.context.Set<T>().Where<T>(whereLamdba);
            if (isAsc)
            {
                list = list.OrderBy<T, S>(orderLamdba);
            }
            else
            {
                list = list.OrderByDescending<T, S>(orderLamdba);
            }

            return list;
        }

        public IQueryable<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord, 
            Expression<Func<T, bool>> whereLamdba, bool isAsc, Expression<Func<T, S>> orderLamdba)
        {
            var list = this.context.Set<T>().Where<T>(whereLamdba);
            totalRecord = list.Count();

            if (isAsc)
            {
                list = list.OrderBy<T, S>(orderLamdba).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }
            else
            {
                list = list.OrderByDescending<T, S>(orderLamdba).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            }

            return list;
        }
    }
}
