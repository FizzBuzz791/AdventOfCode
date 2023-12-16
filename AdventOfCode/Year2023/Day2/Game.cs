using System;

namespace AdventOfCode.Year2023.Day2
{
    public class Game(int gameId)
    {
        public int GameId { get; } = gameId;

        public int MaxBlue { get; private set; } = 0;

        public int MaxRed { get; private set; } = 0;

        public int MaxGreen { get; private set; } = 0;

        public void DetermineMaximums(string[] previews)
        {
            foreach (var preview in previews)
            {
                var colours = preview.Trim().Split(", ");
                foreach (var colour in colours)
                {
                    var parts = colour.Split(" ");
                    if (int.TryParse(parts[0], out var cubeCount))
                    {
                        switch (parts[1])
                        {
                            case "blue":
                                MaxBlue = Math.Max(cubeCount, MaxBlue);
                                break;
                            case "red":
                                MaxRed = Math.Max(cubeCount, MaxRed);
                                break;
                            case "green":
                                MaxGreen = Math.Max(cubeCount, MaxGreen);
                                break;
                        }
                    }
                }
            }
        }
    }
}