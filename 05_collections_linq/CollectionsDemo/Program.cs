using System.Linq;

var numbers = new List<int> { 8, 3, 10, 1, 6 };
var evenSquares = numbers
    .Where(number => number % 2 == 0)
    .Select(number => number * number)
    .OrderBy(number => number)
    .ToList();

Console.WriteLine(string.Join(", ", evenSquares));

var scores = new Dictionary<string, int>
{
    ["Ada"] = 98,
    ["Grace"] = 95
};
Console.WriteLine($"Ada's score: {scores["Ada"]}");
