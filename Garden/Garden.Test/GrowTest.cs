using Garden.Logic;

namespace Garden.Test;

public class GrosTest
{
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
}
