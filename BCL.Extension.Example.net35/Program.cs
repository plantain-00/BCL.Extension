using System;

namespace BCL.Extension.Example.net35
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            (args.Length == 0).OrThrow();
            args.Length.IsNullThenThrow();
            var time = DateTime.Now.ToInt32();
        }
    }
}