static decimal Calculate(decimal left, string operation, decimal right) => operation switch
{
    "+" => left + right,
    "-" => left - right,
    "*" => left * right,
    "/" when right != 0 => left / right,
    "/" => throw new DivideByZeroException("Cannot divide by zero."),
    _ => throw new ArgumentException("Supported operations are +, -, *, /.", nameof(operation))
};

try
{
    Console.WriteLine("Enter an expression, e.g. 12 * 3:");
    string? line = Console.ReadLine();
    string[] parts = line?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? [];
    if (parts.Length != 3 || !decimal.TryParse(parts[0], out decimal left) ||
        !decimal.TryParse(parts[2], out decimal right))
    {
        throw new FormatException("Use the format: number operator number.");
    }
    Console.WriteLine(Calculate(left, parts[1], right));
}
catch (Exception error) when (error is FormatException or ArgumentException or DivideByZeroException)
{
    Console.WriteLine($"Error: {error.Message}");
}
