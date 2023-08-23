using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            int num = 1;
            int num2 = 2147483647;
            long num3 = 0L;
            bool completo = false;
            char genero = 'f'; //Para um caractere;
            float num5 = 1.3f; //É necessário colocar o "f"a frente;
            string nome = "Maria Green";
            object obj1 = "Alex Alves"; //Genérico, ou seja, recebe qualquer ti´p de dado;
          
            byte n1 = 126;
            Console.WriteLine(n1);

            Console.WriteLine(x);

            num3 = num + num2;
            Console.WriteLine(num3);


            Console.WriteLine(completo);
            Console.WriteLine(genero);

        }
    }
}
