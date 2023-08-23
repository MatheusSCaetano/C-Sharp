using System;
using System.Security.Cryptography.X509Certificates;

namespace PraticandoClasses_Objetos
{
    internal class Abastecimento
    {
        public double Litros;
        public double ValorTotal;
        public double Km;
        public double KmTotal;
        public int NumeroRegistros;


        public double ValorLitro()
        {
            return ValorTotal / Litros;
        }
        public double KmsRodados()
        {
            for (int i =0; i <= NumeroRegistros; i++)
            {
                KmTotal = KmTotal + Km;
            }
            return KmTotal;
        }
    }
}
