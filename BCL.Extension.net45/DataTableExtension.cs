using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace BCL.Extension
{
    /// <summary>
    ///     DataTable类的扩展
    /// </summary>
    public static class DataTableExtension
    {
        /// <summary>
        ///     转换为List泛型
        /// </summary>
        /// <param name="dt"></param>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static List<TResult> ToList<TResult>(this DataTable dt) where TResult : class, new()
        {
            var prlist = new List<PropertyInfo>();
            var t = typeof (TResult);
            Array.ForEach(t.GetProperties(),
                          p =>
                          {
                              if (dt.Columns.IndexOf(p.Name) != -1)
                              {
                                  prlist.Add(p);
                              }
                          });
            var result = new List<TResult>();
            foreach (DataRow row in dt.Rows)
            {
                var ob = new TResult();
                prlist.ForEach(p =>
                               {
                                   if (row[p.Name] != DBNull.Value)
                                   {
                                       p.SetValue(ob, row[p.Name], null);
                                   }
                               });
                result.Add(ob);
            }
            return result;
        }
    }
}