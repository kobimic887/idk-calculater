double num1 = ReadNumber("Enter first number: ");
string op = ReadOperator("Enter operator (+, -, *, /): ");
double num2 = ReadNumber("Enter second number: ");

if (op == "/" && num2 == 0)
{
    Console.WriteLine("Cannot divide by zero.");
    return;
}

double result = op switch
{
    "+" => num1 + num2,
    "-" => num1 - num2,
    "*" => num1 * num2,
    _ => num1 / num2
};

Console.WriteLine($"Result: {num1} {op} {num2} = {result}");

static double ReadNumber(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine();
        if (input is null) Environment.Exit(1);
        if (double.TryParse(input, out double value)) return value;
        Console.WriteLine($"\"{input}\" is not a number, try again.");
    }
}

static string ReadOperator(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        string? input = Console.ReadLine()?.Trim();
        if (input is null) Environment.Exit(1);
        if (input is "+" or "-" or "*" or "/") return input;
        Console.WriteLine($"\"{input}\" is not a supported operator, try again.");
    }
}
