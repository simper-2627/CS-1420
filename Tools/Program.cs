

internal class Program
{
    private static void Main(string[] args)
    {

        int item = 13;
        TryThis("hello", out item);

        Console.WriteLine(item);
    }

    static bool TryThis(string value, out int parsed)
    {
        // parsed = parsed + 12;
        return true;
    }

}