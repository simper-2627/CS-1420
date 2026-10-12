using Garden.Logic;

namespace Garden.Test;

public class GrosTest
{
    public static bool DoubleCompare(double a, double b, double e)
    {
        return Math.Abs(a-b) < e;
    }

    [Fact]
    public void BeanGrowWatered()
    {
        Bean b = new Bean();
        b.IsWatered = true;
        b.Grow();
        Assert.True(b.Height > 0);
        Assert.Equal(1, b.DaysOld);
    }

    [Fact]
    public void BeanMakesPod()
    {
        Bean bean = new Bean();
        for (int i = 0; i < 12; i++)
        {
            bean.IsWatered = true;
            bean.Grow();
        }
        Assert.Equal(1, bean.Pods);
        for (int i = 0; i < 3; i++)
        {
            bean.IsWatered = true;
            bean.Grow();
        }
        Assert.Equal(2, bean.Pods);

    }

    [Fact]
    public void PotatoTest()
    {
        Potato potato = new Potato();
        potato.Grow();

        // Only grow if watered
        Assert.True(DoubleCompare(potato.Height, 0, 0.00001));


        potato.IsWatered = true;
        potato.Grow();
        Assert.False(potato.IsWatered);
        Assert.True(potato.Height > 0);
    }



}
