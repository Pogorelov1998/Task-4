using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Z4P
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите систему счисления: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число: ");
            string p = Console.ReadLine();
            for(int i=0;i<p.Length;i++)
                if (p[i] - '0' >= s)
                {
                    Console.Write("Число некорректно!\n");
                    Console.ReadKey();
                    return;
                }
            Console.Write("Число корректно!\n");
            Console.ReadKey();
        }
    }
}
