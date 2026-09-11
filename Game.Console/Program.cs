

internal class Program
{
    private static void Main(string[] args)
    {
        string answer = "green";

        Console.WriteLine("Let's play hang man");


        Console.Write("Guess a letter: ");
        var guess = Console.ReadLine() ?? "";
        guess = guess.Trim()
            .ToLower();


        // Console.WriteLine("|"+guess+"|");

        // not already guessed
        if (guess.Length != 1)
        {
            // Length == 1
            Console.WriteLine("Only input one letter");
        }
        else if (!char.IsAsciiLetter(guess[0]))
        {
            // only letters
            Console.WriteLine("Only input one letter");
        } else
        {
            
            
        }

    }
}