using System;
using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day5
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        private const int CHUNK_SIZE = 4;

        private readonly Dictionary<int, Stack<string>> Stacks = new();
        private readonly List<string> Steps = new();

        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            PopulateStacksAndSteps();

            foreach (var step in Steps)
            {
                var stepParts = step.Split(' ');
                int moveAmount = int.Parse(stepParts[1]);
                int fromStack = int.Parse(stepParts[3]);
                int toStack = int.Parse(stepParts[5]);

                for (int i = 0; i < moveAmount; i++)
                {
                    if (Stacks[fromStack].TryPop(out var crate))
                    {
                        Stacks[toStack].Push(crate);
                    }
                }
            }
            return $"Part 1: {string.Join(null, Stacks.AsEnumerable().Select(s => s.Value.Peek()))}";
        }

        public string SolvePart2()
        {
            PopulateStacksAndSteps();

            foreach (var step in Steps)
            {
                var stepParts = step.Split(' ');
                int moveAmount = int.Parse(stepParts[1]);
                int fromStack = int.Parse(stepParts[3]);
                int toStack = int.Parse(stepParts[5]);

                Stack<string> tempStack = new();
                for (int i = 0; i < moveAmount; i++)
                {
                    if (Stacks[fromStack].TryPop(out var crate))
                    {
                        tempStack.Push(crate);
                    }
                }

                foreach (var crate in tempStack)
                {
                    Stacks[toStack].Push(crate);
                }
            }

            return $"Part 2: {string.Join(null, Stacks.AsEnumerable().Select(s => s.Value.Peek()))}";
        }

        private void PopulateStacksAndSteps()
        {
            Stacks.Clear();
            Steps.Clear();

            var divider = Array.FindIndex(Input, 0, line => string.IsNullOrWhiteSpace(line));
            for (int i = divider - 2; i >= 0; i--)
            {
                // Cheat's rounding
                int crateCount = (Input[i].Length + CHUNK_SIZE - 1) / CHUNK_SIZE;
                // Add an extra space to make the line length even.
                var crates = Enumerable.Range(0, crateCount).Select(j => (Input[i] + " ").Substring(j * CHUNK_SIZE, CHUNK_SIZE)).ToList();
                if (Stacks.Count == 0)
                {
                    for (int j = 0; j < crates.Count; j++)
                    {
                        var stack = new Stack<string>();
                        stack.Push(crates[j].Trim().Replace("[", string.Empty).Replace("]", string.Empty));
                        Stacks.Add(j + 1, stack); // j + 1 so it matches the indexing in the instructions
                    }
                }
                else
                {
                    for (int j = 0; j < Stacks.Count; j++)
                    {
                        if (!string.IsNullOrWhiteSpace(crates[j]))
                        {
                            Stacks[j + 1].Push(crates[j].Trim().Replace("[", string.Empty).Replace("]", string.Empty)); // j + 1 so it matches the indexing in the instructions
                        }
                    }
                }
            }

            foreach (var line in Input.Skip(divider + 1))
            {
                Steps.Add(line);
            }
        }
    }
}