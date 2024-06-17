namespace Lista2;

public class Zadanie2_1
{
    // Zadanie 5; String Exercises; Treść: Write a program in C# Sharp to count the total number of words in a string.
    // Źródła, z których korzystano :  https://www.w3schools.com/cs/cs_strings.php
    // https://learn.microsoft.com/pl-pl/dotnet/api/system.string.split?view=net-8.0#system-string-split(system-char())
    public static void FindWordNumber()
    {
        Console.WriteLine("Enter text");
        var text = Console.ReadLine();
        if (text == "")
        {
            Console.WriteLine("Liczba wyrazów to : 0");
            return;
        } 
        string[] words = text.Split(" ");
        var a = words.Length;
        Console.WriteLine($"Liczba wyrazów to: {a}");

        
    }

    
    
    
    
    
    // Zadanie 10; String Exercises; Treść: Write a C# Sharp program to find the maximum number of characters in a string.
    //The Highest frequency of character 'e' 
    //appears number of times : 4 
    public static void CountCharacters()
    {
        Console.WriteLine("Enter text");
        var text = Console.ReadLine() ?? "";

        var dictionary = new Dictionary<char, int>();

        foreach (var character in text)
        {
            if (char.IsLetter(character) || char.IsDigit(character))
            {
                if (dictionary.TryGetValue(character, out var value))
                {
                    dictionary[character] = value + 1;
                }
                else
                {
                    dictionary[character] = 1;
                }
            }
        }

        var (key, amount) = dictionary.OrderByDescending(x => x.Value).FirstOrDefault();

        Console.WriteLine($"Najwięcej wystąpień: {key} z {amount} wystąpień");
    }
    
    
    
    
    
    
    
    
    
    
    // Zadanie 14; String Exercises; Treść: Write a C# Sharp program to check whether a given substring is present in the given string.
    // Metoda na szukanie jednego słowa -> UWAGA nie działa przy ciągu wyrazów :) 
    public static void CheckWord()
    {
        Console.WriteLine("Enter text");
        var text = Console.ReadLine() ?? "" ;
        Console.WriteLine("Enter substring");
        var substring = Console.ReadLine();
        
        string[] words = text.Split(" ");
       
       
        for (int i = 0; i < words.Length ; i++)
        {
            var check = words[i];
            if (check == substring)
            {
                Console.WriteLine("The substring exists in the string");
                return;
            }
        
        }
        Console.WriteLine("The substring does not exist in the string ");
        
        
    }
    // z zastosowaniem metody contains -> działa dla wielu wyrazów 
    public static void CheckWord2()
    {
        Console.WriteLine("Enter text");
        var text = Console.ReadLine() ?? "";
        Console.WriteLine("Enter substring");
        var substring = Console.ReadLine() ?? "";
        if (text.Contains(substring))
        {
            Console.WriteLine($" Text contains substring: {substring}");
        }
        else
        {
            Console.WriteLine("Text does not contain given substring");
        }
    }

}