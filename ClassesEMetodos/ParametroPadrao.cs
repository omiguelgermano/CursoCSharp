using System;
using System.Collections.Generic;
using System.Text;

/* PAR METRO COM VALOR PADRÃO */
// Ref ou Out não permite o uso de valor padrão prefixado no parametro. 
// inserindo o valor padrão no parametro, ao chamado o metodo sem informar valor, 
// o metodo utilizara para a expressão o valor que estar como padrão dentro do parametro. 
// Ou se um dos valores não for informado no metodo, será utilizado o valor padrão, 
// conforme declarado no parametro nomeado.

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a = 1, int b = 1) {
            return a + b;
        }

        public static void Executar() {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b: 7));
        }
    }
}
