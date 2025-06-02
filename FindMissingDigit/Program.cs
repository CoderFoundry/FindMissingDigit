// See https://aka.ms/new-console-template for more information


using FindMissingDigit;

string expression = "1? + 23 = 35";
int expectedDigit = 2;

int result =  MissingDigitSolver.FindMissingDigit(expression);

Console.WriteLine($"*******Check Expression: {expression} *************\n");
if (result == expectedDigit)
{
    Console.WriteLine($"The missing digit in the expression '{expression}' is {result}.");
}
else
{
    Console.WriteLine($"Expected {expectedDigit}, but got {result}.");
}

Console.WriteLine("\n*************** Completed Check **************\n");