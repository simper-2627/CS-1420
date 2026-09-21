

internal class Program
{
    private static void Main(string[] args)
    {


        int num = 70;
        if (num  < 10)
        {
            Console.WriteLine("shmall");
        }




        int i = 0;
        // while ( i < 10)
        for (;;)
        {
            Console.Write(i + ", ");
            i++;
            if (i >= 10)
                break;
        }
    }


}