
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
}