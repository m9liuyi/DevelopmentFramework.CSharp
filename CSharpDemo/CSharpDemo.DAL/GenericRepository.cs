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
using CSharpDemo.Utility;

namespace CSharpDemo.DAL
{
    public class GenericRepository<T, M> : IGenericRepository<T, M> where T : class where M : class
    {

        protected CSharpDemoContext context = null;

        public GenericRepository(CSharpDemoContext _context)
        {
            this.context = _context;
        }

        public T Create(T itemDto)
        {
            if (itemDto == null)
            {
                return null;
            }

            var entity = MapperHelper.MapTo<M>(itemDto);

            this.context.Entry<M>(entity).State = EntityState.Added;
            this.context.SaveChanges();


            return MapperHelper.MapTo<T>(entity);
        }

        public T Update(T itemDto)
        {
            if (itemDto == null)
            {
                return null;
            }


            var entity = MapperHelper.MapTo<M>(itemDto);

            this.context.Set<M>().Attach(entity);
            this.context.Entry<M>(entity).State = EntityState.Modified;
            this.context.SaveChanges();

            return MapperHelper.MapTo<T>(entity);
        }

        public bool Delete(T itemDto)
        {
            if (itemDto == null)
            {
                return false;
            }
            var entity = MapperHelper.MapTo<M>(itemDto);

            this.context.Set<M>().Attach(entity);
            this.context.Entry<M>(entity).State = EntityState.Deleted;
            return this.context.SaveChanges() > 0;
        }

        public int Count(Expression<Func<M, bool>> predicate)
        {
            return this.context.Set<M>().Where<M>(predicate).Count<M>();
        }

        public bool Exist(Expression<Func<M, bool>> predicate)
        {
            return this.context.Set<M>().Where<M>(predicate).Any<M>();
        }

        public T Find(Expression<Func<M, bool>> predicate)
        {
            M entity = this.context.Set<M>().Where<M>(predicate).FirstOrDefault<M>();
            return MapperHelper.MapTo<T>(entity);
        }

        public IList<T> FindList<S>(Expression<Func<M, bool>> whereLamdba, bool isAsc, Expression<Func<M, S>> orderLamdba)
        {
            var list = this.context.Set<M>().Where<M>(whereLamdba);
            if (isAsc)
            {
                list = list.OrderBy<M, S>(orderLamdba);
            }
            else
            {
                list = list.OrderByDescending<M, S>(orderLamdba);
            }

            return MapperHelper.MapTo<T>(list);
        }

        public IList<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord, 
            Expression<Func<M, bool>> whereLamdba, bool isAsc, Expression<Func<M, S>> orderLamdba)
        {
            var list = this.context.Set<M>().Where<M>(whereLamdba);
            totalRecord = list.Count();

            if (isAsc)
            {
                list = list.OrderBy<M, S>(orderLamdba).Skip<M>((pageIndex - 1) * pageSize).Take<M>(pageSize);
            }
            else
            {
                list = list.OrderByDescending<M, S>(orderLamdba).Skip<M>((pageIndex - 1) * pageSize).Take<M>(pageSize);
            }

            return MapperHelper.MapTo<T>(list);
        }
    }
}
