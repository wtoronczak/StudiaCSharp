namespace Lista2;

//Zadanie 4; File Handling; Tresć:  Write a program in C# Sharp to create a file and add some text.
// korzystano ze źródła: https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-text-file-in-C-Sharp/
// źródła : https://stackoverflow.com/questions/9559616/c-sharp-add-text-to-text-file-without-rewriting-it odpowiedz użytkownika Darin Dimitrov
public static class Zadanie2_3
{
    public static void CreatFile()
    {
        string filePath = @"E:\csharp\Newtwofile.txt";

        if (File.Exists(filePath))
        {
            File.AppendAllText(filePath, "Hallo hallo");
        }

        else
        {
            // źródła: https://www.c-sharpcorner.com/UploadFile/mahesh/create-a-text-file-in-C-Sharp/
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("Halo ");

            }

        }
    }
}