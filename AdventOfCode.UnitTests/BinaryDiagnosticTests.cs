using System;
using AdventOfCode.Application;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.UnitTests
{
    public class BinaryDiagnosticTests
    {
        [Fact]
        public void It_calculates_correct_power_consumption()
        {
            // Act
            var result = BinaryDiagnostic.GetPowerConsumption(TestData);

            // Assert
            result.Should().Be(198);
        }

        [Fact]
        public void It_calculates_correct_life_support_rating()
        {
            // Act
            var result = BinaryDiagnostic.GetLifeSupportRating(TestData);

            // Assert
            result.Should().Be(230);
        }

        private string[] TestData => new[]
        {
            "00100",
            "11110",
            "10110",
            "10111",
            "10101",
            "01111",
            "00111",
            "11100",
            "10000",
            "11001",
            "00010",
            "01010"
        };
    }
}
