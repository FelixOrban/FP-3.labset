//Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 

namespace VectorsOrder;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("First Vector = ");
        char[] v1 = Console.ReadLine()!.Replace(" ", "").ToCharArray();

        Console.Write("Second Vector = ");
        char[] v2 = Console.ReadLine()!.Replace(" ", "").ToCharArray();

        int n = Math.Min(v1.Length, v2.Length);

        for (int i = 0; i < n; i++)
        {
            if (v1[i] < v2[i])
            {
                Console.WriteLine("The first vector is at the first in the order");
                return;
            }
            else if (v1[i] > v2[i])
            {
                Console.WriteLine("The second vector is at the first in the order");
                return;
            }
        }

        //at this point the 2 vectors are the same
        if (v1.Length < v2.Length) 
            Console.WriteLine("The first vector is at the first in the order");
        else if (v1.Length > v2.Length)
            Console.WriteLine("The second vector is at the first in the order");
        else
            Console.WriteLine("The 2 vectors are the same");
    }
}