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
}
