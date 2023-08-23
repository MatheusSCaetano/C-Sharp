using System;
using System.Globalization;

namespace While
{
    class Program
    {
        static void Main(string[] args) 
        {

            Console.WriteLine(  "Digite um numero:");
            double num = double.Parse( Console.ReadLine(),CultureInfo.InvariantCulture );
            
            while( num > 0 )
            {
                double raiz = Math.Sqrt(num);
                Console.WriteLine("Raiz: " + raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número: ");
                num = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Número negativo !!");
        } 
    }
}

