namespace Lista2;

public class Zadanie2_6
{
    
    //Zadanie 5;C Sharp DateTime; Treść: Write a C# Sharp program to get a DateTime value that represents the current date and time on the local computer.
    //źródła: https://www.tutorialsteacher.com/csharp/csharp-datetime
    public static void Data()
    {
        DateTime currentDateUtc = DateTime.UtcNow; // podaje datę UTC
        DateTime currentDate = DateTime.Now; // podaje lokalną datę
        Console.WriteLine($"UTC data: {currentDateUtc} and local data: {currentDate}");
    }




    //Zadanie 9; C Sharp DateTime; Treść: Write a C# Sharp program to calculate what day of the week is 40 days from now.
    public static void DayOfWeek()
    {
        DateTime todayIs = DateTime.Now;
        var dayName = todayIs.DayOfWeek;
        Console.WriteLine($"{dayName}");
        var dayIn40 = todayIs.AddDays(40);
        var dayIn40Name = dayIn40.DayOfWeek;
        Console.WriteLine($"{dayIn40Name}");
    }

}