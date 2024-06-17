namespace Lista2;

public class Zadanie2_7
{
    //LINQ,Zadanie 11. Write a program in C# Sharp to display the top n-th records.
    public static void Top()
    {
        var list = new List<int> {3,4,56,72,11,2,1,100 };
        Console.WriteLine("How many records you want to display ?");
        var numberOfRecords = Convert.ToInt32(Console.ReadLine());
        var resultList = list.OrderDescending().Take(numberOfRecords);

        foreach (var number in resultList)
        {
            Console.WriteLine($"{number}");
        }

    }
    
    //LINQ, Zadanie 22. Write a program in C# Sharp to find the strings for a specific minimum length.
    //Źródła: https://learn.microsoft.com/pl-pl/dotnet/api/system.linq.enumerable.where?view=net-8.0
    public static void FindWord()
    {
        var wordList = new List<string> {"this", "is", "happy","dog" };
        var minimumLength = 5;
        var resultWords = wordList.Where(word => word.Length >= minimumLength);
        foreach (var word in resultWords)
        {
            Console.WriteLine(word);
        }
    }
}