using System;

namespace BCL.Extension
{
    /// <summary>
    ///     Exception类的扩展
    /// </summary>
    public static class ExceptionExtension
    {
        /// <summary>
        ///     否则抛出异常
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <exception cref="Exception"></exception>
        public static void OrThrow(this bool condition, string message = null)
        {
            if (!condition)
            {
                throw new Exception(message ?? "");
            }
        }
        /// <summary>
        ///     则抛出异常
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <exception cref="Exception"></exception>
        public static void ThenThrow(this bool condition, string message = null)
        {
            if (condition)
            {
                throw new Exception(message ?? "");
            }
        }
        /// <summary>
        ///     否则抛出异常
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void OrThrowArgument(this bool condition, string message = null)
        {
            if (!condition)
            {
                throw new ArgumentException(message ?? "");
            }
        }
        /// <summary>
        ///     则抛出异常
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void ThenThrowArgument(this bool condition, string message = null)
        {
            if (condition)
            {
                throw new ArgumentException(message ?? "");
            }
        }
        /// <summary>
        ///     如果condition为null，则抛出参数为空异常
        /// </summary>
        /// <param name="argument"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void IsNullThenThrow(this object argument)
        {
            if (argument == null)
            {
                throw new ArgumentNullException("argument");
            }
        }
    }
}