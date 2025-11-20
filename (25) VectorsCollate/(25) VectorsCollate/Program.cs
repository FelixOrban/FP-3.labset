//(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 

namespace VectorsCollate;
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("1. Vector = ");
        int[] v1 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        Console.Write("2. Vector = ");
        int[] v2 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

        int n = v1.Length;
        int m = v2.Length;

        int[] v3 = new int[n + m];
        int i = 0, j = 0, count = 0;

        while (i < n && j < m)
        {
            if (v1[i] > v2[j])
                v3[count++] = v2[j++];

            else if (v1[i] < v2[j])
                v3[count++] = v1[i++];

            else if (v1[i] == v2[j])
            {
                v3[count++] = v1[i++]; 
                v3[count++] = v2[j++]; 
            }
        }
        while (i < n)
            v3[count++] = v1[i++]; 

        while(j < m)
            v3[count++] = v2[j++]; 


        Console.WriteLine("3. Vector = " + string.Join(" ", v3));
    }
}