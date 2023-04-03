using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {
        public static void Executar() {
            Console.WriteLine("Array");

            // Array
            string[] alunos = new string[5];
            alunos[0] = "1";
            alunos[1] = "2";
            alunos[2] = "3";
            alunos[3] = "4";
            alunos[4]= "5";

            foreach(string aluno in alunos) {
                Console.Write(aluno + ", ");
                Console.WriteLine();
            }

            // Media no Array
            // Iniciando o Array com valor
            double somatorio = 0;// iniciando a variavel do tipo double
            double num = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in notas) {
                somatorio += nota;// estou somando e atribuindo cada valor dos elementos percorridos
                num++;
                Console.WriteLine("nota {0}: {1}", num, nota);
            }
            Console.WriteLine("Total nota: {0}", somatorio);
            double media = somatorio / notas.Length;//criando um nova variavel e já atrindo valor. 
            Console.WriteLine("Média notas: {0}", media);

         }
    }
}
