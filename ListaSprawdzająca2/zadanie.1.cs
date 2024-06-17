namespace ListaSprawdzająca2;

public class zadanie_1
{
    // zadanie 1. wykonane na talicach

    public static void Divide()
    {
        //Tablica L liczba całkowitych
        int[] L = {2,3,5,7,11};
        int [] result = {};
        int d = 3;
      
        //zabezpieczenie, gdyby wpisano d jako wartość inną niż l. naturalna
        if (d < 0)
        {
            Console.WriteLine("Podana wartość d jest nie poprawna. d musi być liczbą naturalną.");
            return;
        }
        
        //powinno dodawać do pustej listy result, te argumenty L, które spełniają warunek 
        for (int i = 0; i <= L.Length - 1; ++i)
        {
            var reszta = L[i] % d;
            if (reszta == 0)
            {
                result[i] =L[i];
            }
            

        }
        Console.WriteLine($"List of number is {result[0]} ");
    }
}
    
