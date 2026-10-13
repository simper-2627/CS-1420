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
        Bean bean = new Bean();
        bean.IsWatered = true;
        bean.Grow();
        Assert.True(bean.Height > 0);
        Assert.Equal(1, bean.DaysOld);

        for (int i = 1; i < 12; i++)
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

        List<Produce> beanpods = bean.Harvest();
        Assert.Equal(0, bean.Pods);
        Assert.Equal(2, beanpods.Count);
    }

    [Fact]
    public void PotatoTest()
    {
        Garden.Logic.Potato potato = new Garden.Logic.Potato();
        potato.Grow();

        // Only grow if watered
        Assert.True(DoubleCompare(potato.Height, 0, 0.00001));


        potato.IsWatered = true;
        potato.Grow();
        Assert.False(potato.IsWatered);
        Assert.True(potato.Height > 0);
    }



}
