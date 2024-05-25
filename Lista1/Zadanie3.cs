using System.Globalization;

namespace Lista1;

public static class Zadanie3
{
  
    // zadanie 9 Exception Handling. Treść zadania: Write a C# program that creates a method that reads a date from the user in the format "dd/mm/yyyy" and converts it to a DateTime object. Handle an exception if the input format is invalid.

    public static void UserData()
    {
        Console.WriteLine("Enter your data");
        var userData = Console.ReadLine() ?? "";
        //sprawdzanie formatu danych try, catch - łapie wyjątki 
        try
        {
            var date = DateTime.ParseExact(userData, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date);
        }
        catch (Exception )
        {
            Console.WriteLine("Date input is incorrect");
        }
    }
    
}