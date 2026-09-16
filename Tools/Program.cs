

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 1, 2, 3 };
        int[] arr3 = arr1;

        ArrayAddressCompare(arr1, arr2);
        ArrayAddressCompare(arr1, arr3);
        
        arr3 = new int[] {3,2,1};

        ArrayAddressCompare(arr1, arr3);

        
        Console.ForegroundColor = ConsoleColor.White;
        Environment.Exit(0);
    }

    static bool ArrayCompare(int [] one, int [] two)
    {
        if (one.Length != two.Length)
            return false;

        for(int i = 0; i < one.Length; i++)
        {
            if(one[i] != two[i])
            {
                return false;
            }    
        }
        return true;
    }

    static void ArrayAddressCompare(int [] one, int [] two)
    {
        if (one == two)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("They are the same.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("They are NOT the same.");
        }
    }


}