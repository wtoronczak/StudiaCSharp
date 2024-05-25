using System.Threading.Channels;

namespace Lista1;

public class Zadanie6
{
// Zadanie 14': For Loop Exercises; Treść: Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
//*
//**
//***
//****

 public static void CreatPyramid()
 {
     int b = 0;
    for (int a = 1; a <= 4; ++a)
    {
        
        for (int c = a ; c > 0; --c )
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    
}
 
 
 
// Zadanie 37; Treść: Write a program in C# Sharp to display a number in reverse order.

    public static void ReversNumber()
    {
        Console.WriteLine("Enter Number");
        var number = Console.ReadLine() ?? "";
        for (int i = number.Length - 1; i >= 0; --i)
        {
            Console.Write(number[i]);
        }
    }
}