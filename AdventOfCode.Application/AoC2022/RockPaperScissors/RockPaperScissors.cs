using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Application.AoC2022.RockPaperScissors
{
    public static class RockPaperScissors
    {
        public class Round
        {
            public ShapeSelection Shapes { get; set; }
            public Outcome Outcome { get; set; }
            public int Score { get; set; }
        }

        public class ShapeSelection
        {
            public Shape OpponentShape { get; set; }
            public Shape MyShape { get; set; }
        }

        public enum Shape
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }

        public enum Outcome
        {
            Unknown = -1,
            Win = 6,
            Loss = 0,
            Draw = 3
        }

        private static IEnumerable<ShapeSelection> ParseShapes(IEnumerable<string> input)
        {
            return from s in input
                let opp = s[0]
                let oppMove = opp == 'A' ? Shape.Rock
                    : opp == 'B' ? Shape.Paper
                    : Shape.Scissors
                let my = s[2]
                let myShape = my == 'X' ? Shape.Rock
                    : my == 'Y' ? Shape.Paper
                    : Shape.Scissors
                select new ShapeSelection
                {
                    OpponentShape = oppMove,
                    MyShape = myShape
                };
        }

        private static IEnumerable<ShapeSelection> ParseShapesWithOutcomeStrategy(IEnumerable<string> input)
        {
            foreach (var s in input)
            {
                var opp = s[0];
                var oppMove = opp == 'A' ? Shape.Rock
                    : opp == 'B' ? Shape.Paper
                    : Shape.Scissors;

                var outcome = s[2];
                
                var myShape = Shape.Paper;

                switch (outcome)
                {
                    case 'Y':
                        myShape = oppMove;
                        break;
                    case 'X' when oppMove == Shape.Rock:
                        myShape = Shape.Scissors;
                        break;
                    case 'X' when oppMove == Shape.Scissors:
                        myShape = Shape.Paper;
                        break;
                    case 'X' when oppMove == Shape.Paper:
                        myShape = Shape.Rock;
                        break;
                    case 'Z' when oppMove == Shape.Rock:
                        myShape = Shape.Paper;
                        break;
                    case 'Z' when oppMove == Shape.Scissors:
                        myShape = Shape.Rock;
                        break;
                    case 'Z' when oppMove == Shape.Paper:
                        myShape = Shape.Scissors;
                        break;
                }

                yield return new ShapeSelection
                {
                    OpponentShape = oppMove,
                    MyShape = myShape
                };
            }
        }

        public static List<ShapeSelection> ParseInput(string[] input)
            => ParseShapes(input).ToList();
        
        public static List<ShapeSelection> ParseInputWithOutcomeStrategy(string[] input)
            => ParseShapesWithOutcomeStrategy(input).ToList();

        public static List<Round> CalculateScoreAndOutcome(List<ShapeSelection> input)
        {
            return input.Select(x =>
            {
                var outcome = GetOutcome(x);
                return new Round
                {
                    Shapes = x,
                    Outcome = outcome,
                    Score = GetScore(outcome, x.MyShape)
                };
            }).ToList();
        }

        private static int GetScore(Outcome outcome, Shape myShape)
        {
            return (int) outcome + (int)myShape;
        }

        private static Outcome GetOutcome(ShapeSelection shapes)
        {
            if (shapes.OpponentShape == shapes.MyShape)
                return Outcome.Draw;

            switch (shapes.OpponentShape)
            {
                case Shape.Paper when shapes.MyShape == Shape.Rock:
                case Shape.Scissors when shapes.MyShape == Shape.Paper:
                case Shape.Rock when shapes.MyShape == Shape.Scissors:
                    return Outcome.Loss;
                default:
                    return Outcome.Win;
            }
        }
    }
}