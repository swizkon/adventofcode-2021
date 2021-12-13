using System;
using System.Linq;
using DotNetHelpers;

namespace AdventOfCode.Application.TheTreacheryOfWhales
{
    public static class CrabAligner
    {
        public static int CalculateCheapestPosition(string input)
        {
            // Brute...
            var numberSequence = input.Split(',').Select(int.Parse).ToList();
            var uniquePositions = numberSequence.Distinct();

            return uniquePositions
                .Select(uniquePosition => new
                    {
                        FuelConsumption = CalculateFuelConsumption(numberSequence.ToArray(), uniquePosition),
                        Position = uniquePosition
                    }
                )
                .OrderBy(x => x.FuelConsumption)
                .First()
                .FuelConsumption;
        }

        public static int CalculateFuelConsumption(int[] numberSequence, int horizontalPos)
        {
            // var numberSequence = input.Select(int.Parse).ToList();
            DebugOutput.Write(nameof(numberSequence), numberSequence);

            // Just sum the steps from
            return numberSequence.Select(n => Math.Abs(horizontalPos - n)).Sum();
        }
    }
}