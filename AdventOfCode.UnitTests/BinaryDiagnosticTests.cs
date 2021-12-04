using System;
using AdventOfCode.Application;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.UnitTests
{
    public class BinaryDiagnosticTests
    {
        [Fact]
        public void WhenGettingTestDaTa_ITDoesCorrectParsing()
        {
            // Act
            var result = BinaryDiagnostic.FirstSolution(TestData);

            // Assert
            result.Should().Be(198);
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
