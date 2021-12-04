
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Application
{
    // https://adventofcode.com/2021/day/3

    public static class BinaryDiagnostic
    {
        public static int FirstSolution(string[] input)
        {
            var values = input.GroupBy(s => s.Length)
                .Single()
                .ToList();

            IDictionary<int, int> bits = new Dictionary<int, int>();
            for (var j = 0; j < input.First().Length; j++)
            {
                bits[j] = 0;
            }

            foreach (var value in values)
            {
                for (var j = 0; j < value.Length; j++)
                {
                    var val = value[j] == '1' ? 1 : -1;
                    bits[j] += val;
                }
            }

            var gammaString = new string(bits.Values.Select(v => v >= 0 ? '1' : '0').ToArray());
            Console.WriteLine(gammaString);

            var gammaRate = ReadBinaryStringToInt(gammaString);
            Console.WriteLine(gammaRate);

            var epsilonString = new string(bits.Values.Select(v => v < 0 ? '1' : '0').ToArray());
            Console.WriteLine(epsilonString);

            var epsilonRate = ReadBinaryStringToInt(epsilonString);
            Console.WriteLine(epsilonRate);

            return gammaRate * epsilonRate;
        }

        private static int ReadBinaryStringToInt(string binary)
        {
            int[] values = new int[32];
            values[0] = 1;
            for (var i = 1; i < values.Length; i++)
            {
                values[i] = values[i - 1] * 2;
            }
            // Rad every reversed pos as on/off and multiply...
            return binary
                .Reverse()
                .Select(delegate(char c, int i)
                {
                    var on = c == '1';
                    return on ? values[i] : 0;
                })
                .Sum();
        }
    }
}