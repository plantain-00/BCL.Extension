using System;

namespace BCL.Extension
{
    /// <summary>
    ///     DateTime结构的扩展
    /// </summary>
    public static class DateTimeExtension
    {
        /// <summary>
        ///     Unix时间戳转换为DateTime
        /// </summary>
        /// <param name="secondsFrom19700101"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this int secondsFrom19700101)
        {
            return new DateTime(1970, 1, 1).AddSeconds(secondsFrom19700101);
        }
        /// <summary>
        ///     DateTime转换为Unix时间戳
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static int ToInt32(this DateTime dateTime)
        {
            return Convert.ToInt32((dateTime - new DateTime(1970, 1, 1)).TotalSeconds);
        }
    }
}