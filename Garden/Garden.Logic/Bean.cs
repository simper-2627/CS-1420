namespace Garden.Logic;

public class Bean : Plant
{
    public int Pods;
    public int MaxPods;
    public int BeansPerPod;

    public Bean() : base("Bean")
    {
        DaysToMaturity = 12;
        Pods = 0;
        MaxPods = 50;
        BeansPerPod = 12;
    }

    public override void Grow()
    {
        if (IsWatered)
        {
            DaysOld++;
            IsWatered = false;

            if (Height < 10)
            {
                Height += 1.2;
            }
            else
            {
                Height += .6;
            }
            TryGrowPod();

        }

    }

    public override List<Produce> Harvest()
    {
        List<Produce> produce = new List<Produce>();

        for(int i = 0; i < Pods; i++)
        {
            produce.Add(new BeanPod());
        }

        Pods = 0;
        return produce;
    }

    private void TryGrowPod()
    {
        if (DaysOld >= DaysToMaturity && (DaysOld - DaysToMaturity) % 3 == 0)
        {
            Pods++;
        }
    }
}