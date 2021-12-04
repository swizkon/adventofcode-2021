using System;
using System.Collections.Generic;
using System.Linq;
using DotNetHelpers;

namespace SonarSweep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(Program).Namespace);

            var input = InputReader.GetInput(Environment.CurrentDirectory);

            Console.WriteLine("FirstSolution");
            Console.WriteLine(FirstSolution(input));

            Console.WriteLine("");

            Console.WriteLine("SecondSolution");
            Console.WriteLine(SecondSolution(input));
        }

        private static int FirstSolution(string[] input)
        {
            return input
                    .Select(i => new
                    {
                        depth = Convert.ToInt32(i),
                        increases = 0
                    })
                    .Aggregate(new
                        {
                            depth = int.MaxValue,
                            increases = 0
                        },
                        (prev, next) =>
                            new
                            {
                                next.depth,
                                increases = prev.increases + (next.depth > prev.depth ? 1 : 0)
                            }, result => result.increases);
        }

        private static int SecondSolution(string[] input)
        {
            var threeMeasurementWindows = new List<int>();
            var depths = input.Select(i => Convert.ToInt32(i)).ToArray();
            for (var i = 2; i < depths.Length; i++)
            {
                threeMeasurementWindows.Add(depths[i-2] + depths[i-1] + depths[i]);
            }

            return threeMeasurementWindows
                .Select(i => new
                {
                    depth = Convert.ToInt32(i),
                    increases = 0
                })
                .Aggregate(new
                    {
                        depth = int.MaxValue,
                        increases = 0
                    },
                    (prev, next) =>
                        new
                        {
                            next.depth,
                            increases = prev.increases + (next.depth > prev.depth ? 1 : 0)
                        }, result => result.increases);
        }
    }
}