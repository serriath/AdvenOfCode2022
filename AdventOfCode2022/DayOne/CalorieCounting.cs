namespace AdventOfCode2022.DayOne
{
    static class CalorieCounting
    {
        public static int CountCalories()
        {
            var results = GetTotalCaloriesPerElf();

            return results.OrderByDescending(x => x).First();
        }

        public static int CountTopThreeCalories()
        {
            var results = GetTotalCaloriesPerElf();

            return results.OrderByDescending(x => x).Take(3).Sum();
        }

        private static List<int> GetTotalCaloriesPerElf()
        {
            var lines = File.ReadAllLines("Inputs/day-one-input.txt");

            var results = new List<int>();
            var calories = 0;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    results.Add(calories);
                    calories = 0;
                    continue;
                }

                calories += int.Parse(line);
            }

            return results;
        }
    }
}
