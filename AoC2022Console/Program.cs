// See https://aka.ms/new-console-template for more information

using AdventOfCode.Application.AoC2022.RockPaperScissors;
using DotNetHelpers;


/*
 * Day 01
Console.WriteLine("Hello, World!");

var input = InputReader.GetInputRaw(Environment.CurrentDirectory, folderName: "aoc-2022-data", fileName: "input-day01.txt");

var bagsByCaloriesCount = input
    .Split(Environment.NewLine + Environment.NewLine)
    .Select(x => x.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse))
    .Select((v, i) => new { pos = i + 1, calories = v.Sum()})
    .OrderByDescending(x => x.calories);

var top1 = bagsByCaloriesCount.First().calories;
var top3 = bagsByCaloriesCount.Take(3).Sum(x => x.calories);

//foreach (var chunk in bagsByCaloriesCount)
//{
//    Console.WriteLine(chunk.pos);
//    Console.WriteLine(chunk.calories);
//}

Console.WriteLine("Sum: " + top1);
Console.WriteLine("top3: " + top3);
 * */




/*
 * Day 2
 */

var input = InputReader.GetInput(Environment.CurrentDirectory, folderName: "aoc-2022-data", fileName: "input-day02.txt");

var data = RockPaperScissors.ParseInputWithOutcomeStrategy(input);
// Console.WriteLine("data: " + data.Count);

var result = RockPaperScissors.CalculateScoreAndOutcome(data);

// Console.WriteLine("result: " + result.Count);

Console.WriteLine("Score: " + result.Sum(x => x.Score));

/*
var result = RockPaperScissors.CalculateScoreAndOutcome(data);

Console.WriteLine("result: " + result.Count);

Console.WriteLine("Score: " + result.Sum(x => x.Score));
*/