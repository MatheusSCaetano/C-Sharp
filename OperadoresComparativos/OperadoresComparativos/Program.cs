using System;
using System.Globalization;
using System.Security.Cryptography;

namespace OperadoresComparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            bool c1 = a < 10;
            bool c2 = a > 10;
            bool c3 = a == 1;
            bool c4 = a <=1;
            bool c5 = a >=1;
            bool c6 = a != 1;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);
            Console.WriteLine(c6)  ;
        }
    }
}

