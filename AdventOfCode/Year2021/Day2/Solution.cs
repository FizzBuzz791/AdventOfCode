using System;
using System.Drawing;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2021.Day2
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            var currentPosition = new Point(0, 0);

            foreach (var command in Input)
            {
                var commandParts = command.Split(' ');
                switch (commandParts[0])
                {
                    case "forward":
                        currentPosition.X += int.Parse(commandParts[1]);
                        break;
                    case "up":
                        currentPosition.Y -= int.Parse(commandParts[1]);
                        break;
                    case "down":
                        currentPosition.Y += int.Parse(commandParts[1]);
                        break;
                    default:
                        throw new NotImplementedException();
                };
            }

            return $"Part 1: ({currentPosition.X}, {currentPosition.Y}): {currentPosition.X * currentPosition.Y}";
        }

        public string SolvePart2()
        {
            var currentPosition = new Point(0, 0);
            var aim = 0;

            foreach (var command in Input)
            {
                var commandParts = command.Split(' ');
                switch (commandParts[0])
                {
                    case "forward":
                        currentPosition.X += int.Parse(commandParts[1]);
                        currentPosition.Y += int.Parse(commandParts[1]) * aim;
                        break;
                    case "up":
                        aim -= int.Parse(commandParts[1]);
                        break;
                    case "down":
                        aim += int.Parse(commandParts[1]);
                        break;
                    default:
                        throw new NotImplementedException();
                };
            }
            return $"Part 2: ({currentPosition.X}, {currentPosition.Y}): {currentPosition.X * currentPosition.Y}";
        }
    }
}