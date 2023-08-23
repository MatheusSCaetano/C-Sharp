using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /* double saldo = 10.35275;
             Console.WriteLine(saldo.ToString("F2"));//Duas casas decimais;
             Console.WriteLine(saldo.ToString("F4")); //Quatro casas...;
             Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //Além de imprimir as casas decimasi coloca os pontos de separador;
             */
            int idade = 32;
            double saldo = 10.3575;
            string nome = "Matheus";
            //Formas de concatenação:
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reias",nome,idade,saldo); // PLACEHOLDERS
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //INTERPOLAÇÃO;
            Console.WriteLine(nome + " tem" + idade + " anos e um saldo de " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " reais");//CONCATENAÇAO;
        }
    }
}