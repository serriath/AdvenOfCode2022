namespace AdventOfCode2022.DayFour
{
    static class SectionCleanup
    {
        public static int CleanupDuplication() 
        {
            var lines = File.ReadAllLines("Inputs/day-four-input.txt");
            var duplicateSections = 0;

            foreach(var line in lines)
            {
                var sections = line.Split(',');
                var firstSection = sections[0].Split('-');
                var secondSection = sections[1].Split('-');

                if (int.Parse(firstSection[0]) <= int.Parse(secondSection[0]) &&
                    int.Parse(firstSection[1]) >= int.Parse(secondSection[1]))
                {
                    duplicateSections++;
                }
                else if (int.Parse(secondSection[0]) <= int.Parse(firstSection[0]) &&
                    int.Parse(secondSection[1]) >= int.Parse(firstSection[1]))
                { 
                    duplicateSections++; 
                }

            }

            return duplicateSections; 
        }

        public static int CleanupOverlap()
        {
            var lines = File.ReadAllLines("Inputs/day-four-input.txt");
            var duplicateSections = 0;

            foreach (var line in lines)
            {
                var sections = line.Split(',');
                var firstSection = sections[0].Split('-');
                var secondSection = sections[1].Split('-');

                //  35-82  ,  34-52

                if (int.Parse(secondSection[0]) <= int.Parse(firstSection[1]) &&
                    int.Parse(secondSection[0]) >= int.Parse(firstSection[0]))
                {
                    duplicateSections++;
                }
                else if (
                    int.Parse(secondSection[1]) >= int.Parse(firstSection[0]) &&
                    int.Parse(secondSection[1]) <= int.Parse(firstSection[1]))
                {
                    duplicateSections++;
                }
                else if (
                    int.Parse(firstSection[0]) <= int.Parse(secondSection[1]) &&
                    int.Parse(firstSection[0]) >= int.Parse(secondSection[0]))
                {
                    duplicateSections++;
                }

            }

            return duplicateSections;
        }

    }
}
