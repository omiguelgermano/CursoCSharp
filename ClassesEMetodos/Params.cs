using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    internal class Params {

        public static void Recepcionar(params string[] pessoas) {
        // Método Estatico/Classe      Palavra reservada 'params' - permite criar parametros variaveis.
        // tipo de variavel 'string[]' ( [] = array), 'pessoa' nome do parametro.

            foreach (var pessoa in pessoas) {
            // O 'foreach' é para percorrer todo o Array
            // 'var - pessoa' para declarar a variavel q irá armazenar os array
            // 'pessoa' - nome do array, criado no parametro método.

                Console.WriteLine("Olá {0}", pessoa);
                // Mostrar no concole do CSharp
            }
        }
        public static void Executar() {
            Recepcionar("Pedro", "Manu", "Miguel");
            // Atribuindo valores ao Array 'pessoa' por meio de parametros varaiveis.
            // Como o Método 'Recepcionar' já tem na função o Console.WriteLine,
            // não é preciso declarar novamente.
        }
    }
}
