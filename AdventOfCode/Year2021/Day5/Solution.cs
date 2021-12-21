using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using NAoCHelper;

namespace AdventOfCode.Year2021.Day5
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            var dict = new Dictionary<string, int>();

            foreach (var line in Input)
            {
                var parts = line.Split(" -> ");
                var startParts = parts[0].Split(',').Select(int.Parse).ToArray();
                var endParts = parts[1].Split(',').Select(int.Parse).ToArray();
                var start = new Point(startParts[0], startParts[1]);
                var end = new Point(endParts[0], endParts[1]);

                // horizontal and vertical lines
                if (start.X == end.X || start.Y == end.Y)
                {
                    var xIncreasing = start.X < end.X;
                    for (int i = xIncreasing ? start.X : end.X; i <= (xIncreasing ? end.X : start.X); i++)
                    {
                        var yIncreasing = start.Y < end.Y;
                        for (int j = yIncreasing ? start.Y : end.Y; j <= (yIncreasing ? end.Y : start.Y); j++)
                        {
                            var point = $"{i},{j}";
                            if (dict.ContainsKey(point))
                            {
                                dict[point]++;
                            }
                            else
                            {
                                dict.Add(point, 1);
                            }
                        }
                    }
                }
            }

            var result = dict.Count(d => d.Value > 1);

            // 1322 is too low
            return $"Part 1: {result}.";
        }

        public string SolvePart2()
        {
            var dict = new Dictionary<string, int>();

            foreach (var line in Input)
            {
                var parts = line.Split(" -> ");
                var startParts = parts[0].Split(',').Select(int.Parse).ToArray();
                var endParts = parts[1].Split(',').Select(int.Parse).ToArray();
                var start = new Point(startParts[0], startParts[1]);
                var end = new Point(endParts[0], endParts[1]);

                // horizontal and vertical lines
                if (start.X == end.X || start.Y == end.Y)
                {
                    var xIncreasing = start.X < end.X;
                    for (int i = xIncreasing ? start.X : end.X; i <= (xIncreasing ? end.X : start.X); i++)
                    {
                        var yIncreasing = start.Y < end.Y;
                        for (int j = yIncreasing ? start.Y : end.Y; j <= (yIncreasing ? end.Y : start.Y); j++)
                        {
                            var point = $"{i},{j}";
                            if (dict.ContainsKey(point))
                            {
                                dict[point]++;
                            }
                            else
                            {
                                dict.Add(point, 1);
                            }
                        }
                    }
                }
                else
                {
                    // 45 degree lines
                    var xIncreasing = start.X < end.X;
                    var yIncreasing = start.Y < end.Y;

                    var currentX = start.X;
                    var currentY = start.Y;
                    var endPoint = new Point(end.X, end.Y);
                    var currentDistance = Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
                    while (currentDistance > 0)
                    {
                        // Do this first or we won't process the last point
                        currentDistance = Math.Sqrt(Math.Pow(end.X - currentX, 2) + Math.Pow(end.Y - currentY, 2));

                        var point = $"{currentX},{currentY}";
                        if (dict.ContainsKey(point))
                        {
                            dict[point]++;
                        }
                        else
                        {
                            dict.Add(point, 1);
                        }

                        var xModifier = xIncreasing ? 1 : -1;
                        currentX += xModifier;

                        var yModifier = yIncreasing ? 1 : -1;
                        currentY += yModifier;
                    }
                }
            }

            var result = dict.Count(d => d.Value > 1);

            // 19812 too high
            return $"Part 2: {result}.";
        }
    }
}