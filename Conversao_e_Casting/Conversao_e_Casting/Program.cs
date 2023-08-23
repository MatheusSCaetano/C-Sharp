using System;
using System.Globalization;

namespace Conversao_e_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x;
            double a;
            float b;
            int c = 5;
            int d = 2;

            Console.WriteLine(y);

            a = 5.1;
            b = (float) a; //Técnica do CASTING para uma variável de menos bytes receber;
            Console.WriteLine(b);

            c = (int)a;
            Console.WriteLine(c);

            double resultado =  (double)c/d ;
            Console.WriteLine(resultado);

        }
    }
}