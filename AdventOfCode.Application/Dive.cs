using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Application
{
    public static class Dive
    {
        class State
        {
            public int Horizontal { get; set; }
            public int Depth { get; set; }
            public int Aim { get; set; }
        }

        class Move
        {
            public Direction Direction { get; set; }
            public int Value { get; set; }
        }

        enum Direction
        {
            Forward,
            Up,
            Down
        }

        public static int FirstSolution(string[] input)
        {
            var moves = ParseMoves(input).ToList();
            
            var horizontal = moves.Where(m => m.Direction == Direction.Forward).Sum(m => m.Value);

            var depth = moves.Where(m => m.Direction == Direction.Down).Sum(m => m.Value)
                        - moves.Where(m => m.Direction == Direction.Up).Sum(m => m.Value);
            return horizontal * depth;
        }

        public static int SecondSolution(string[] input)
        {
            var state = new State();

            var moves = ParseMoves(input).ToList();
            foreach (var move in moves)
            {
                switch (move.Direction)
                {
                    case Direction.Up:
                        state.Aim -= move.Value;
                        break;
                    case Direction.Down:
                        state.Aim += move.Value;
                        break;
                    case Direction.Forward:
                        state.Horizontal += move.Value;
                        state.Depth += state.Aim * move.Value;
                        break;
                }
            }

            return state.Horizontal * state.Depth;
        }

        private static IEnumerable<Move> ParseMoves(IEnumerable<string> input)
        {
            foreach (var s in input)
            {
                var val = Convert.ToInt32(s.Substring(s.IndexOf(" ") + 1));
                if (s.StartsWith("up "))
                {
                    yield return new Move
                    {
                        Direction = Direction.Up,
                        Value = val
                    };
                }

                if (s.StartsWith("down "))
                {
                    yield return new Move
                    {
                        Direction = Direction.Down,
                        Value = val
                    };
                }

                if (s.StartsWith("forward "))
                {
                    yield return new Move
                    {
                        Direction = Direction.Forward,
                        Value = val
                    };
                }
            }
        }
    }
}