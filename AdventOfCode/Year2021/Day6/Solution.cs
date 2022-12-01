using System;
using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2021.Day6
{
    public class Solution : BaseSolution<int[]>, ISolvable
    {
        private List<Fish> listOfFish = new();

        public Solution(IPuzzle puzzle) : base(puzzle, x => x.Trim('\n').Split(",").Select(int.Parse).ToArray())
        {
            foreach (var fish in Input)
            {
                listOfFish.Add(new Fish(fish));
            }
        }

        public string SolvePart1()
        {
            int days = 0;
            while (days < 80)
            {
                List<Fish> newFish = new();
                foreach (var fish in listOfFish)
                {
                    var spawn = fish.TrySpawn();
                    if (spawn != null)
                    {
                        newFish.Add(spawn);
                    }
                }

                if (newFish.Count > 0)
                {
                    listOfFish.AddRange(newFish);
                }

                days++;
            }

            return $"Part 1: {listOfFish.Count}";
        }

        public string SolvePart2()
        {
            throw new NotImplementedException();
        }
    }
}