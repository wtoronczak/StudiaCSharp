namespace Lista1;

public class Zadanie4
{
    // zadanie 4 Data Types Exercises . Treść: Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.
    // edit: Użytkownik podaje znak i na tej podstawie będzie liczyć coś 
    public static void OpetarionNumber()
    {
        Console.WriteLine("Enter First Number");
        int numberOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number");
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        int sum = numberOne + numberTwo;
    }
}