using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Exemplo de Enumeração 'enum', aplicado a categoria de filmes.

// https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/enum

// Um tipo de enumeração (ou tipo enum) é um tipo de valor definido por um conjunto
// de constantes nomeadas do tipo numérico integral subjacente. Para definir um tipo
// de enumeração, use a palavra-chave enum e especifique os nomes dos membros de enumeração:


namespace CursoCSharp.ClassesEMetodos {

    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    internal class ExemploEnum {
        public static void Executar() {
            Console.WriteLine("Enumeração.");
            Console.WriteLine();

            // Demostração do carregamento de indice do enumerador
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);
            Console.WriteLine();

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;
            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);

        }
    }
}
