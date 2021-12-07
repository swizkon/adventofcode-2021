using System;
using System.Collections.Generic;

namespace DotNetHelpers
{
    public class DebugOutput
    {
        public static void Write<T>(string desc, IEnumerable<T> data)
        {
            Console.WriteLine("");
            Console.WriteLine(desc);
            Console.WriteLine(string.Join(", ", data));
        }

        public static void Write<T>(string desc, T data)
        {
            Console.WriteLine("");
            Console.WriteLine(desc);
            Console.WriteLine( data);
        }
    }
}