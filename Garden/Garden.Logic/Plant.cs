namespace Garden.Logic;

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

    public abstract void Grow();
    public abstract List<Produce> Harvest();

}