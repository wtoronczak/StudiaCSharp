using System.Threading.Channels;

namespace Lista1;

public class Zadanie7
{
    //Zadanie 41 Array Exercises ; Treść:  Write a C# Sharp program to find two numbers in an array of integers whose product is equal to a given number.
    public static void FindNumbers() {
    int[] numbers = { 2, 3, 5, 7, 11 };
    int givenNumber = 42;
    for (int i = 0; i <= numbers.Length - 1; ++i)
    {
        for (int j = 0; j <= numbers.Length- 1; ++j)
        {
            var result = numbers[i] * numbers[j];
            if (result == givenNumber)
            {
                Console.WriteLine($"[{numbers[i]}, {numbers[j]}]");
                return;
            }
        }

        
    }
    Console.WriteLine("No numbers found");

    }

}