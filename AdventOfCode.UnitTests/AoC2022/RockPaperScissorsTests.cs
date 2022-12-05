using System.Linq;
using AdventOfCode.Application.AoC2022.RockPaperScissors;
using FluentAssertions;
using Xunit;
using static AdventOfCode.Application.AoC2022.RockPaperScissors.RockPaperScissors;

namespace AdventOfCode.UnitTests.AoC2022
{
    public class RockPaperScissorsTests
    {
        [Fact]
        public void It_parses_shapes()
        {
            // Act
            var result = RockPaperScissors.ParseInput(TestData);

            // Assert
            result.First().OpponentShape.Should().Be(RockPaperScissors.Shape.Rock);
            result.First().MyShape.Should().Be(RockPaperScissors.Shape.Paper);

            result.Last().OpponentShape.Should().Be(RockPaperScissors.Shape.Scissors);
            result.Last().MyShape.Should().Be(RockPaperScissors.Shape.Scissors);
        }

        [Fact]
        public void It_parses_shapes_from_outcome()
        {
            // Act
            var result = RockPaperScissors.ParseInputWithOutcomeStrategy(TestData);

            // Assert
            result.First().OpponentShape.Should().Be(RockPaperScissors.Shape.Rock);
            result.First().MyShape.Should().Be(RockPaperScissors.Shape.Rock);

            result.ElementAt(1).OpponentShape.Should().Be(RockPaperScissors.Shape.Paper);
            result.ElementAt(1).MyShape.Should().Be(RockPaperScissors.Shape.Rock);

            result.Last().OpponentShape.Should().Be(RockPaperScissors.Shape.Scissors);
            result.Last().MyShape.Should().Be(RockPaperScissors.Shape.Rock);
        }
        
        [Fact]
        public void It_calculated_outcome()
        {
            // Arrange 
            var input = RockPaperScissors.ParseInput(TestData);

            // Act
            var result = RockPaperScissors.CalculateScoreAndOutcome(input);

            // Assert
            result.First().Outcome.Should().Be(Outcome.Win);
            result.ElementAt(1).Outcome.Should().Be(Outcome.Loss);
            result.ElementAt(2).Outcome.Should().Be(Outcome.Draw);
        }

        [Fact]
        public void It_calculates_score()
        {
            // Arrange 
            var input = RockPaperScissors.ParseInput(TestData);

            // Act
            var result = RockPaperScissors.CalculateScoreAndOutcome(input);

            // Assert
            result.First().Score.Should().Be(8);
            result.ElementAt(1).Score.Should().Be(1);
            result.ElementAt(2).Score.Should().Be(6);
        }


        [Fact]
        public void It_calculates_total_score()
        {
            // Arrange 
            var input = RockPaperScissors.ParseInput(TestData);

            // Act
            var result = RockPaperScissors.CalculateScoreAndOutcome(input);

            // Assert
            result.First().Score.Should().Be(8);
            result.ElementAt(1).Score.Should().Be(1);
            result.ElementAt(2).Score.Should().Be(6);
        }

        private string[] TestData => new[]
        {
            "A Y",
            "B X",
            "C Z"
        };
    }
}
