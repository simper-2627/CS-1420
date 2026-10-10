
public class Potato : Plant
{
    private List<double> Tubers;
    public int TuberCount
    {
        get
        {
            return Tubers.Count;
        }
    }

    public Potato() : base("potato")
    {
        Tubers = new List<double>();
    }

    public override void Grow()
    {
        
    }
}