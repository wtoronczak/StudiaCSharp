using System.Diagnostics.CodeAnalysis;

namespace Lista1;

public class Zadanie4
{
    // zadanie 4 Data Types Exercises . Treść: Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,x,/) on them and displays the result of that operation.
    // edit: Użytkownik podaje znak i na tej podstawie będzie liczyć coś 
    public static void OperationNumber()
    {
        Console.WriteLine("Enter First Number");
        int numberOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number");
        int numberTwo = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(" Choose Mathematical operation sign");
        string sign = Console.ReadLine() ?? "";

        var result = Calculate(numberOne, numberTwo, sign);
        if (result == null) 
        {
            Console.WriteLine("Sign is incorrect"); 
        }
        else
        {
            Console.WriteLine($"Result is {result}");
        }
        
    }

    private static int? Calculate(int numberOne, int numberTwo, string sign)
    {
        int sum = numberOne + numberTwo;
        int sub = numberOne - numberTwo;
        int multi = numberOne * numberTwo;
        int div = numberOne / numberTwo;
        
        if (sign == "+")
        {
            
            return sum;
        }
        if (sign == "-")
        {
            
            return sub;
        }
        if (sign == "*")
        {
            
            return multi;
        }

        if (sign == "/")
        {
            
            return div;
        }

        return null; 

    }
    
    
}