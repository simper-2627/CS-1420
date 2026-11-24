public class Program
{
    private static void Main(string[] args)
    {
        int disks = 20;
        var tower = new Hanoi(disks);
        var solver = new HanoiSolver();

        Console.WriteLine(tower.ToString());
        var moves = solver.Solve(tower, disks, 0, 2, 1);
        // Console.WriteLine(tower.ToString());
        Console.WriteLine($"Moves for {disks}: {moves}");
    }

}

public class HanoiSolver
{
    public int Solve(Hanoi board, int discs, int src, int dest, int aux)
    {
        if (discs == 1)
        {
            board.Move(src, dest);
            // Console.WriteLine(board.ToString());
            return 1;
        }

        var premoves = Solve(board, discs - 1, src, aux, dest);

        board.Move(src, dest);
        // Console.WriteLine(board.ToString());

        var postmoves = Solve(board, discs - 1, aux, dest, src);

        return premoves + postmoves + 1;
    }
}


public class Hanoi
{
    public List<List<int>> Towers;

    public Hanoi(int layers)
    {
        Towers = new List<List<int>>();
        for (int i = 0; i < 3; i++)
        {
            Towers.Add(new List<int>());
        }
        for (int i = layers; i > 0; i--)
        {
            Towers[0].Add(i);
        }

    }

    public bool Move(int start, int end)
    {
        if (!Towers[start].Any())
        {
            return false;
        }
        if (!Towers[end].Any() || Towers[start].Last() < Towers[end].Last())
        {
            Towers[end].Add(Towers[start].Last());
            Towers[start].RemoveAt(Towers[start].Count - 1);
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        var retval = "";

        for (int i = 0; i < 3; i++)
        {
            retval += "-";
            for (int j = 0; j < Towers[i].Count; j++)
            {
                retval += Towers[i][j] + " ";
            }
            retval += Environment.NewLine;
        }
        retval += "--------";
        return retval;
    }
}