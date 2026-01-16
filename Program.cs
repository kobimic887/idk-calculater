Console.Write("Enter first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter operator (+, -, *, /): ");
string op = Console.ReadLine()!;

Console.Write("Enter second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result = op switch
{
    "+" => num1 + num2,
    "-" => num1 - num2,
    "*" => num1 * num2,
    "/" => num2 != 0 ? num1 / num2 : throw new DivideByZeroException("Cannot divide by zero"),
    _ => throw new InvalidOperationException($"Unknown operator: {op}")
};

Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
