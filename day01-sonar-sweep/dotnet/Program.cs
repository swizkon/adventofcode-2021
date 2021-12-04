using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode.Application;
using DotNetHelpers;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(Program).Namespace);

            var input = InputReader.GetInput(Environment.CurrentDirectory);

            Console.WriteLine("FirstSolution");
            Console.WriteLine(SonarSweep.FirstSolution(input));

            Console.WriteLine("");

            Console.WriteLine("SecondSolution");
            Console.WriteLine(SonarSweep.SecondSolution(input));
        }
    }
}