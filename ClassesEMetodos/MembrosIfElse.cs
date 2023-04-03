using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class MembrosIfElse {
        public static void Executar() {
            Pessoa aluno1 = new Pessoa();
            aluno1.Nome = "Miguel";
            aluno1.Idade = 12;

            //aluno1.ApresentarNoConsole();
            //aluno1.Zerar();


            if (aluno1.Nome != "") {
                Console.WriteLine(aluno1.Nome);
            } else {
                Console.WriteLine("Nenhum dado encontrado!");
            }

            Console.WriteLine("Fim!");
        }
    }
}
