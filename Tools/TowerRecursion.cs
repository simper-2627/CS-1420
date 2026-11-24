public class Program
{
    private static void Main(string[] args)
    {
        var tower = new Hanoi(3);
        Console.WriteLine(tower.ToString());
    }

}


public class Hanoi
{
    public List<List<int>> towers;

    public Hanoi(int layers)
    {
        towers = new List<List<int>>();
        for(int i = 0; i < 3; i++)
        {
            towers.Add(new List<int>());
        }
        for (int i = layers; i > 0; i--)
        {
            towers[0].Add(i);
        }

    }

    public override string ToString()
    {
        var retval = "";
        
        towers.ForEach(peg => peg.ForEach(disc => retval+= peg + "\t"));

        return retval;
    }
}