using System;
using System.Linq;
namespace CS001_Array;
class Program
{
    static void Main(string[] args)
    {
        // Cac kieu khoi tao mang
        int[] array1;
        array1 = new int[5]; //Khoi tao mang co 5 phan tu
        array1[0] = 1;
        int[] array2 = new int[5] {1, 2, 3, 4, 5}; // Khoi tao mang co 5 phan tu va set luon gia tri
        int [ , ] array3 = new int[2, 3] {{1, 2, 3}, {2, 3, 6}}; // Khoi tao mang 2 chieu co 2 hang va 3 cot

        
        int[] numbers = {1, 5, 63, 23, 64, 7};

        // Duyet mang
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }

        // So chieu cua mang
        Console.WriteLine($"\nSo chieu cua mang: {numbers.Rank}");

        Console.WriteLine($"Min: {numbers.Min()}");
        Console.WriteLine($"Max: {numbers.Max()}");
        Console.WriteLine($"Sum: {numbers.Sum()}");

        // Sap xep tang dan
        Array.Sort( numbers );
        foreach (int number in numbers )
        {
            Console.Write($"{number} ");
        }

        // Mang nhieu chieu (2 hang, 3 cot)
        int [,] array = new int[2, 3] {{3, 5, 2}, {3, 6, 2}};
        Console.WriteLine("\n" + array[1, 1]);

        // Duyet mang 2 chieu
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(array[i, j]);
            }
        }

        Console.ReadKey();
    }
}
