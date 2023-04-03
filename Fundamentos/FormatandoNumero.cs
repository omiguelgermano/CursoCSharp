using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));// float 1, no caso, apenas uma casa decimal
            Console.WriteLine(valor.ToString("C"));//Dinaheiro, valor monetario, moeda.
            Console.WriteLine(valor.ToString("P"));//multiplica por 100 e adiciona o simbolo de Percentual
            Console.WriteLine(valor.ToString("#.##"));// fica definido o número de casas decimais pela quantidade de cerquilhas

            CultureInfo cultura = new CultureInfo("en-US");//Utiliza a informação cultural para preencher os dados 
            Console.WriteLine(valor.ToString("C0", cultura)); // o 'C' seguido do '0', significa SEM CASA DECIMAL

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//completa com 0 antes do número informado, preenchendo a quantidade total definida
        }
    }
}
