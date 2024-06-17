using System.Runtime.InteropServices;

namespace ListaSprawdzająca2;

public class zadanie1A
{
    //Napisz funkcję, która dla zadanych jako argumenty wejściowe: listy liczb całkowitych L
    // oraz liczby naturalnej d, zwróci listę takich liczb znajdujących się na L, które są podzielne
    //  przez d. Na przykład dla L=[1, 3, 4, -10, -21, 9] oraz d=3, funkcja powinna zwrócić
    // [3, -21, 9]. Funkcję opatrz komentarzem dokumentacyjnym. Napisz funkcję testującą,
    // pamiętając o przypadkach typowych i brzegowych.

    public static void FindDivide()
    {
        //lista L liczba całkowitych
        List <int> L = new List<Int32>
        {
            2,3,5,7,11
        };
        List<int> result = new List<Int32> (L.Count){};
        int d = 3;
      
        //zabezpieczenie, gdyby wpisano d jako wartość inną niż l. naturalna
        if (d < 0)
        {
            Console.WriteLine("Podana wartość d jest nie poprawna. d musi być liczbą naturalną.");
            return;
        }
        
        //powinno dodawać do pustej listy result, te argumenty L, które spełniają warunek 
        for (int i = 0; i <= L.Count - 1; ++i)
        {
            var reszta = L[i] % d;
            if (reszta == 0)
            {
                result.Add(L[i]);
            }
            

        }
        Console.WriteLine($"List of number is {result} ");
    }
}
