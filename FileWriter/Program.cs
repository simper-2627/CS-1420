using System.Text.Json;

internal class TerminalUI
{
    private static void Main(string[] args)
    {
        var filepath = "./scores.json";
        string content = "[]";
        if (File.Exists(filepath))
        {
            content = File.ReadAllText(filepath);
        }

        List<HighScore> scoreList;
        try
        {
            scoreList = JsonSerializer.Deserialize<List<HighScore>>(content) ?? new List<HighScore>();
        }
        catch (Exception e)
        {
            string temp = e.Message;
            scoreList = new List<HighScore>();
        }
        Console.Write("Enter your name: ");
        var user = Console.ReadLine() ?? "anon";
        Console.Write("Enter the score: ");
        var input = Console.ReadLine();

        if (double.TryParse(input, out double score))
        {
            scoreList.Add(new HighScore(user, score));
        }

        scoreList = scoreList.OrderByDescending(s => s.Score)
            .Take(10)
            .ToList();

        int position = 1;
        scoreList.ForEach(d => Console.WriteLine($"{position++}. {d.Name} {d.Score}"));


        string json = JsonSerializer.Serialize(scoreList);

        File.WriteAllText(filepath, json);


        return;

    }
}


public record HighScore(string Name, double Score);