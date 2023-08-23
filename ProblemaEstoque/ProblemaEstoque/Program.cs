using System;
using System.Globalization;

namespace ProblemaEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); //Objeto "p" recebendo a classe Produto;
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade =int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

        }//Fim Main
    }//Fim class Program
}//Fimm namespace

