using System;
using NAoCHelper;

namespace AdventOfCode
{
    public abstract class BaseSolution<T>
    {
        protected T Input { get; }

        protected BaseSolution(IPuzzle puzzle, Func<string, T> inputSelector) =>
            Input = inputSelector(puzzle.GetInputAsync().Result);
    }
}