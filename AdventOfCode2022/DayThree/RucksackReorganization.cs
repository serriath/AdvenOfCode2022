using System;

namespace AdventOfCode2022.DayThree
{
    static class RucksackReorganization
    {
        public static int GetSumOfDuplicateItems()
        {
            var lines = File.ReadAllLines("Inputs/day-three-input.txt");
            var results = 0;

            foreach(var item in lines)
            {
                var halfWayMark = item.Length / 2;
                var firstCompartment = item.Substring(0, halfWayMark).ToCharArray();
                var secondCompartment = item.Substring(halfWayMark).ToCharArray();

                var matchingChar = firstCompartment.First(x => secondCompartment.Contains(x));

                results += _priorities.First(x => x.Key == matchingChar).Value;
            }

            return results;
        }

        public static int GetSumOfGroupBadges()
        {
            var lines = File.ReadAllLines("Inputs/day-three-input.txt");
            var results = 0;
            var groupsItems = new List<string>();

            foreach (var line in lines)
            {
                groupsItems.Add(line);

                if (groupsItems.Count < 3)
                {
                    continue;
                }

                var firstBag = groupsItems[0].ToCharArray();
                var secondBag = groupsItems[1].ToCharArray();
                var thirdBag = groupsItems[2].ToCharArray();

                var matchingChar = firstBag.Where(x => secondBag.Contains(x));

                var finalChar = matchingChar.Where(x => thirdBag.Contains(x));

                results += _priorities.First(x => x.Key == finalChar.First()).Value;
                groupsItems.Clear();
            }

            return results;
        }

        private static Dictionary<char, int> _priorities = new()
        {
            { 'a', 1 },
            { 'b', 2 },
            { 'c', 3 },
            { 'd', 4 },
            { 'e', 5 },
            { 'f', 6 },
            { 'g', 7 },
            { 'h', 8 },
            { 'i', 9 },
            { 'j', 10 },
            { 'k', 11 },
            { 'l', 12 },
            { 'm', 13 },
            { 'n', 14 },
            { 'o', 15 },
            { 'p', 16 },
            { 'q', 17 },
            { 'r', 18 },
            { 's', 19 },
            { 't', 20 },
            { 'u', 21 },
            { 'v', 22 },
            { 'w', 23 },
            { 'x', 24 },
            { 'y', 25 },
            { 'z', 26 },
            { 'A', 27 },
            { 'B', 28 },
            { 'C', 29 },
            { 'D', 30 },
            { 'E', 31 },
            { 'F', 32 },
            { 'G', 33 },
            { 'H', 34 },
            { 'I', 35 },
            { 'J', 36 },
            { 'K', 37 },
            { 'L', 38 },
            { 'M', 39 },
            { 'N', 40 },
            { 'O', 41 },
            { 'P', 42 },
            { 'Q', 43 },
            { 'R', 44 },
            { 'S', 45 },
            { 'T', 46 },
            { 'U', 47 },
            { 'V', 48 },
            { 'W', 49 },
            { 'X', 50 },
            { 'Y', 51 },
            { 'Z', 52 },
        };
    }
}
