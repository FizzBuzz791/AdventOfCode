using System;
using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2024.Day1;

public class Solution(IPuzzle puzzle) : BaseSolution<string[]>(puzzle, StringArraySelector), ISolvable
{
    public Tuple<List<int>, List<int>> GetLists()
    {
        var listOne = new List<int>();
        var listTwo = new List<int>();

        foreach (var entry in Input)
        {
            var parts = entry.Split("   ");
            listOne.Add(int.Parse(parts[0]));
            listTwo.Add(int.Parse(parts[1]));
        }

        return new Tuple<List<int>, List<int>>(listOne, listTwo);
    }

    public string SolvePart1()
    {
        var (listOne, listTwo) = GetLists();

        listOne.Sort();
        listTwo.Sort();

        var sumOfDistances = 0;
        for (int i = 0; i < listOne.Count; i++)
        {
            sumOfDistances += Math.Abs(listOne[i] - listTwo[i]);
        }

        return $"Part 1: {sumOfDistances}";
    }

    public string SolvePart2()
    {
        var (listOne, listTwo) = GetLists();

        var sumOfSimilarities = 0;
        foreach (var item in listOne)
        {
            sumOfSimilarities += item * listTwo.Count(i => i == item);
        }

        return $"Part 2: {sumOfSimilarities}";
    }
}
