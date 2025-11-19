//Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   

namespace ConvertBase;
using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine()!);

        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine()!);
        if (b < 2 || b>16)
        {
            Console.WriteLine("'b' must be a real base");
            return;
        }

        Console.WriteLine($"the number {n} from base 10 to base {b} is -> {Convert(n,b)}");
    }

    static string Convert(int n, int b)
    {
        StringBuilder num = new StringBuilder();

        while(n!=0)
        {
            int rest = n % b;
            char digit;

            if(rest < 10)
                digit = (char)('0' + rest);
            else
                digit = (char)('A' + (rest - 10));

            num.Insert(0, digit);
            n /= b;
        }

        return num.ToString();
    }
}