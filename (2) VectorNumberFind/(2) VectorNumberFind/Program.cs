//Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.

namespace VectorNumberFind;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("n : ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Type the vector numbers between spaces : ");
        int[] vector = Console.ReadLine().Split().Select(int.Parse).ToArray();
        if(n != vector.Length)
        {
            Console.WriteLine("The number of elements does not match n.");
            return;
        }

        Console.Write("k : ");
        int k = int.Parse(Console.ReadLine());

        for(int i=0; i<n; ++i)
        {
            if(vector[i] == k)
            {
                Console.WriteLine($"The position of {k} in the vector is : {i}");
                return;
            }
        }
        Console.WriteLine("-1");
    }
}