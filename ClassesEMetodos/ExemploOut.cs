using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

/*
         * E ai pessoal, tudo bem?

        Alguns alunos tem relatado que a funcionalidade de out não ficou muito clara na aula, então estamos trazendo mais um exemplo que pode ajudar a compreender este conceito.

        O out é útil como uma forma duma função "retornar" mais de um valor, já que existem casos onde vamos querer obter mais de um valor a partir de uma função. Então, como não podemos retornar uma segunda variável pois isso não é permitido no C#, temos parâmetros marcados como out , que nada mais são do que variáveis para guardarmos valores que queremos retornar além do valor no return da função.

        Um bom exemplo é o método TryParse que é usado para converter um string num int. Caso ele consiga converter a string sem problemas, este método põe o resultado na variável out e retorna true, caso contrário, ele põe o número zero na variável out e retorna false. Um exemplo de uso típico desse método é o seguinte:

        string str = "100";
         if (int.TryParse(str, out int num))
         {
             Console.WriteLine("{0}", num + 1);
         }
         else
         {
         Console.WriteLine("A conversão falhou!");
         }
        Outro exemplo que pode ajudar a compreender este conceito é o exemplo abaixo, onde temos uma função que serve para calcular a media de 3 notas de um aluno, e além de retornar a média deste aluno também nos "retorna" por meio de um out se este aluno está aprovado ou reprovado:

        double calcularMedia(double nota1, double nota2, double nota3, out String conc){
         double media = (nota1+nota2+nota3)/3;
         conc = media >= 7? "aprovado": "reprovado";
         return media;
         }
 
         String conceito;
         double mediaDoAluno = Program.calcularMedia(1.6,9.4,5.0, out conceito);
         Console.WriteLine("A media é "+mediaDoAluno+ " e o aluno está " + conceito);
 
        Espero que com estes exemplos o conceito tenha ficado mais claro.

        Bons estudos!!
 * 
 */

namespace CursoCSharp.ClassesEMetodos {

    public class Program {
        public static double calcularMedia(double nota1, double nota2, double nota3, out String conc) {
            double media = (nota1 + nota2 + nota3) / 3;
            conc = media >= 7 ? "aprovado" : "reprovado";
            return media;
        }
    }
    internal class ExemploOut {
        public static void Executar() {

            String conceito;
            double mediaDoAluno = Program.calcularMedia(6.6, 9.4, 5.0, out conceito);
            Console.WriteLine("A media é " + mediaDoAluno + " e o aluno está " + conceito);

        }

    }
}
