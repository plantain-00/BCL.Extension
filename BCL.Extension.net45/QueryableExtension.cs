using System;
using System.Linq;

namespace BCL.Extension
{
    /// <summary>
    ///     IQueryable的扩展
    /// </summary>
    public static class QueryableExtension
    {
        /// <summary>
        ///     按查询条件过滤
        /// </summary>
        /// <param name="set"></param>
        /// <param name="condition"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IQueryable<T> Choose<T>(this IQueryable<T> set, Func<IQueryable<T>, IQueryable<T>> condition)
        {
            return condition(set);
        }
    }
}