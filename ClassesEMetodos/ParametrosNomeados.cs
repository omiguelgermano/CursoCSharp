using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class ParametrosNomeados {

        public static void Formatar(int dia, int mes, int ano) {
                                    // Ordens dos parametros
            Console.WriteLine("Dia:{0:D2} Mês:{1:D2} Ano:{2}", dia, mes, ano);
                                    // Ordens que os parametros serão apresentados
                                    // conforme determinado nesta função.
        }

        public static void Executar() {
            Console.Write("Exemplo de Parametro Nomeado -> ");
            Formatar(2, 23, 1996);
            Console.Write("Exemplo de Parametro NÃO Nomeado -> ");
            Formatar(mes: 2, dia: 23, ano: 1996);
            // Nomeando o Parametro, você pode
            // alterar a ordem dos paametros
        }
    }
}
