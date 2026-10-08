# idk-calculater

A tiny console calculator in C#. It asks for two numbers and an operator (`+`, `-`, `*`, `/`), then prints the result. Bad input gets re-prompted, and dividing by zero prints a message instead of crashing.

## Run

Needs the .NET 10 SDK.

```sh
dotnet run --project ConsoleApp1.csproj
```

```
Enter first number: 6
Enter operator (+, -, *, /): *
Enter second number: 7
Result: 6 * 7 = 42
```
