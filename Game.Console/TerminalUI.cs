

using System.Security.Cryptography;

internal class TerminalUI
{
    private static void Main(string[] args)
    {
        Hangman game = new Hangman();

        Console.Clear();
        Console.WriteLine("Let's play hangman");


        while (game.Status == GameStatus.Running)
        {
            PrintStatus(game.Correct, game.IncorrectGuesses, game.GuessedLetters);

            char guess = PromptInputValidate();
            Console.Clear();
            if (guess == ' ')
                continue;

            bool found = Hangman.CheckGuess(game.Answer, guess, game.Correct);


            if (found)
            {
                Console.WriteLine($"Yes. The word contains at least one {guess}.");
            }
            else
            {
                bool guessedPreviously = false;

                for (int i = 0; i < game.IncorrectGuesses; i++)
                {
                    if (game.GuessedLetters[i] == guess)
                    {
                        guessedPreviously = true;
                    }
                }

                if (!guessedPreviously)
                {
                    game.GuessedLetters[game.IncorrectGuesses] = guess;
                    game.IncorrectGuesses++;
                    Console.WriteLine($"The word does not contain {guess}.");
                    // Console.WriteLine("length: " + guessedLetters.Length);
                }
            }
        }

        if (game.IncorrectGuesses >= 6)
        {
            Console.WriteLine($"You lose. The word was: {game.Answer}");
        }

    }



    private static void PrintStatus(char[] correct, int incorrectGuesses, char[] guessedLetters)
    {
        // Console.Write("\nCurrent status: ");

        char[] man = 
@"  ____
  |  |
     |
     |
     |
     |
 ------
".ToArray();

        if (incorrectGuesses >= 1)
        {
            man[18] = 'O';
        }
        Console.WriteLine(man);
        
        for (int i = 0; i < correct.Length; i++)
        {
            Console.Write(correct[i] + " ");
        }
        Console.WriteLine("\nIncorrect Guesses: " + incorrectGuesses);

        if (incorrectGuesses > 0)
        {
            Console.Write("You have already guessed: ");
            for (int i = 0; i < incorrectGuesses; i++)
            {
                Console.Write(guessedLetters[i] + ", ");
            }
            Console.WriteLine(" ");
        }
    }

    static char PromptInputValidate()
    {
        char value = ' ';
        Console.Write("Guess a letter: ");
        string guess = Console.ReadLine() ?? "";
        guess = guess.Trim()
            .ToLower();

        // Console.WriteLine("|"+guess+"|");

        if (guess.Length != 1)
        {
            // Length == 1
            Console.WriteLine("Only input one letter");
        }
        else if (!char.IsAsciiLetter(guess[0]))
        {
            // only letters
            Console.WriteLine("Your guess must be a letter");
        }
        else
        {
            value = guess[0];
        }
        return value;
    }
}