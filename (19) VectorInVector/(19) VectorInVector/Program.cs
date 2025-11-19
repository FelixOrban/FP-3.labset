///Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 

namespace VectorInVector;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Vector S = ");
        int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.Write("Vector P = ");
        int[] p  = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int count = 0;
           
        for (int i = 0; i <= s.Length-p.Length; ++i)
        {
            bool match = true;

            for(int j= 0; j<p.Length; ++j)
            {
                if (p[j] != s[i+j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
                count++;
        }

        Console.WriteLine($"the P vector is {count} times in the S vector");
    }
}