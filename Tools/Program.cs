internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle shape = new Rectangle(3,4);

        Console.WriteLine($"Rectangle {shape.Width}, {shape.Height}; Area: {shape.Area}");
        shape.Height = 5;
        Console.WriteLine($"Rectangle {shape.Width}, {shape.Height}; Area: {shape.Area}");
        

    }



}