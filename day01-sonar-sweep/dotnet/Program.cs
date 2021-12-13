using System;
using System.Linq;
using AdventOfCode.Application;
using AdventOfCode.Application.TheTreacheryOfWhales;
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
            Console.WriteLine("GetPowerConsumption");
            Console.WriteLine(SonarSweep.GetPowerConsumption(input));
            Console.WriteLine("SecondSolution");
            Console.WriteLine(SonarSweep.SecondSolution(input));
            */

            /*
            var input02 = InputReader.GetInput(Environment.CurrentDirectory, "input-day02.txt");
            Console.WriteLine("Day 2");
            Console.WriteLine("GetPowerConsumption");
            Console.WriteLine(Dive.GetPowerConsumption(input02));
            Console.WriteLine("SecondSolution");
            Console.WriteLine(Dive.SecondSolution(input02));
            */

            /*
            var input03 = InputReader.GetInput(Environment.CurrentDirectory, "input-day03.txt");
            Console.WriteLine("Day 3");
            Console.WriteLine("GetPowerConsumption");
            Console.WriteLine(BinaryDiagnostic.GetPowerConsumption(input03));

            Console.WriteLine("GetLifeSupportRating");
            Console.WriteLine(BinaryDiagnostic.GetLifeSupportRating(input03));
            */


            var input07 = InputReader.GetInput(Environment.CurrentDirectory, "input-day07.txt");
            Console.WriteLine("Day 7");
            Console.WriteLine("CalculateCheapestPosition");
            Console.WriteLine(CrabAligner.CalculateCheapestPosition(input07.First()));
        }
    }
}