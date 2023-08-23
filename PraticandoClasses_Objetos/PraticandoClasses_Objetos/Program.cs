using PraticandoClasses_Objetos;
using System;
using System.Globalization;

namespace PraticandoClasse_Objetos 
{
    class Program
    {
        static void Main(string[] args)
        {
            Abastecimento a1;
            a1 = new Abastecimento();

            Console.WriteLine("Digite o número de registros:");
            a1.NumeroRegistros = int.Parse(Console.ReadLine());

            for (int i =0;i <= a1.NumeroRegistros;i++ )
            {
                Console.WriteLine("Digite a quantidade de litros do abastecimento " + i);
                a1.Litros = double.Parse(Console.ReadLine()); 
                
            }
        }
    }
}