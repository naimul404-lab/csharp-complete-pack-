using System.Text.Json;

try
{
    int result = Divide(10, 0);
    Console.WriteLine(result);
}
catch (DivideByZeroException error)
{
    Console.WriteLine($"Error: {error.Message}");
}

var person = new { Name = "Ada", Age = 28 };
string json = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
Console.WriteLine(json);

static int Divide(int numerator, int denominator) => numerator / denominator;
