using System;
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

        public static int FirstSolution(string[] input)
        {
            var horizontal = input
                .Where(x => x.StartsWith("forward "))
                .Select(x => Convert.ToInt32(x.Substring("forward ".Length)))
                .Sum();

            var depth = input
                            .Where(x => x.StartsWith("up "))
                            .Select(x => -Convert.ToInt32(x.Substring("up ".Length)))
                            .Sum()
                        + input
                            .Where(x => x.StartsWith("down "))
                            .Select(x => Convert.ToInt32(x.Substring("down ".Length)))
                            .Sum();

            return horizontal * depth;
        }

        public static int SecondSolution(string[] input)
        {
            var state = new State();
            foreach (var s in input)
            {
                if (s.StartsWith("up "))
                {
                    state.Aim -= Convert.ToInt32(s.Substring("up ".Length));
                }

                if (s.StartsWith("down "))
                {
                    state.Aim += Convert.ToInt32(s.Substring("down ".Length));
                }

                if (s.StartsWith("forward "))
                {
                    state.Horizontal += Convert.ToInt32(s.Substring("forward ".Length));
                    state.Depth += state.Aim * Convert.ToInt32(s.Substring("forward ".Length));
                }
            }

            return state.Horizontal * state.Depth;
        }
    }
}