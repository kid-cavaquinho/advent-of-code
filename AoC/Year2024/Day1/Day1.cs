namespace Year2024.Day1;

internal static class Day1
{
    public static void Solve()
    {
        var input = File.ReadAllLines("day1/input.txt")
            .Select(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToList();
        
        var leftNumbers = input.Select(line => int.Parse(line[0])).OrderBy(x => x).ToList();
        var rightNumbers = input.Select(line => int.Parse(line[1])).OrderBy(x => x).ToList();

        var distance = leftNumbers.Select((l, r) => Math.Abs(l - rightNumbers[r])).Sum();
        Console.WriteLine($"Distance: {distance}");

        var score = leftNumbers.Sum(leftNumber => leftNumber * rightNumbers.Count(x => x.Equals(leftNumber)));
        Console.WriteLine($"Similarity score: {score}");
    }
}