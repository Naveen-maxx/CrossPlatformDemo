Console.WriteLine("Cross-platform .NET demo");

var result = GetCarDetails("White", 120);

Console.WriteLine($"Color: {result.Color}");
Console.WriteLine($"Maximum speed: {result.Speed} km/h");

static (string Color, int Speed) GetCarDetails(
    string color, int speed)
{
    return (color, speed);
}