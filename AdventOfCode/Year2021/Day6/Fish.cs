namespace AdventOfCode.Year2021.Day6
{
    public class Fish
    {
        public int SpawnTimerValue { get; private set; }

        public Fish(int spawnTimerValue)
        {
            this.SpawnTimerValue = spawnTimerValue;
        }

        public Fish? TrySpawn()
        {
            if (SpawnTimerValue > 0)
            {
                SpawnTimerValue--;
                return null;
            }
            else
            {
                SpawnTimerValue = 6;
                return new Fish(SpawnTimerValue + 2);
            }
        }
    }
}