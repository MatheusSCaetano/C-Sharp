using System;
using System.Globalization;

namespace AulaFuncoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3); //"Maior" receberá o return de "m" e "resultado" receberá a função "Maior";
           double resultado2 = Menor(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado);
            Console.WriteLine("Menor = " + resultado2);

        } 
        static int Maior(int a, int b, int c)
        {
            int m;

            if(a>b && a > c)
            {
                m = a;
            } 
            else if (b>c)
            {
                 m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
        static int Menor(int a,int b, int c)
        {
            int menor;
            if(a < b && a < c)
            {
                menor = a;
            }
            else if (b<c)
            {
                menor = b;
            }
            else
            {
                menor = c;
            }
            return menor;
        }
    }
}

