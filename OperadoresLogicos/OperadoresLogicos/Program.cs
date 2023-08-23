using System;
using System.Globalization;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // && -> E
            // || -> ou
            // ! -> NÃO

            bool c1 = 2>3 && 4 != 5;
            bool c2 = 2>3 || 5 != 6;
            bool c3 = !(2>3);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}
      
