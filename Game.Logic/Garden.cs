namespace Game.Logic;

public class Garden
{
    private List<GardenTile> tiles = new List<GardenTile>();


    public void Clear(int x, int y)
    {
        tiles.Add(new GardenTile
        {
            X = x,
            Y = y,
            HasWeeds = false
        });
    }

    public GardenTile Status(int x, int y)
    {
        return tiles[0];
    }


}
