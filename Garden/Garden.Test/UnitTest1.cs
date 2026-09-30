using Garden.Logic;

namespace Garden.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Class1 item = new Class1();

        int number = item.Status(12);

        Assert.Equal(12, number);
    }
}
