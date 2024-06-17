namespace Lista2;

public class Zadanie2_2
{
    //Zadanie 12; Math Exercises; Treść: rite a C# Sharp program to check whether a given integer is a palindrome integer or not. Return true if the number is a palindrome, otherwise return false.
   
    
        public static void Palindrom()
        {
            Console.WriteLine("Enter the number");
            var number = Console.ReadLine() ?? "";
            int a = 1;
            int b = 0;
            for (int i= 0;i<number.Length; ++i)
            {
                var check = number[i];
                var check2 = number[number.Length - a];
            
                if (check == check2)
                {
                    b++;
                }
                a++;
            }

            if (b == number.Length)
            {
                Console.WriteLine("this is Palindrome");
            }
            else
            {
                Console.WriteLine("This number is not a palindrome");
            }
        }
    }

    