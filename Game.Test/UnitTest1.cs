using Game.Logic;

namespace Game.Test;

public class UnitTest1
{
    [Fact]
    public void PlayThroughTest()
    {
        Garden gard = new Garden();

        gard.Clear(0,0);
        GardenTile tile = gard.Status(0, 0);
        Assert.False(tile.HasWeeds);
    }
}
