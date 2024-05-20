namespace Lista1;
 
// Zadanie 28. Basic Algorithm. Treść zadania: Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".
public class Zadanie2
{
    //szuka "a" i sprawdza czy występuje po nim inne "a"
    public static void FindAnotherA()
    {
        Console.WriteLine("Enter Sequency of string");
        var sequencyOne = Console.ReadLine() ?? "";
        
        /*
        if (HasDoubleA(sequencyOne))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }*/
        
        
        var lenOne = sequencyOne.Length;

        for (var i = 0; i < lenOne - 1 ; i++)
        {
            if (sequencyOne[i].ToString() == "a" && sequencyOne[i + 1].ToString() == "a")
            {
                Console.WriteLine("True");
                return;
            }
        }
        Console.WriteLine("False");
        
    }

   /* private static bool HasDoubleA(string text)
    {
        for (var i = 0; i < text.Length - 1 ; i++)
        {
            if (text[i].ToString() == "a" && text[i + 1].ToString() == "a")
            {
                return true;
            }
        }

        return false;
    }
    */
  
   // Szuka pierwszego "a" i sprawdza czy występuje po nim inne "a"
   public static void FindFirstA()
   {
       Console.WriteLine("Enter Sequency of string");
       var sequencyOne = Console.ReadLine() ?? "";
       
       var lenOne = sequencyOne.Length;

       for (var i = 0; i < lenOne - 1 ; i++)
       {
           if (sequencyOne[i].ToString() == "a" && sequencyOne[i + 1].ToString() == "a")
           {
               Console.WriteLine("True");
               return;
           }
           else if (sequencyOne[i].ToString() == "a" && sequencyOne[i + 1].ToString() != "a")
           {
               Console.WriteLine("False");
               return;
           }
       }
       Console.WriteLine("False");
       
   }
   
}


