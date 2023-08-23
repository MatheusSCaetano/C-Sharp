using System;
using System.Globalization;

namespace ProjetoPraticando
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("  DADOS DOS VEÍCULOS");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" ");

            Console.WriteLine("Digite quantos kms o veículo rodoou este mês:");
            double kms = double.Parse(Console.ReadLine());
            while (kms < 0)
            {
                Console.WriteLine("Valor inválido!! Digite novamente quantos kms o veículo rodou este mês:");
                 kms = double.Parse(Console.ReadLine());
            }
            double litros=0,valor = 0, litros_total = 0, valor_total = 0;

            int finalizar = 0;

            Console.WriteLine("===ABASTECIMENTOS===");
            while (finalizar==0)
            {
                Console.Write("Litros:");
                litros = double.Parse(Console.ReadLine());
                Console.Write("Valor:");
                 valor = double.Parse(Console.ReadLine());

                litros_total = litros_total+litros;
                valor_total = valor_total+valor;

                Console.WriteLine(" ");
                Console.WriteLine("Digite 0 (Continuar)/ 1 (Finalizar)");
                finalizar = int.Parse(Console.ReadLine());
            }

            double consumo = kms/litros_total;
            double valorLitro = litros_total/valor_total; 

            Console.WriteLine("Kms rodados: " + kms);
            Console.WriteLine("Litros abastecidos: " + litros_total.ToString("F2"));
            Console.WriteLine("Valor total gasto R$ "+valor_total.ToString("F2"));
            Console.WriteLine(" ");
            Console.WriteLine("Consumo: " + consumo.ToString("F2") + " kms por litro");
            Console.WriteLine("Valor por litro gasto R$ "+valorLitro.ToString("F2"));

        }
    }
}