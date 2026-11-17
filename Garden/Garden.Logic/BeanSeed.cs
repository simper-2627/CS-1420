namespace Garden.Logic;

public class BeanSeed : Seed
{
    public override Plant Plant()
    {
        return new Bean();
    }
}