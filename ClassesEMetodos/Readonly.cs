using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/readonly

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;
        public readonly DateTime Nascimento;

        //      READONLY - Atributo só de leitura, imultaveis ou Constante

        // DICA:        public static void Executar() {
        //        // ^ - Modificadores da função 'public'-> nível de visibilidade e 'static'-> de classe
        //        // ^ - Tipo de retorno 'void' - sempre ao lado do nome da função

        //        }

        //> paralavra reservada readonly= valor imultavel e avaliada no contexto de execução do problema,
        //enquanto que a constante:
        //A constanto é avaliada na compilação do programa, sendo obrigado INICIALIZA-LA.

        //Readonly -> quando queremos iniciar o valor diretamente no construtor, não precisando declarar
        //um valor fora do construtor para assim poder iniciar o programa.

        //Readonly -> setar um valor que é imultavel, somente de leitura.Sendo necesário instânciar para
        //atribuir um novo valor


        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento; // Readonly

        }

        public string GetDataNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
                Nascimento.Month, Nascimento.Year);
        }
    }

    internal class Readonly {
        public static void Executar() {
            Console.WriteLine("Readonly");

            var novoCliente = new Cliente("Ana Silva",
                new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());
            Console.WriteLine();

            var cliente2 = new Cliente("Miguel Germano",
                new DateTime(1986, 9, 15));
            Console.WriteLine(cliente2.Nome);
            Console.WriteLine(cliente2.GetDataNascimento());

        }
    }
}
