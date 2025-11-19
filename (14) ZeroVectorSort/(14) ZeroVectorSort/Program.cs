//Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 

namespace ZeroVectorSort;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("Vector = ");
        int[] v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        if(n != v.Length)
        {
            Console.WriteLine("n is not match with the length of vector");
            return;
        }

        int count = 0;

        for (int i = 0; i < n; ++i)
        {
            if( v[i] != 0 )
            {
                v[count] = v[i];
                count++;
            }
        }

        for (int i = count; i < n; ++i)
            v[i] = 0;

        Console.WriteLine(string.Join(' ', v));
    }
}