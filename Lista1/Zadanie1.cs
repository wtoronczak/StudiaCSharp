namespace Lista1;

public static class Zadanie1
{
   // Zadanie 9 C# Basic Declarations and Expressions. Treść zadania :Write a C# Sharp program that takes four numbers as input to calculate and print the average.
  
    public static void AverageOfFour()
    {
        Console.WriteLine("Enter First Number");
        int numberOne = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number");
        int numberTwo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Third Number");
        int numberThree = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Fourth Number");
        int numberFour = Convert.ToInt32(Console.ReadLine());

        var average = (numberOne + numberTwo + numberThree + numberFour) / 4.0;
        Console.WriteLine($"Given numbers: {numberOne} | {numberTwo} | {numberThree} | {numberFour}");
        Console.WriteLine($"Average {average}" );
    }
//Zadanie 1.1
// liczy srednia z podanej ilosci liczb
    public static void AverageOfX(int x)
    {
        var sum = 0.0;
        var a = 0;
        while (a < x)
        {
            Console.WriteLine($"Enter {a+1} Number");
            var int32 = Convert.ToInt32(Console.ReadLine());
            a++;
            sum += int32;
        }
        
        var average = sum / x;
        Console.WriteLine($"Average {average}" );
    }

}