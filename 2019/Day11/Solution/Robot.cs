using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Day11
{
    public class Robot
    {
        private Point CurrentLocation { get; set; } = new Point(0, 0);
        private Direction CurrentDirection { get; set; } = Direction.Up;
        public Dictionary<Point, Color> PaintedPanels { get; set; } = new Dictionary<Point, Color>();
        private IntCodeMachine Brain { get; }

        public Robot(BigInteger[] memory)
        {
            Brain = new IntCodeMachine(memory);
        }

        public void Run()
        {
            do
            {
                if (PaintedPanels.ContainsKey(CurrentLocation))
                    Brain.InputValues.Enqueue((int)PaintedPanels[CurrentLocation]);
                else
                    Brain.InputValues.Enqueue((int)Color.Black);

                Brain.Execute(false);

                var panelColor = Enum.Parse<Color>(Brain.Outputs.ToArray()[Brain.Outputs.Count - 2]);
                if (PaintedPanels.ContainsKey(CurrentLocation))
                    PaintedPanels[CurrentLocation] = panelColor;
                else
                    PaintedPanels.Add(CurrentLocation, panelColor);

                if (Enum.TryParse<Turn>(Brain.Outputs.ToArray()[Brain.Outputs.Count - 1], out var turnDirection))
                    Move(turnDirection);
            } while (Brain.State == MachineState.Paused && !Brain.Outputs.Contains("Halt"));
        }

        private void Move(Turn direction)
        {
            // Turn
            switch (direction)
            {
                case Turn.Left:
                    switch (CurrentDirection)
                    {
                        case Direction.Up:
                            CurrentDirection = Direction.Left;
                            break;
                        case Direction.Left:
                            CurrentDirection = Direction.Down;
                            break;
                        case Direction.Down:
                            CurrentDirection = Direction.Right;
                            break;
                        case Direction.Right:
                            CurrentDirection = Direction.Up;
                            break;
                    }
                    break;
                case Turn.Right:
                    switch (CurrentDirection)
                    {
                        case Direction.Up:
                            CurrentDirection = Direction.Right;
                            break;
                        case Direction.Right:
                            CurrentDirection = Direction.Down;
                            break;
                        case Direction.Down:
                            CurrentDirection = Direction.Left;
                            break;
                        case Direction.Left:
                            CurrentDirection = Direction.Up;
                            break;
                    }
                    break;
            }

            // Move forward
            switch (CurrentDirection)
            {
                case Direction.Up:
                    CurrentLocation = new Point(CurrentLocation.X, CurrentLocation.Y - 1);
                    break;
                case Direction.Left:
                    CurrentLocation = new Point(CurrentLocation.X - 1, CurrentLocation.Y);
                    break;
                case Direction.Down:
                    CurrentLocation = new Point(CurrentLocation.X, CurrentLocation.Y + 1);
                    break;
                case Direction.Right:
                    CurrentLocation = new Point(CurrentLocation.X + 1, CurrentLocation.Y);
                    break;
            }
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public enum Turn
    {
        Left = 0,
        Right = 1
    }

    public enum Color
    {
        Black = 0,
        White = 1
    }
}