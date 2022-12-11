using System;
using System.Collections.Generic;
using System.Drawing;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day9
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            Dictionary<Point, int> VisitCounts = new()
            {
                { new Point(0, 0), 1 }
            };

            Point currentHeadPosition = new(0, 0);
            Point currentTailPosition = new(0, 0);
            foreach (var movement in Input)
            {
                var moveParts = movement.Split(' ');
                var direction = moveParts[0];
                var distance = int.Parse(moveParts[1]);

                var step = 0;
                while (step < distance)
                {
                    _ = direction switch
                    {
                        "U" => currentHeadPosition.Y++,
                        "D" => currentHeadPosition.Y--,
                        "L" => currentHeadPosition.X--,
                        "R" => currentHeadPosition.X++,
                        _ => throw new ArgumentOutOfRangeException($"'{direction}' is not valid")
                    };

                    if (Distance(currentHeadPosition, currentTailPosition) > 1)
                    {
                        if (currentHeadPosition.X > currentTailPosition.X && currentHeadPosition.Y > currentTailPosition.Y)
                        {
                            // Diagonal up & right
                            currentTailPosition.X++;
                            currentTailPosition.Y++;
                        }
                        else if (currentHeadPosition.X > currentTailPosition.X && currentHeadPosition.Y < currentTailPosition.Y)
                        {
                            // Diagonal down & right
                            currentTailPosition.X++;
                            currentTailPosition.Y--;
                        }
                        else if (currentHeadPosition.X < currentTailPosition.X && currentHeadPosition.Y < currentTailPosition.Y)
                        {
                            // Diagonal down & left
                            currentTailPosition.X--;
                            currentTailPosition.Y--;
                        }
                        else if (currentHeadPosition.X < currentTailPosition.X && currentHeadPosition.Y > currentTailPosition.Y)
                        {
                            // Diagonal up & left
                            currentTailPosition.X--;
                            currentTailPosition.Y++;
                        }
                        else if (currentHeadPosition.X > currentTailPosition.X)
                        {
                            // Right
                            currentTailPosition.X++;
                        }
                        else if (currentHeadPosition.Y > currentTailPosition.Y)
                        {
                            // Up
                            currentTailPosition.Y++;
                        }
                        else if (currentHeadPosition.X < currentTailPosition.X)
                        {
                            // Left
                            currentTailPosition.X--;
                        }
                        else if (currentHeadPosition.Y < currentTailPosition.Y)
                        {
                            // Down
                            currentTailPosition.Y--;
                        }

                        if (VisitCounts.ContainsKey(currentTailPosition))
                        {
                            VisitCounts[currentTailPosition]++;
                        }
                        else
                        {
                            VisitCounts.Add(currentTailPosition, 1);
                        }
                    }

                    step++;
                }
            }
            return $"Part 1: {VisitCounts.Count}";
        }

        public string SolvePart2()
        {
            Dictionary<Point, int> VisitCounts = new()
            {
                { new Point(0, 0), 1 }
            };

            Point[] knotPositions = new Point[10];
            Array.Fill(knotPositions, new(0, 0));

            foreach (var movement in Input)
            {
                var moveParts = movement.Split(' ');
                var direction = moveParts[0];
                var distance = int.Parse(moveParts[1]);

                var step = 0;
                while (step < distance)
                {
                    _ = direction switch
                    {
                        "U" => knotPositions[0].Y++,
                        "D" => knotPositions[0].Y--,
                        "L" => knotPositions[0].X--,
                        "R" => knotPositions[0].X++,
                        _ => throw new ArgumentOutOfRangeException($"'{direction}' is not valid")
                    };

                    for (int i = 1; i < knotPositions.Length; i++)
                    {
                        if (Distance(knotPositions[i - 1], knotPositions[i]) > 1)
                        {
                            if (knotPositions[i - 1].X > knotPositions[i].X && knotPositions[i - 1].Y > knotPositions[i].Y)
                            {
                                // Diagonal up & right
                                knotPositions[i].X++;
                                knotPositions[i].Y++;
                            }
                            else if (knotPositions[i - 1].X > knotPositions[i].X && knotPositions[i - 1].Y < knotPositions[i].Y)
                            {
                                // Diagonal down & right
                                knotPositions[i].X++;
                                knotPositions[i].Y--;
                            }
                            else if (knotPositions[i - 1].X < knotPositions[i].X && knotPositions[i - 1].Y < knotPositions[i].Y)
                            {
                                // Diagonal down & left
                                knotPositions[i].X--;
                                knotPositions[i].Y--;
                            }
                            else if (knotPositions[i - 1].X < knotPositions[i].X && knotPositions[i - 1].Y > knotPositions[i].Y)
                            {
                                // Diagonal up & left
                                knotPositions[i].X--;
                                knotPositions[i].Y++;
                            }
                            else if (knotPositions[i - 1].X > knotPositions[i].X)
                            {
                                // Right
                                knotPositions[i].X++;
                            }
                            else if (knotPositions[i - 1].Y > knotPositions[i].Y)
                            {
                                // Up
                                knotPositions[i].Y++;
                            }
                            else if (knotPositions[i - 1].X < knotPositions[i].X)
                            {
                                // Left
                                knotPositions[i].X--;
                            }
                            else if (knotPositions[i - 1].Y < knotPositions[i].Y)
                            {
                                // Down
                                knotPositions[i].Y--;
                            }

                            if (i == knotPositions.Length - 1)
                            {
                                if (VisitCounts.ContainsKey(knotPositions[i]))
                                {
                                    VisitCounts[knotPositions[i]]++;
                                }
                                else
                                {
                                    VisitCounts.Add(knotPositions[i], 1);
                                }
                            }
                        }
                    }

                    step++;
                }
            }
            return $"Part 2: {VisitCounts.Count}";
        }

        public int Distance(Point point1, Point point2)
        {
            return (int)Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }
    }
}