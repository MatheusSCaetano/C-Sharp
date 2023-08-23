using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   //ler um texto até a quebra de linha
               Console.Write("Digite uma frase de bom dia:");
               string frase = Console.ReadLine();
               Console.WriteLine("frase: " + frase);

               Console.Write("Digite seu nome:");
               string nome = Console.ReadLine();

               Console.WriteLine("Digite sua idade:");
               string sobrenome = Console.ReadLine();

               Console.WriteLine("Nome Completo: " + nome + sobrenome);*/

            Console.Write("Digite:");
           
            //string s = Console.ReadLine();
            //string[] vet = s.Split(' ');
           
            //ou melhor:
            string[] vet = Console.ReadLine().Split(' ');
            
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}