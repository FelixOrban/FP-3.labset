//Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 

namespace BlackWhite;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("INPUT WITH SPACES\n");

        Console.Write("First string (W = white | B = black) -> ");
        char[] s1 = Console.ReadLine()!.Replace(" ", "").ToCharArray();

        Console.Write("Second string (W = white | B = black) -> ");
        char[] s2 = Console.ReadLine()!.Replace(" ", "").ToCharArray();

        if (s1.Length != s2.Length)
        {
            Console.WriteLine("The 2 strings must have the same length.");
            return;
        }

        int count = 0;

        for(int i = 0; i < s1.Length; ++i)
        {
            bool match = true;

            for(int j= 0; j < s2.Length; ++j)
            {
                if (s2[j] != s1[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
               count++;

            char first = s1[0];
            for (int k = 0; k < s1.Length - 1; ++k)
                s1[k] = s1[k + 1];
            s1[s1.Length - 1] = first;
        }
        Console.Write($"Number of perfect overlaps is {count}");
    }
}