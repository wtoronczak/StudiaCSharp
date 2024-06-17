namespace ListaSprawdzająca2;

public class zadanie2A
{
    //Zad. 20A – osoby, które nie uczyły się programowania obiektowego
   // Napisz funkcję, która dla zadanych jako argumenty wejściowe łańcuchów x i y, zwróci odległość Hamminga DH(x, y) pomiędzy nimi, tzn. liczbę pozycji, na których napisy różnią
   //się. W przypadku napisów o różnej długości policzenie odległości Hamminga jest niemożliwe należy zwrócić None albo zgłosić wyjątek. Na przykład DH(mother, mutter) = 2,
    //natomiast DH(mother, matka) nie istnieje. Funkcję opatrz komentarzem dokumentacyjnym. Napisz funkcję testującą, pamiętając o przypadkach typowych i brzegowych.

    // aby uruchomić program należy odkomentować zadanie2A.CountDiffrences() w Program.cs
    public static void CountDiffrences()
    {
        // umożliwienie wpisania dwóch argumentów wejścia przez użtykownika
        Console.WriteLine("Podaj argument x");
        var x = Console.ReadLine();
        Console.WriteLine("Podaj argument y");
        var y = Console.ReadLine();
        var lenOfX = x.Length;
        var lenOfy = y.Length;
        var dH = 0;
        // warunek na taką samą ilość znaków 
        if (lenOfy != lenOfX)
        {
            Console.WriteLine("DH dla podanych wartości x,y nie istnieje");
            return;
        }
        //jeśli liczba znaków się zgadza, następuje obliczenie odległości Hamminga
        else
        {
            for (int i = 0; i <= x.Length - 1; ++i)
            {
                if (x[i] != y[i])
                {
                    dH++;
                }
            }
        }
        Console.WriteLine($"Odległość Hamminga DH(x,y) wynosi {dH}");
        
    }
    

}