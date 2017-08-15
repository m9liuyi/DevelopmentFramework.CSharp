using System;
using System.Linq;
using System.Linq.Expressions;

namespace CSharpDemo.DAL.Interface
{
    /// <summary>
    /// 接口基类
    /// </summary>
    /// <typeparam name="T">类型</typeparam>
    public interface IGenericRepository<T>
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">新增的对象</param>
        /// <returns></returns>
        T Add(T entity);

        /// <summary>
        /// 记录数
        /// </summary>
        /// <param name="predicate">where条件</param>
        /// <returns></returns>
        int Count(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">更新的对象</param>
        /// <returns></returns>
        T Update(T entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">删除的对象</param>
        /// <returns></returns>
        bool Delete(T entity);

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="anyLambda"></param>
        /// <returns></returns>
        bool Exist(Expression<Func<T, bool>> anyLambda);

        /// <summary>
        /// 查询数据
        /// </summary>
        T Find(Expression<Func<T, bool>> whereLambda);

        /// <summary>
        /// 查询数据列表
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <param name="whereLamdba"></param>
        /// <param name="isAsc">是否按升序排序</param>
        /// <param name="orderLamdba"></param>
        /// <returns></returns>
        IQueryable<T> FindList<S>(Expression<Func<T, bool>> whereLamdba, bool isAsc, Expression<Func<T, S>> orderLamdba);

        /// <summary>
        /// 查询分页数据列表
        /// </summary>
        IQueryable<T> FindPageList<S>(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba, bool isAsc, Expression<Func<T, S>> orderLamdba);
    }
}
