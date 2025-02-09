using Calculator.Core;

Console.WriteLine("Hello, World!");
int sum= Calculator.Core.Calculator.Add(1, 2);
Console.WriteLine($"Sum of two numbers is {sum}");

double result = Calculator.Core.Calculator.Divide(2, 1);
Console.WriteLine($"Division of two numbers is {result}");

int sub = Calculator.Core.Calculator.Subtract(2, 1);
Console.WriteLine($"Subtraction of two numbers is {sub}");

int mult = Calculator.Core.Calculator.Multiply(2, 1);
Console.WriteLine($"Multiplication of two numbers is {mult}");