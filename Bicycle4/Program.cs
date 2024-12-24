namespace Bicycle4;

class Program
{
    static void Main(string[] args)
    {
        // SearchModule searchModule = new SearchModule();

        // int result = searchModule.LinearSearch([1, 2, 3, 5, 6, 7, 16, 8], 5);

        // Console.WriteLine(result);
        
        // int binarySearchResult = searchModule.BinarySearch([1, 2, 3, 5, 6, 7, 8], 5);

        // Console.WriteLine(binarySearchResult);
        
        // Task6 task6 = new Task6();

        // int task6Result = task6.CalculateSubsequence([1, 1, 0, 1, 0, 1, 1, 1, 0, 1,1,1,1,1,1,1,1]);
        // int task6Result = task6.CalculateSubsequence([1, 1, 0, 1, 0, 1, 1, 1]);

        // Console.WriteLine(task6Result);

        // int[] task1Array =
        // [
        //     1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29,
        //     30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56,
        //     57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83,
        //     84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100
        // ];
        //
        // Task1 task1 = new Task1();
        //
        // int task1Result = task1.JumpSearch(task1Array, 24);
        //
        // Console.WriteLine(task1Result);
        
        Task2 task2 = new Task2();

        int task2Result = task2.FindMostCommonByte([3, 3,3, 2,2,2]);

        Console.WriteLine(task2Result);
    }
}