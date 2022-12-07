// See https://aka.ms/new-console-template for more information
using AdventOfCode2022.DayOne;
using AdventOfCode2022.DayThree;
using AdventOfCode2022.DayTwo;

Console.WriteLine("Hello, World!");
Console.WriteLine("");
Console.WriteLine("Lets start working our advent calendar!");
Console.WriteLine("");
Console.WriteLine("RESULTS:");
Console.WriteLine("-----------------------------------------------------------------------------");
//day one
Console.WriteLine("Day One - Calorie Counting");
Console.WriteLine($"Part 1  = {CalorieCounting.CountCalories()}");
Console.WriteLine("");
Console.WriteLine($"Part 2  = {CalorieCounting.CountTopThreeCalories()}");
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------------------------------");

//day two
Console.WriteLine("Day Two - Rock Paper Scissors");
Console.WriteLine($"Part 1  = {RockPaperScissors.CalculateScore()}");
Console.WriteLine("");
Console.WriteLine($"Part 2  = {RockPaperScissors.CalculateSecondRoundScore()}");
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------------------------------");

//day three
Console.WriteLine("Day Three - Rucksack Reorganization");
Console.WriteLine($"Part 1  = {RucksackReorganization.GetSumOfDuplicateItems()}");
Console.WriteLine("");
Console.WriteLine($"Part 2  = {RucksackReorganization.GetSumOfGroupBadges()}");
Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------------------------------");

Console.ReadLine();
