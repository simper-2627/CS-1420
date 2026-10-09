
public abstract class Plant
{
    public string Species;
    public int DaysOld;
    public double Height;
    public bool IsWatered;
    public int DaysToMaturity;

    protected Plant(string species)
    {
        Species = species;
        DaysOld = 0;
        Height = 0;
        IsWatered = false;
    }

    public void Grow()
    {
        if (IsWatered)
        {
            Height += 1.2;
            IsWatered = false;
            DaysOld++;
        }
    }
}