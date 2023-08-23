using System;
using System.Globalization;

namespace Escopo_e_Inicializacao
{
    class Program
    {
        static void Main(string[] args)
        {
           double preco = double.Parse(Console.ReadLine());
            double desconto = 0;
            //As variáveis que são declaradas no escopo maior funcionarão no escopo menor;

            if(preco > 100)
                //Variáveis criadas dentro desse escopo menor serão nulas no escopo maior;
            {
                desconto = preco * 0.1;
                preco = preco - desconto;
            }
            Console.WriteLine("O valor com desconto é: " + preco);
        }
    }
}