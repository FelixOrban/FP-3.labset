//(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 

namespace MajorBoyerMoore;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Vector = ");
        int[] v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int n = v.Length;


        int count = 0;
        int major = 0;

        for(int i = 0; i < n; ++i)
        {
            if(count == 0)
                major = v[i];
            
            if (v[i] == major)
                count++;
            else
                count--;
        }

        count = 0;
        for(int i = 0;i < n; ++i)
        {
            if(major == v[i])
                count++;
        }

        if (count > n / 2)
            Console.WriteLine($"Major number is {major}");
        else
            Console.WriteLine("Major number not exist in the vector");
    }
}
