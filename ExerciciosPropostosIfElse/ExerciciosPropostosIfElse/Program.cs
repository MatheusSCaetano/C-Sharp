using System;
using System.Globalization;

namespace ExerciciosPropostosIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            string msgPleno = ("Direitos civis plenos");
            string msgMenores = ("Direitos menores");
            string msgAlternativos = ("Direitos civis alternativos");

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Possui emancipação jurídica? 1(SIM) 2(NÃO)");
            int emancipacao = int.Parse(Console.ReadLine());

            if (emancipacao == 1)
            {
                Console.WriteLine("NOME: " + nome);
                Console.WriteLine("IDADE: " + idade);
                Console.WriteLine("SITUAÇÃO: " + msgPleno);
            }
            else if(emancipacao == 2)
            {
                if (idade >= 18)
                {
                    Console.WriteLine("NOME: " + nome);
                    Console.WriteLine("IDADE: " + idade);
                    Console.WriteLine("SITUAÇÃO: " + msgPleno);
                }
                else if(idade < 16)
                {
                    Console.WriteLine("NOME: " + nome);
                    Console.WriteLine("IDADE: " + idade);
                    Console.WriteLine("SITUAÇÃO: " + msgMenores);
                }
                else {
                    Console.WriteLine("NOME: " + nome);
                    Console.WriteLine("IDADE: " + idade);
                    Console.WriteLine("SITUAÇÃO: " + msgAlternativos);
                }
            }
        }
    }
}