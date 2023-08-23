using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostosClasseAtributosMetodos
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido;

        public void CalculoSalarioLiquido(double salarioliquido)
        {
            SalarioLiquido = SalarioBruto - Imposto;
            
        }
        
        public void AumentarSalario(double porcentagem,double valorporcentagem)
        {
            valorporcentagem = SalarioBruto * (porcentagem * 0.01);
            SalarioBruto = SalarioBruto + valorporcentagem;
        }
       public override string ToString()
        {
            return "Nome: " + Nome 
                +" "
               + " Salario Liquido: R$" + SalarioLiquido.ToString("F2",CultureInfo.InvariantCulture)
               +" "
               + " Imposto: R$" + Imposto.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
