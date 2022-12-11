using System;
using System.Collections.Generic;
using System.Linq;
using NAoCHelper;

namespace AdventOfCode.Year2022.Day7
{
    public class Solution : BaseSolution<string[]>, ISolvable
    {
        public Solution(IPuzzle puzzle) : base(puzzle, StringArraySelector)
        {
        }

        public string SolvePart1()
        {
            var directory = GetDirectoryStructure();
            return $"Part 1: {directory?.SizeWithLimit(100000) ?? -1}";
        }

        public string SolvePart2()
        {
            const int TOTAL_DISK_SPACE = 70000000;
            const int REQUIRED_DISK_SPACE = 30000000;
            var minDirSize = -1;
            var directory = GetDirectoryStructure();
            if (directory != null)
            {
                var unusedSpace = TOTAL_DISK_SPACE - directory.Size;
                List<Directory> options = new()
                {
                    directory
                };
                options.AddRange(directory.SubDirectories);

                var subDirectories = directory.SubDirectories.SelectMany(sd => sd.SubDirectories);
                while (subDirectories.Any())
                {
                    options.AddRange(subDirectories);
                    subDirectories = subDirectories.SelectMany(sd => sd.SubDirectories);
                }

                var validOptions = options.Where(o => unusedSpace + o.Size >= REQUIRED_DISK_SPACE).ToList();
                minDirSize = validOptions.MinBy(o => o.Size)?.Size ?? -1;
            }

            // 47442399 is too big.
            return $"Part 2: {minDirSize}";
        }

        private Directory? GetDirectoryStructure()
        {
            Directory? currentDirectory = null;
            foreach (var line in Input)
            {
                if (line.StartsWith('$'))
                {
                    if (line.Contains("cd"))
                    {
                        if (line.EndsWith("..") && currentDirectory != null)
                        {
                            currentDirectory = currentDirectory.ParentDirectory;
                        }
                        else
                        {
                            var newDir = currentDirectory?.SubDirectories.SingleOrDefault(s => s.Name == line.Split(' ')[2]) ?? new("/");
                            if (currentDirectory != null)
                            {
                                newDir.SetParentDirectory(currentDirectory);
                            }
                            currentDirectory = newDir;
                        }
                    }
                }
                else if (currentDirectory != null)
                {
                    if (line.StartsWith("dir"))
                    {
                        currentDirectory.AddSubDirectory(new(line.Split(' ')[1]));
                    }
                    else
                    {
                        currentDirectory.AddFile(int.Parse(line.Split(' ')[0]));
                    }
                }
            }

            while (currentDirectory != null && currentDirectory.ParentDirectory != null)
            {
                // If ParentDirectory is null, we're at the root.
                currentDirectory = currentDirectory.ParentDirectory;
            }

            return currentDirectory;
        }
    }

    public class Directory
    {
        public string Name { get; private set; }
        public readonly List<Directory> SubDirectories = new();
        public readonly List<int> Files = new();
        public Directory? ParentDirectory { get; private set; }

        public int Size => Files.Sum() + SubDirectories.Sum(s => s.Size);

        public Directory(string name)
        {
            Name = name;
        }

        public void AddSubDirectory(Directory dir)
        {
            SubDirectories.Add(dir);
        }

        public void AddFile(int file)
        {
            Files.Add(file);
        }

        public void SetParentDirectory(Directory parent)
        {
            ParentDirectory = parent;
        }

        public int SizeWithLimit(int maxSize)
        {
            return (Size <= maxSize ? Size : 0) + SubDirectories.Sum(s => s.SizeWithLimit(maxSize));
        }
    }
}