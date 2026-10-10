
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

    // {
    //     if (IsWatered)
    //     {
    //         Height += 1.2;
    //         IsWatered = false;
    //         DaysOld++;

    //         if(this.GetType() == typeof(Bean))
    //         {
    //             Bean b = (Bean) this;
    //            b.TryGrowPod();
    //         }
    //         if(this.GetType() == typeof(Potato))
    //         {
    //             Potato p = (Potato) this;
    //             p.TryGrowTuber();
    //             p.IncreaseTuberSize();
    //         }
    //     }
    // }
}