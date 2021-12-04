using System;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using DotNetHelpers;

namespace SonarSweep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(typeof(Program).Namespace);

            var input = InputReader.GetInput(Environment.CurrentDirectory);

            var numberOfIncreases = FirstSolution(input);

            Console.WriteLine(numberOfIncreases);
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
                                increases = next.depth > prev.depth ? prev.increases + 1 : prev.increases
                            }, result => result.increases);
        }
    }
}