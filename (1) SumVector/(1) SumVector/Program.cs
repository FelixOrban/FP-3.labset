//Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.

namespace SumVector;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"Type any numbers between spaces : ");
        int[] vector = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if (n != vector.Length)
        {
            Console.WriteLine("The number of elements does not match n.");
            return;
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += vector[i];
        }
        Console.WriteLine($"Sum of the numbers from the vector is : {sum}");
    }
}