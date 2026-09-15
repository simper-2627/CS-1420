

internal class Program
{
    private static void xMain(string[] args)
    {
        int number = 7;
        int[] arr = { 1, 2, 3, 4, 5 };


        Console.WriteLine("number: " + number);
        DoesNothing(number);
        Console.WriteLine("number: " + number);
        DoesSomething(ref number);
        Console.WriteLine("number: " + number);

        for(int i=0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(" ");
        Multiply(arr);
        for(int i=0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(" ");
        
    }

    static void Multiply(int[] list)
    {
        for(int i=0; i < list.Length; i++)
        {
            list[i] = list[i] * 2;
        }
        
    }

    static void DoesNothing(int val)
    {
        val *= 2;
        Console.WriteLine("val: " + val);
    }

    static void DoesSomething(ref int val)
    {
        val *= 2;
        Console.WriteLine("val: " + val);
    }
}