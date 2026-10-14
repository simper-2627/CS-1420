

var name = "World";
var greeting = "Hello";

if (args.Length >= 1)
{
    name = args[0];
}
if (args.Length >= 2)
{
    greeting = args[1];
}

Console.WriteLine(greeting + ", " + name);

