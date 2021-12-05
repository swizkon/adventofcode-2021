using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Application
{

    // https://adventofcode.com/2021/day/4

    public static class GiantSquid
    {
        public static int GetWinningBoard(string[] input)
        {
            var numberSequence = input.First().Split(',');


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
                    bits[j] += Scale[value[j]];
                }
            }

            var gammaRate = ReadBinaryStringToInt(new string(bits.Values.Select(v => v >= 0 ? '1' : '0').ToArray()));
            var epsilonRate = ReadBinaryStringToInt(new string(bits.Values.Select(v => v < 0 ? '1' : '0').ToArray()));

            return gammaRate * epsilonRate;
        }

        public static int GetLifeSupportRating(string[] input)
        {
            var values = input.GroupBy(s => s.Length)
                .Single()
                .ToList();

            var oxygenGeneratorRating = ReadBinaryStringToInt(GetOxygenGeneratorRating(values, 0, values.First().Length));


            var co2ScrubberRating = GetCo2ScrubberRating(values, 0, values.First().Length);

            return oxygenGeneratorRating * ReadBinaryStringToInt(co2ScrubberRating);
        }

        private static string GetOxygenGeneratorRating(List<string> values, int charIndex, int maxIndex)
        {
            if (values.Count <= 1)
                return values.SingleOrDefault() ?? "";

            if (charIndex >= maxIndex)
                return "";

            // Find most common and make recursive call...
            var charIndexVal = values.Sum(value => Scale[value[charIndex]]);

            var filtered = values.Where(v => charIndexVal >= 0 ? v[charIndex] == '1' : v[charIndex] == '0');
            return GetOxygenGeneratorRating(filtered.ToList(), charIndex + 1, maxIndex);
        }

        private static string GetCo2ScrubberRating(List<string> values, int charIndex, int maxIndex)
        {
            if (values.Count <= 1)
                return values.SingleOrDefault() ?? "";

            if (charIndex >= maxIndex)
                return "";

            var charIndexVal = values.Sum(value => Scale[value[charIndex]]);

            var filtered = values.Where(v => charIndexVal < 0 ? v[charIndex] == '1' : v[charIndex] == '0');
            return GetCo2ScrubberRating(filtered.ToList(), charIndex + 1, maxIndex);
        }

        static readonly IDictionary<char, int> Scale = new Dictionary<char, int>
        {
            {'1', 1},
            {'0', -1}
        };

        private static int ReadBinaryStringToInt(string binary)
        {
            var values = new int[32];
            values[0] = 1;
            for (var i = 1; i < values.Length; i++)
            {
                values[i] = values[i - 1] * 2;
            }

            return binary
                .Reverse()
                .Select(delegate (char c, int i)
                {
                    var on = c == '1';
                    return on ? values[i] : 0;
                })
                .Sum();
        }
    }
}