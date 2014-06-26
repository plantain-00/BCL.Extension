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
        public static void OrThrows(this bool condition, string message = null)
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
        public static void ThenThrows(this bool condition, string message = null)
        {
            if (condition)
            {
                throw new Exception(message ?? "");
            }
        }
        /// <summary>
        ///     如果condition为True，则抛出异常
        /// </summary>
        /// <param name="condition"></param>
        /// <exception cref="Exception"></exception>
        public static void ThrowIf(bool condition)
        {
            if (condition)
            {
                throw new Exception();
            }
        }
        /// <summary>
        ///     如果condition为True，则抛出异常
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <exception cref="Exception"></exception>
        public static void ThrowIf(bool condition, string message)
        {
            if (message == null)
            {
                throw new Exception("message");
            }
            if (condition)
            {
                throw new Exception(message);
            }
        }
        /// <summary>
        ///     如果condition为True，则抛出参数异常
        /// </summary>
        /// <param name="condition"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void ThrowIfArgument(bool condition)
        {
            if (condition)
            {
                throw new ArgumentException();
            }
        }
        /// <summary>
        ///     如果condition为True，则抛出参数异常
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="message"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void ThrowIfArgument(bool condition, string message)
        {
            if (message == null)
            {
                throw new ArgumentException("message");
            }
            if (condition)
            {
                throw new ArgumentException(message);
            }
        }
        /// <summary>
        ///     如果condition为null，则抛出参数为空异常
        /// </summary>
        /// <param name="condition"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void ThrowIfArgumentIsNull(this object condition)
        {
            if (condition == null)
            {
                throw new ArgumentNullException("condition");
            }
        }
    }
}