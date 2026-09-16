

using System.Security.Cryptography;

internal class Hangman
{
    private static void Main(string[] args)
    {
        int incorrectGuesses = 0;
        string answer = "green";
        char[] correct = new char[answer.Length];
        for (int i = 0; i < correct.Length; i++)
        {
            correct[i] = '-';
        }
        char[] guessedLetters = new char[26];

        Console.WriteLine("Let's play hang man");

        bool winner = false;

        while (incorrectGuesses < 6 && !winner)
        {
            PrintStatus(correct, incorrectGuesses, guessedLetters);

            char guess = PromptInputValidate();
            if (guess == ' ')
                return;

            bool found = CheckGuess(answer, guess, correct);

            if (found)
            {
                Console.WriteLine($"Yes. The word contains at least one {guess}.");
            }
            else
            {
                bool guessedPreviously = false;

                for (int i = 0; i < incorrectGuesses; i++)
                {
                    if (guessedLetters[i] == guess)
                    {
                        guessedPreviously = true;
                    }
                }

                if (!guessedPreviously)
                {
                    guessedLetters[incorrectGuesses] = guess;
                    incorrectGuesses++;
                    Console.WriteLine($"The word does not contain {guess}.");
                    Console.WriteLine("length: " + guessedLetters.Length);
                }
            }

            winner = true;
            if (correct.ToString() != answer)
            {
                winner = false;
            }

            for (int i = 0; i < correct.Length; i++)
            {
            }

        }

        if (incorrectGuesses >= 6)
        {
            Console.WriteLine($"You lose. The word was: {answer}");
        }

    }

    private static bool CheckGuess(string answer, char guess, char[] correct)
    {
        bool found = false;
        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] == guess)
            {
                found = true;
                correct[i] = answer[i];
            }
        }
        return found;
    }

    private static void PrintStatus(char[] correct, int incorrectGuesses, char[] guessedLetters)
    {
        Console.Write("\nCurrent status: ");
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
            Console.WriteLine("Only input one letter");
        }
        else
        {
            value = guess[0];
        }
        return value;
    }
}