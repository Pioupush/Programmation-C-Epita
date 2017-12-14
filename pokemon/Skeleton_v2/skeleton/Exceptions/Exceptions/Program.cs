using System;

namespace Exceptions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            throw new MissingMethodException("This must be removed or placed " +
                                             "after all your tests");
        }
    }
}