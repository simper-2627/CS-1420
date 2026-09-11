

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = [ 1, 2, 3, 4, 5 ];

        // for (int i = 0; i < numbers.Length; i++)
        foreach(int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.Write(number + ", ");
            }

        }
        


    }
}