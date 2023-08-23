using System;
using System.Globalization;

namespace ExerciciosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Digite o número:");
             int x = int.Parse(Console.ReadLine());

             for (int i = 1; i <= x; i++)
             {
                 if (i % 2 != 0)
                 {
                     Console.WriteLine("." + i);
                 }
             }*/

            /*
            //quantos no intervalo 10-20
           Console.WriteLine("Digite o numero de numeros a serem digitados:");
            int n = int.Parse(Console.ReadLine());

            for (int i=1;i<=n;i++)
            {
                Console.WriteLine("DIgite o numero que sera verificado:");
                int num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 20)
                {
                    Console.WriteLine("IN: {0}", num);
                }
                else
                {
                    Console.WriteLine("OUT: {0}", num);
                }*/

            /* EX3
            Console.WriteLine("Digite a quantidade de números:");
            int n = int.Parse(Console.ReadLine());

            
            for (int i=0;i < n; i++)
            {
                Console.Write("Digite os tres numeros: ");
                string[] l = Console.ReadLine().Split(' ');
                double a = double.Parse(l[0],CultureInfo.InvariantCulture);
                double b = double.Parse(l[1], CultureInfo.InvariantCulture);
                double c = double.Parse(l[2], CultureInfo.InvariantCulture);

                double media = (a*2.0 + b*3.0 + c*5.0)/10;

                Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
            }*/
            Console.Write("digite o número de verificações:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n;i++)
            {
                Console.WriteLine("Digite os números um ao lado do outro: ");
                string[] l = (Console.ReadLine().Split(' '));
                double n1 = double.Parse(l[0]);
                double n2 = double.Parse(l[1]);
                if (n1 != 0)
                {
                    Console.WriteLine("RESPOSTA:" + n1 / n2);
                }
                else
                {
                    Console.WriteLine("Divisão Impossível");
                }    
                }


        }//fim static void
    }//fim class
}//fim namespace