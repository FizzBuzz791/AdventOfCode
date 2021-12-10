using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2021.Day4
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            int[] numbers = Input[0].Split(',').Select(int.Parse).ToArray();

            List<Board> boards = new();

            int rowCounter = 1;
            while (rowCounter < Input.Length)
            {
                if (string.IsNullOrWhiteSpace(Input[rowCounter]))
                {
                    boards.Add(new());
                    rowCounter++;
                }
                else
                {
                    for (int row = 0; row < 5; row++)
                    {
                        for (int column = 0; column < 5; column++)
                        {
                            int[] rowOfValues = Input[rowCounter + row].Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries).Select(int.Parse).ToArray();
                            boards.Last().Squares.Add(new(new(row, column), rowOfValues[column]));
                        }
                    }
                    rowCounter += 5;
                }
            }

            int winningScore = 0;
            int counter = 0;
            while (winningScore == 0 && counter < numbers.Length)
            {
                foreach (Board board in boards)
                {
                    board.Play(numbers[counter]);

                    if (board.HasBingo())
                    {
                        Console.WriteLine($"Bingo!\n{board}");
                        winningScore = board.GetScore(numbers[counter]);
                        break;
                    }
                }
                counter++;
            }

            return $"Part 1: {winningScore}.";
        }

        public string SolvePart2()
        {
            return $"Part 2: Not yet solved.";
        }
    }

    public class Board
    {
        public List<Square> Squares = new();

        public void Play(int number)
        {
            Square? matchingSquare = Squares.FirstOrDefault(s => s.Value == number);
            if (matchingSquare != null)
            {
                matchingSquare.Matched = true;
            }
        }

        public bool HasBingo()
        {
            for (int row = 0; row < 5; row++)
            {
                if (Squares.Where(s => s.Position.X == row).All(s => s.Matched))
                {
                    return true;
                }
            }

            for (int column = 0; column < 5; column++)
            {
                if (Squares.Where(s => s.Position.Y == column).All(s => s.Matched))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetScore(int number)
        {
            return Squares.Where(s => !s.Matched).Sum(s => s.Value) * number;
        }

        public override string ToString()
        {
            string result = "";
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    Square square = Squares.First(s => s.Position.X == row && s.Position.Y == column);
                    result += (square.Matched ? $"*{square.Value}*" : square.Value) + " ";
                }
                result += "\n";
            }
            return result;
        }
    }

    public class Square
    {
        public Point Position { get; set; }
        public int Value { get; }
        public bool Matched { get; set; }

        public Square(Point position, int value)
        {
            Position = position;
            Value = value;
            Matched = false;
        }
    }
}