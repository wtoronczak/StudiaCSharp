namespace Lista2;

public class Zadanie2_5
{
    //Zadanie 3; Searching and Sorting Algorithm Exercises;
    // Treść: Write a C# Sharp program to sort a list of elements using Bubble sort.
    //According to Wikipedia "Bubble sort, sometimes referred to as sinking sort, is a simple sorting algorithm that repeatedly steps through the list to be sorted, compares each pair of adjacent items and swaps them if they are in the wrong order.
    // The pass through the list is repeated until no swaps are needed, which indicates that the list is sorted. The algorithm, which is a comparison sort, is named for the way smaller elements "bubble" to the top of the list.
    // Although the algorithm is simple, it is too slow and impractical for most problems even when compared to insertion sort. It can be practical if the input is usually in sort order but may occasionally have some out-of-order elements nearly in position."
    public static void BubbleSort()
    {
        var sortList = new List<int> { 12,5, 4, 6, 7, 8, 1, 2,0 };
        var backUp = 0;
       
        for (int i= 0;i<sortList.Count - 1; ++i)
        {
            for (int j = 0; j < sortList.Count - 1; j++)
            {
                if (sortList[j] > sortList[j + 1])
                {
                    backUp = sortList[j + 1];
                    sortList[j + 1] = sortList[j];
                    sortList[j] = backUp;
                }
            }
            
        }

        foreach (var number in sortList)
        {
            Console.WriteLine(number);
        }
    }


}