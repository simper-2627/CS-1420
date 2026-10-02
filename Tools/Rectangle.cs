

using System.Runtime.InteropServices;

public class Rectangle
{
    private int width;
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value > 0)
                width = value;
        }
    }

    private int height;
    public void SetHeight(int value)
    {
        height = value;
    }
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value > 0)
                height = value;
        }
    }

    public int Area
    {
        get
        {
            return width * height;
        }
    }

    public static int Count = 0;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
        Count ++;
    }
}




