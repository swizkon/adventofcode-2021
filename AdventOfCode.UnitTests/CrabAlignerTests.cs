using System.Linq;
using AdventOfCode.Application;
using AdventOfCode.Application.TheTreacheryOfWhales;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.UnitTests
{
    public class CrabAlignerTests
    {
        [Theory]
        [InlineData(1, 41)]
        [InlineData(2, 37)]
        [InlineData(3, 39)]
        [InlineData(10, 71)]
        public void It_calculates_correct_fuel_consumption(int horizontalPos, int expectedFuelConsumption)
        {
            // Act
            var result = CrabAligner.CalculateFuelConsumption(TestData.Split(',').Select(int.Parse).ToArray(), horizontalPos);

            // Assert
            result.Should().Be(expectedFuelConsumption);
        }


        [Fact]
        public void It_calculates_cheapest_fuel_consumption()
        {
            // Act
            var result = CrabAligner.CalculateCheapestPosition(TestData);

            // Assert
            result.Should().Be(37);
        }

        private string TestData => "16,1,2,0,4,2,7,1,2,14";
    }
}