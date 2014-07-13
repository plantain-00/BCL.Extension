using System;
using System.Text;
#if !NET30 && !NET20 && !NET35
using System.Data.Entity.Validation;

#endif

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
#if NET30 || NET20
        public static void OrThrow(bool condition, string message = null)
#else
        public static void OrThrow(this bool condition, string message = null)
#endif
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
#if NET30 || NET20
        public static void ThenThrow(bool condition, string message = null)
#else
        public static void ThenThrow(this bool condition, string message = null)
#endif
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
#if NET30 || NET20
        public static void OrThrowArgument(bool condition, string message = null)
#else
        public static void OrThrowArgument(this bool condition, string message = null)
#endif
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
#if NET30 || NET20
        public static void ThenThrowArgument(bool condition, string message = null)
#else
        public static void ThenThrowArgument(this bool condition, string message = null)
#endif
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
#if NET30 || NET20
        public static void IsNullThenThrow(object argument)
#else
        public static void IsNullThenThrow(this object argument)
#endif
        {
            if (argument == null)
            {
                throw new ArgumentNullException("argument");
            }
        }
#if !NET30 && !NET20 && !NET35
        /// <summary>
        ///     异常的完整信息
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static string FullMessage(this Exception exception)
        {
            var result = new StringBuilder();
            while (exception != null)
            {
                if (exception is DbEntityValidationException)
                {
                    foreach (var error in (exception as DbEntityValidationException).EntityValidationErrors)
                    {
                        foreach (var validationError in error.ValidationErrors)
                        {
                            result.AppendLine(string.Format("{0}:{1}", validationError.PropertyName, validationError.ErrorMessage));
                        }
                    }
                }
                result.AppendLine(exception.Message);
                result.AppendLine(exception.StackTrace);
                exception = exception.InnerException;
            }
            return result.ToString();
        }
#endif
    }
}