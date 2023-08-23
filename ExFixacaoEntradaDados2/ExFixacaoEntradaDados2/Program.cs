using System;
using System.Globalization;

namespace ExFixacaoEntradaDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem em sua casa?");
            int numQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine(" O preço:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(nome);
            Console.WriteLine(numQuartos);
            Console.WriteLine(preco);

            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }
    }
}