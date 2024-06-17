namespace Lista2;

public class Zadanie2_4
{
    //Zadanie1; Sharp Exception Handling; Treść: Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.
    // źródła: https://www.w3schools.com/cs/cs_user_input.php
    public static void NumberDivide()
    {
        Console.WriteLine("Enter first number");
        var numberOne = Console.ReadLine();
        Console.WriteLine("Enter second number");
        var numberTwo = Console.ReadLine();
        try
        { 
            double divide =Convert.ToDouble(numberOne) / Convert.ToDouble(numberTwo);
            Console.WriteLine(divide);
        }
        catch (Exception e)
        {
            
            Console.WriteLine(" Something goes wrong");
        }
    }
}