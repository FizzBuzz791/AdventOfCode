using System;
using System.Collections.Generic;
using System.Text;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day10
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            int signalStrength = 0;
            int currentCycle = 1;
            int xRegister = 1;
            List<int> interestingCycles = new() { 20, 60, 100, 140, 180, 220 };

            var instructions = Input.GetEnumerator();
            while (instructions.MoveNext())
            {
                var instruction = instructions.Current.ToString();
                if (!string.IsNullOrWhiteSpace(instruction))
                {
                    var instructionParts = instruction.Split(' ');
                    var operation = instructionParts[0];
                    var cyclesToProcess = operation switch
                    {
                        "noop" => 1,
                        "addx" => 2,
                        _ => throw new NotImplementedException($"'{operation}' is not currently supported.")
                    };

                    for (int i = 0; i < cyclesToProcess; i++)
                    {
                        currentCycle++;

                        // Operations only execute _at the end_ of the required cycles.
                        if (i == cyclesToProcess - 1)
                        {
                            if (operation == "addx")
                            {
                                xRegister += int.Parse(instructionParts[1]);
                            }
                        }

                        if (interestingCycles.Contains(currentCycle))
                        {
                            signalStrength += currentCycle * xRegister;
                        }
                    }
                }
            }

            return $"Part 1: {signalStrength}";
        }

        public string SolvePart2()
        {
            StringBuilder screen = new();

            int currentCycle = 1;
            int xRegister = 1;

            var instructions = Input.GetEnumerator();
            while (instructions.MoveNext())
            {
                var instruction = instructions.Current.ToString();
                if (!string.IsNullOrWhiteSpace(instruction))
                {
                    var instructionParts = instruction.Split(' ');
                    var operation = instructionParts[0];
                    var cyclesToProcess = operation switch
                    {
                        "noop" => 1,
                        "addx" => 2,
                        _ => throw new NotImplementedException($"'{operation}' is not currently supported.")
                    };

                    for (int i = 0; i < cyclesToProcess; i++)
                    {
                        // Draw pixel first, so we start at position 1.
                        if (CycleMatchesRegister(currentCycle, xRegister))
                        {
                            screen.Append('#');
                        }
                        else
                        {
                            screen.Append('.');
                        }

                        if (currentCycle % 40 == 0)
                        {
                            screen.AppendLine();
                        }

                        currentCycle++;

                        // Operations only execute _at the end_ of the required cycles.
                        if (i == cyclesToProcess - 1)
                        {
                            if (operation == "addx")
                            {
                                xRegister += int.Parse(instructionParts[1]);
                            }
                        }
                    }
                }
            }
            return $"Part 2: {Environment.NewLine}{screen}";
        }

        public bool CycleMatchesRegister(int cycle, int register)
        {
            var simplifiedCycle = cycle;
            if (40 < cycle && cycle <= 80)
            {
                simplifiedCycle = cycle - 40;
            }
            else if (80 < cycle && cycle <= 120)
            {
                simplifiedCycle = cycle - 80;
            }
            else if (120 < cycle && cycle <= 160)
            {
                simplifiedCycle = cycle - 120;
            }
            else if (160 < cycle && cycle <= 200)
            {
                simplifiedCycle = cycle - 160;
            }
            else if (200 < cycle && cycle <= 240)
            {
                simplifiedCycle = cycle - 200;
            }
            return simplifiedCycle == register || simplifiedCycle == register + 1 || simplifiedCycle == register + 2;
        }
    }
}