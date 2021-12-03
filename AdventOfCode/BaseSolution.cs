using System;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode
{
    public abstract class BaseSolution<T>
    {
        public static readonly Func<string, int[]> IntArraySelector = x => x.Trim('\n').Split("\n").Select(int.Parse).ToArray();
        public static readonly Func<string, string[]> StringArraySelector = x => x.Trim('\n').Split("\n");

        protected T Input { get; }

        protected BaseSolution(IPuzzle puzzle, Func<string, T> inputSelector) =>
            Input = inputSelector(puzzle.GetInputAsync().Result);
    }
}