//Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 

namespace BinarySearch;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Vector = ");
        int[] v = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        if(n!= v.Length)
        {
            Console.WriteLine("Numarul de elemente nu corespunde cu n!");
            return;
        }

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine()!);

        int left = 0;
        int right = n - 1;

        do
        {
            int mid = (left + right) / 2;

            if (v[mid] == k)
            {
                Console.WriteLine($"Position for the numnber {k} is {mid}");
                return;
            }

            if(v[mid] < k)
                left = mid + 1;
            else
                right = mid - 1;

        } while (left <= right);

        Console.WriteLine("-1");
    }
}