using System;

class Program
{

static void Main(string[] args) {

    Console.WriteLine("Welcome to my Simple Calculator :)");
    Console.WriteLine("insert a mathematical operation, example: (1 + 1)");

// Loop for make several calculations

while(true) {
    string  input = Console.ReadLine(); 

// User exit option
    if (input.ToLower() == "exit") {
        Console.WriteLine("Exiting the calculator");
        break;
    }

// Calculation check and Mathematical expression


    try {
        double result = Calculator.ExSolution(input);
        Console.WriteLine($"Result is: {result}");  
    }
    catch (Exception ex) {
        Console.WriteLine($"error when calculating: {ex.Message}");
    }

    Console.WriteLine("Enter another mathematical expression or type 'exit' to exit");
}

}

}


class Calculator
{
    public static double ExSolution(string expression)
    {
        // 
// remove white spaces
        expression = expression.Replace(" ", "");


    }
}

