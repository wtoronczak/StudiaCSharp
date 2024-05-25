using System.Diagnostics;
using System.Threading.Channels;

namespace Lista1;

public class Zadanie5
{
    // zadanie 5: Conditional Statement Excercises; Treść: Write a program in C# Sharp to accept a grade and declare the equivalent description :Grade	Description
    //E	Excellent
    //V	Very Good
    // G	Good
    //A	Average
    //F	Fail
    public static void DeclareNote()
    {
        Console.WriteLine("Enter Grade Symbol");
        var grade  = Console.ReadLine()?? "";
        grade = grade.ToUpper();
        var message = "";
        switch (grade)
        {
            case "E":
               message = " Excellent";
                break;
            case "V":
                message = "Very Good";
                break;
            case "G":
                message = "Good";
                break;
            case "A":
                message = "Average";
                break;
            case "F":
                message = "Fail";
                break;
            default:
                message = "description to this symbol does not exist";
                Console.WriteLine("You enter wrong value. Allowed symbols: E,V,G,A,F");
                break;
                
        }
        
        
        Console.WriteLine($"Choosen grade symbol is: {grade}");
        Console.WriteLine($"Description to this grade is : {message}");
    }
}