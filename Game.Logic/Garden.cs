namespace Game.Logic;

public class Garden
{



    public void Clear(int x, int y)
    {
        
    }

    public GardenTile Status(int x, int y)
    {
        return new GardenTile{ HasWeeds = false};
    }
}
