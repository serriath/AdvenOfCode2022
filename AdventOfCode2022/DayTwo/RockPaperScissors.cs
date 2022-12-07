namespace AdventOfCode2022.DayTwo
{
    static class RockPaperScissors
    {
        public static int CalculateScore()
        {
            var lines = File.ReadAllLines("Inputs/day-two-input.txt");
            var totalScore = 0;
            var generateAllCombos = GenerateAllPossibleCombinationsAndScores();

            foreach(var line in lines)
            {
                var result = generateAllCombos.First(x => x.Key.Trim().Equals(line.Trim()));
                totalScore += result.Value;
            }

            return totalScore;
        }

        public static int CalculateSecondRoundScore()
        {
            var lines = File.ReadAllLines("Inputs/day-two-input.txt");
            var totalScore = 0;
            var generateAllCombos = GenerateAllPossibleCombinationsAndScoresAgain();

            foreach (var line in lines)
            {
                var result = generateAllCombos.First(x => x.Key.Trim().Equals(line.Trim()));
                totalScore += result.Value;
            }

            return totalScore;
        }

        // a cheeky precalculation
        private static Dictionary<string, int> GenerateAllPossibleCombinationsAndScores()
        {
            // A & X = Rock (1 point)
            // B & Y = Paper (2 points)
            // C & Z = Scissors (3 points)

            var combos = new Dictionary<string, int>
            {
                //draws = 3 points + hand
                { "A X", 4 },
                { "B Y", 5 },
                { "C Z", 6 },

                //wins = 6 points + hands
                { "A Y", 8 },
                { "B Z", 9 },
                { "C X", 7 },

                //loses = 0 + hands
                { "A Z", 3 },
                { "B X", 1 },
                { "C Y", 2 }
            };

            return combos;
        }

        // a cheeky precalculation again
        private static Dictionary<string, int> GenerateAllPossibleCombinationsAndScoresAgain()
        {
            var results = new Dictionary<string, int>
            {
                { "A X", 3 },// ROCK + LOSE
                { "A Y", 4 },// ROCK + DRAW
                { "A Z", 8 },// ROCK + WIN

                { "B X", 1 },// PAPER + LOSE
                { "B Y", 5 },// PAPER + DRAW
                { "B Z", 9 },// PAPER + WIN

                { "C X", 2 },// SCISSORS + LOSE
                { "C Y", 6 },// SCISSORS + DRAW
                { "C Z", 7 } // SCISSORS + WIN
            };

            return results;
        }
    }
}
