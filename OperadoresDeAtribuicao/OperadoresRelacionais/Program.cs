using System;
using System.Globalization;

namespace OperadoresDeAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            //a +=2; // a = a+2;
            Console.WriteLine(a);
        }
    }
}