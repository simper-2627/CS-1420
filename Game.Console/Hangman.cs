

public class Hangman
{
    public string Answer { get; set; }
    public int IncorrectGuesses { get; set; }
    public char[] Correct { get; set; }
    public char[] GuessedLetters { get; set; }

    public GameStatus Status
    {
        get
        {
            if (IncorrectGuesses >= 6)
                return GameStatus.Lose;
            if (Correct.ToString() == Answer)
                return GameStatus.Win;
            return GameStatus.Running;
        }
    }

    public Hangman()
    {
        Answer = "green";
        IncorrectGuesses = 0;
        Correct = new char[Answer.Length];
        for (int i = 0; i < Correct.Length; i++)
        {
            Correct[i] = '-';
        }
        GuessedLetters = new char[26];

    }


    public static bool CheckGuess(string answer, char guess, char[] correct)
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

}