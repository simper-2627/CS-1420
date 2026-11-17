using System.Runtime.ExceptionServices;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {


        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            TypeInfoResolver = new System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver()
        };

        var list = new List<int> { 1, 32, 5, 6, 657, 5, 7, 678, 9, 45, 45, 3, 434, 4, 3, 2, 34, 56, 6, 6, 7, 7, 8, 9, 0, 5 };


        string json = JsonSerializer.Serialize(list, options);

        Console.WriteLine(json);




    }

    private string Multiply(int thing)
    {
        return (thing * 2) + ", ";
    }

}

