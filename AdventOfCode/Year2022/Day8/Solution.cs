using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day8
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            var grid = BuildGrid();
            DetermineVisibility(ref grid);
            return $"Part 1: {grid.Values.Count(t => t.Visible)}";
        }

        public string SolvePart2()
        {
            var grid = BuildGrid();
            var highestScenicScore = CalculateHighestScenicScore(grid);
            return $"Part 2: {highestScenicScore}";
        }

        public Dictionary<Point, Tree> BuildGrid()
        {
            Dictionary<Point, Tree> grid = new();
            for (int i = 0; i < Input.Length; i++)
            {
                for (int j = 0; j < Input[i].Length; j++)
                {
                    var tree = new Tree(int.Parse(Input[i][j].ToString()));
                    if (i == 0 || j == 0 || i == Input.Length - 1 || j == Input[i].Length - 1)
                    {
                        tree.SetVisibility(true);
                    }
                    grid.Add(new Point(i, j), tree);
                }
            }
            return grid;
        }

        // Have to do a second pass of the grid so we have the tree objects.
        public void DetermineVisibility(ref Dictionary<Point, Tree> grid)
        {
            // i = 1 and i < Input.Length - 1 is a micro optimization, since we already set the edges to visible.
            for (int i = 1; i < Input.Length - 1; i++)
            {
                // j = 1 and j < Input[i].Length - 1 is a micro optimization, since we already set the edges to visible.
                for (int j = 1; j < Input[i].Length - 1; j++)
                {
                    var tree = grid[new Point(i, j)];

                    // Look up
                    bool visibleFromTop = true;
                    for (int x = i - 1; x >= 0; x--)
                    {
                        visibleFromTop = visibleFromTop && grid[new Point(x, j)].Height < tree.Height;
                    }

                    // Look down
                    bool visibleFromBottom = true;
                    for (int x = i + 1; x < Input.Length; x++)
                    {
                        visibleFromBottom = visibleFromBottom && grid[new Point(x, j)].Height < tree.Height;
                    }

                    // Look left
                    bool visibleFromLeft = true;
                    for (int y = j - 1; y >= 0; y--)
                    {
                        visibleFromLeft = visibleFromLeft && grid[new Point(i, y)].Height < tree.Height;
                    }

                    // Look right
                    bool visibleFromRight = true;
                    for (int y = j + 1; y < Input[i].Length; y++)
                    {
                        visibleFromRight = visibleFromRight && grid[new Point(i, y)].Height < tree.Height;
                    }

                    // If the tree is visible from any direction, mark it visible.
                    tree.SetVisibility(visibleFromTop || visibleFromBottom || visibleFromLeft || visibleFromRight);
                }
            }
        }

        public int CalculateHighestScenicScore(Dictionary<Point, Tree> grid)
        {
            int highestScenicScore = -1;
            for (int i = 0; i < Input.Length; i++)
            {
                for (int j = 0; j < Input[i].Length; j++)
                {
                    var tree = grid[new Point(i, j)];

                    // Look up
                    int topScenicScore = 0;
                    int xTop = i - 1;
                    bool topViewBlocked = false;
                    while (xTop >= 0 && !topViewBlocked)
                    {
                        var nextTree = grid[new Point(xTop, j)];
                        topScenicScore++;

                        topViewBlocked = nextTree.Height >= tree.Height;
                        xTop--;
                    }

                    // Look down
                    int bottomScenicScore = 0;
                    int xBottom = i + 1;
                    bool bottomViewBlocked = false;
                    while (xBottom < Input.Length && !bottomViewBlocked)
                    {
                        var nextTree = grid[new Point(xBottom, j)];
                        bottomScenicScore++;

                        bottomViewBlocked = nextTree.Height >= tree.Height;
                        xBottom++;
                    }

                    // Look left
                    int leftScenicScore = 0;
                    int yLeft = j - 1;
                    bool leftViewBlocked = false;
                    while (yLeft >= 0 && !leftViewBlocked)
                    {
                        var nextTree = grid[new Point(i, yLeft)];
                        leftScenicScore++;

                        leftViewBlocked = nextTree.Height >= tree.Height;
                        yLeft--;
                    }

                    // Look right
                    int rightScenicScore = 0;
                    int yRight = j + 1;
                    bool rightViewBlocked = false;
                    while (yRight < Input.Length && !rightViewBlocked)
                    {
                        var nextTree = grid[new Point(i, yRight)];
                        rightScenicScore++;

                        rightViewBlocked = nextTree.Height >= tree.Height;
                        yRight++;
                    }

                    int scenicScore = topScenicScore * leftScenicScore * bottomScenicScore * rightScenicScore;
                    if (scenicScore > highestScenicScore)
                    {
                        highestScenicScore = scenicScore;
                    }
                }
            }

            return highestScenicScore;
        }
    }

    public class Tree
    {
        public int Height { get; }
        public bool Visible { get; private set; }

        public Tree(int height)
        {
            Height = height;
        }

        public void SetVisibility(bool visible)
        {
            Visible = visible;
        }
    }
}