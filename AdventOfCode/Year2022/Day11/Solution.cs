using System;
using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day11
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        private readonly List<Monkey> Monkeys = new();

        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {

        }

        public string SolvePart1()
        {
            ParseInput();
            Simulate(20, true, 1); // Common multiple doesn't matter here. Any value is fine.

            var mostActiveMonkeys = Monkeys.OrderByDescending(m => m.InspectionCount).Take(2).Select(m => m.InspectionCount).ToList();
            var monkeyOne = (uint)mostActiveMonkeys[0];
            var monkeyTwo = (uint)mostActiveMonkeys[1];

            return $"Part 1: {monkeyOne * monkeyTwo}";
        }

        public string SolvePart2()
        {
            ParseInput();
            var commonMultiple = (uint)Monkeys.Select(m => m.Divisor).Aggregate((oldVal, newVal) => checked(oldVal * newVal));
            Simulate(10000, false, commonMultiple);

            var mostActiveMonkeys = Monkeys.OrderByDescending(m => m.InspectionCount).Take(2).Select(m => m.InspectionCount).ToList();
            var monkeyOne = (ulong)mostActiveMonkeys[0];
            var monkeyTwo = (ulong)mostActiveMonkeys[1];

            // 234624232 is too low
            return $"Part 2: {checked(monkeyOne * monkeyTwo)}";
        }

        public void ParseInput()
        {
            Monkeys.Clear();

            for (int i = 0; i <= Input.Length / 7; i++)
            {
                var monkey = Input.Skip(i * 7).Take(7).ToList();
                int id = int.Parse(monkey[0].Trim(':').Split(' ')[1]);
                var items = monkey[1].Split(':')[1].Split(',').Select(i => (uint)int.Parse(i)).ToList();

                var operation = monkey[2].Split(':')[1].Split('=')[1].Trim().Split(' ');
                var firstPart = operation[0]; // This seems to always be "old".
                var op = operation[1]; // This seems to be either "+" or "*".
                var secondPart = operation[2];

                Func<ulong, ulong> operationFunc = op switch
                {
                    "+" => secondPart == "old" ? old => checked(old + old) : old => checked(old + (ulong)int.Parse(secondPart)),
                    "*" => secondPart == "old" ? old => checked(old * old) : old => checked(old * (ulong)int.Parse(secondPart)),
                    _ => throw new NotImplementedException()
                };

                var divisor = int.Parse(monkey[3].Trim().Split(' ')[3]);
                var trueTarget = int.Parse(monkey[4].Trim().Split(' ')[5]);
                var falseTarget = int.Parse(monkey[5].Trim().Split(' ')[5]);

                Monkeys.Add(new(id, items, operationFunc, divisor, trueTarget, falseTarget));
            }

            Monkeys.Sort();
        }

        public void Simulate(int rounds, bool relieved, uint commonMultiple)
        {
            for (int round = 1; round <= rounds; round++)
            {
                foreach (var monkey in Monkeys)
                {
                    var inspectionResult = monkey.Inspect(relieved, commonMultiple);
                    while (inspectionResult.Success)
                    {
                        var monkeyToPassTo = Monkeys.Find(m => m.Id == inspectionResult.Target);
                        monkeyToPassTo?.Items.Enqueue(inspectionResult.Item);

                        inspectionResult = monkey.Inspect(relieved, commonMultiple);
                    }
                }
            }
        }
    }

    public class Monkey : IComparable<Monkey>
    {
        public int Id { get; }
        public Queue<ulong> Items { get; } = new();
        public Func<ulong, ulong> Operation { get; }
        public int Divisor { get; }
        public int TrueTarget { get; }
        public int FalseTarget { get; }
        public int InspectionCount { get; private set; }

        public Monkey(int id, List<uint> items, Func<ulong, ulong> operation, int divisor, int trueTarget, int falseTarget)
        {
            Id = id;
            items.ForEach(i => Items.Enqueue(i));
            Operation = operation;
            Divisor = divisor;
            TrueTarget = trueTarget;
            FalseTarget = falseTarget;
        }

        public InspectionResult Inspect(bool relieved, uint commonMultiple)
        {
            if (Items.Any())
            {
                InspectionCount++;

                var item = Items.Dequeue();

                var itemAfterInspection = Operation(item);
                var itemWhenBored = relieved ? itemAfterInspection / 3 : itemAfterInspection % commonMultiple;

                return new(true, itemWhenBored, itemWhenBored % (ulong)Divisor == 0 ? TrueTarget : FalseTarget);
            }
            return new(false, 0, 0);
        }

        public int CompareTo(Monkey? other)
        {
            return other == null ? 1 : Id.CompareTo(other.Id);
        }
    }

    public class InspectionResult
    {
        public bool Success { get; }
        public ulong Item { get; }
        public int Target { get; }

        public InspectionResult(bool success, ulong item, int target)
        {
            Success = success;
            Item = item;
            Target = target;
        }
    }
}