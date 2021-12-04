using System;
using AdventOfCode.Application;
using DotNetHelpers;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(Program).Namespace);

            /*
            var input = InputReader.GetInput(Environment.CurrentDirectory, "input-day02.txt");
            Console.WriteLine("Day 1");
            Console.WriteLine("FirstSolution");
            Console.WriteLine(SonarSweep.FirstSolution(input));
            Console.WriteLine("SecondSolution");
            Console.WriteLine(SonarSweep.SecondSolution(input));
            */

            var input02 = InputReader.GetInput(Environment.CurrentDirectory, "input-day02.txt");
            Console.WriteLine("Day 2");
            Console.WriteLine("FirstSolution");
            Console.WriteLine(Dive.FirstSolution(input02));
            Console.WriteLine("SecondSolution");
            Console.WriteLine(Dive.SecondSolution(input02));
        }
    }
}