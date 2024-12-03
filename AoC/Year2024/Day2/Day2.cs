namespace Year2024.Day2;

public static class Day2
{
    public static void Solve()
    {
        var lines = File.ReadAllLines("day2/input.txt")
            .Select(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries)).ToList();

        var result = lines.Count(line => Safe(line.Select(int.Parse).ToList()));

        Console.WriteLine($"Safe reports: {result}");
    }

    private static bool Safe(List<int> report)
    {
        var tuples = report.Zip(report.Skip(1)).ToList();
        return tuples.All(p => -3 <= p.First - p.Second && p.First - p.Second <= -1) || 
               tuples.All(p => 1 <= p.First - p.Second && p.First - p.Second <= 3);
    }
}